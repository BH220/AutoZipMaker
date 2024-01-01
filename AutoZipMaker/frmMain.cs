using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoZipMaker
{
    public partial class frmMain : Form
    {
        List<string> 제외처리파일 = new List<string>()
        {
            Path.GetFileName(Assembly.GetEntryAssembly().Location),
            "DotNetZip.dll"
        };
        string percentInfoFat = "({0}%)";
        public delegate void InvokeSetText(Control ctl, string text);

        public void SetText(Control ctr, string txtValue)
        {
            if (ctr.InvokeRequired)
            {
                InvokeSetText CI = new InvokeSetText(SetText);
                ctr.Invoke(CI, ctr, txtValue);
            }
            else
            {
                if (ctr.Equals(tbLog))
                {
                    tbLog.AppendText(Environment.NewLine);
                    tbLog.AppendText(txtValue);
                }
                else
                    ctr.Text = txtValue;
            }
        }

        bool IsStopFlag = false;

        public frmMain()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            tbPath.Text = Application.StartupPath;
#if DEBUG
            tbPath.Text = @"D:\Microsoft SQL Server\MSSQL11.IQUESTERP\MSSQL\Backup";
#else
            btnMake_Click(null, null);
#endif
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            IsStopFlag = false;
            btnMake.Enabled = false;
            btnSelect.Enabled = false;
            tbLog.Text = "";
            worker1.RunWorkerAsync();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog frm = new FolderBrowserDialog())
            {
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    tbPath.Text = frm.SelectedPath;
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            IsStopFlag = true;
            worker1.CancelAsync();
        }

        private void tbPath_Click(object sender, EventArgs e)
        {
            Process.Start(tbPath.Text);
        }

        private void worker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<FileInfo> listFiles = new List<FileInfo>();
            string[] files = Directory.GetFiles(tbPath.Text);
            foreach (string str in files)
            {
                listFiles.Add(new FileInfo(str));
            }

            DateTime 기준시간 = DateTime.Now.Date.AddDays(-1);
            List<FileInfo> targetList = listFiles.Where(
                x => x.Extension.ToLower() != ".zip" 
                    && 제외처리파일.Contains(x.Name) == false
                    && x.LastAccessTime.Date <= 기준시간
                    ).ToList();
            SetText(tbTotal, listFiles.Count.ToString("#,#"));
            SetText(tbTarget, targetList.Count.ToString("#,#"));

            int nowCnt = 1;
            int TotalCnt = targetList.Count;
            int percent = 0;
            string zipStart = "Compression Start: {0}/{1}";
            string logTerm = "Elapsed time: {0}";
            string zipResult = "Result: {0}..{1}";
            string errMsg = "";

            Stopwatch watch = new Stopwatch();

            foreach (FileInfo fInfo in targetList)
            {
                watch.Restart();
                if (IsStopFlag)
                    return;
                percent = (int)((nowCnt * 100) / TotalCnt);
                SetText(lbTotPercent, string.Format(percentInfoFat, percent));
                SetText(lbTot, string.Format("Total {0}/{1} Processing..", nowCnt.ToString("#,#"), TotalCnt.ToString("#,#")));
                SetText(tbLog, string.Format("{0}/{1} Processing..", nowCnt.ToString("#,#"), TotalCnt.ToString("#,#")));
                SetText(tbLog, string.Format(zipStart, DateTime.Now.ToString("HH:mm:ss:fff"), fInfo.Name));
                errMsg = MakeZipFile(fInfo);
                if (IsStopFlag)
                    return;
                File.Delete(fInfo.FullName);
                SetText(tbLog, string.Format(logTerm, GetTimeString(watch.ElapsedMilliseconds)));
                SetText(tbLog, string.Format(zipResult, string.IsNullOrEmpty(errMsg) ? "Sucess" : "Fail", errMsg));
                worker1.ReportProgress(percent, true);
                SetText(tbLog, Environment.NewLine);
                nowCnt++;
            }
        }

        private string GetTimeString(long tick)
        {
            if (tick < 1000)
            {
                return "0.1s";
            }
            else
            {
                tick = tick / 1000;
                if (tick < 60)
                {
                    return string.Format("{0}s", tick);
                }
                else if (tick < 60 * 60)
                {
                    return string.Format("{0}m {1}s", tick / (60 * 60), tick % 60);
                }
                else
                {
                    return string.Format("{0}h {1}m {2}s", tick / (60 * 60 * 60), tick / (60 * 60), tick % 60);
                }
            }
        }

        bool isCompleteZip = false;
        private string MakeZipFile(FileInfo fInfo)
        {
            try
            {
                isCompleteZip = false;
                using (ZipFile zFile = new ZipFile())
                {
                    zFile.AddFile(fInfo.FullName);
                    SetText(lbNow, fInfo.Name);
                    zFile.SaveProgress += ZFile_SaveProgress;
                    zFile.Save(fInfo.FullName + ".zip");
                    while(isCompleteZip == false)
                    {
                        if (IsStopFlag)
                            break;
                        Application.DoEvents();
                    }
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            return null;
        }

        private void ZFile_SaveProgress(object sender, SaveProgressEventArgs e)
        {
            int percentage = 0;
            switch (e.EventType)
            {
                case ZipProgressEventType.Saving_BeforeWriteEntry:
                    if (e.EntriesTotal > 0)
                        percentage = (int)((decimal)e.EntriesSaved / (decimal)e.EntriesTotal * 100m);
                    break;
                case ZipProgressEventType.Saving_EntryBytesRead:
                    if (e.BytesTransferred == 0)
                        percentage = 0;
                    else
                        percentage = (int)((new decimal(e.BytesTransferred) / new decimal(e.TotalBytesToTransfer)) * 100m);
                    break;
                case ZipProgressEventType.Saving_Completed:
                    percentage = 100;
                    isCompleteZip = true;
                    break;
            }

            SetText(lbNowPercent, string.Format(percentInfoFat, percentage));
            worker1.ReportProgress(percentage, false);
        }

        private void worker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            bool IsTotalPercent = (bool)e.UserState;
            if(IsTotalPercent)
                progressTotal.Value = e.ProgressPercentage;
            else
                progressNow.Value = e.ProgressPercentage;
        }

        private void worker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnSelect.Enabled = true;
            btnMake.Enabled = true;
            if (chkExit.Checked)
                Application.Exit();
        }
    }
}
