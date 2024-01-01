namespace AutoZipMaker
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMake = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTotPercent = new System.Windows.Forms.Label();
            this.lbNowPercent = new System.Windows.Forms.Label();
            this.lbTot = new System.Windows.Forms.Label();
            this.lbNow = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.progressTotal = new System.Windows.Forms.ProgressBar();
            this.progressNow = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.worker1 = new System.ComponentModel.BackgroundWorker();
            this.chkExit = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbPath.Location = new System.Drawing.Point(75, 14);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(609, 21);
            this.tbPath.TabIndex = 0;
            this.tbPath.Click += new System.EventHandler(this.tbPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "TargetPath";
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(690, 13);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(81, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select Path";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkExit);
            this.panel2.Controls.Add(this.btnMake);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 27);
            this.panel2.TabIndex = 7;
            // 
            // btnMake
            // 
            this.btnMake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMake.Location = new System.Drawing.Point(617, 3);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(75, 23);
            this.btnMake.TabIndex = 0;
            this.btnMake.Text = "Make";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(698, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Cnt";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(75, 42);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(62, 21);
            this.tbTotal.TabIndex = 3;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "Target Cnt";
            // 
            // tbTarget
            // 
            this.tbTarget.Location = new System.Drawing.Point(259, 42);
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.ReadOnly = true;
            this.tbTarget.Size = new System.Drawing.Size(62, 21);
            this.tbTarget.TabIndex = 13;
            this.tbTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTarget);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPath);
            this.groupBox1.Controls.Add(this.tbTotal);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 71);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Target ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTotPercent);
            this.groupBox2.Controls.Add(this.lbNowPercent);
            this.groupBox2.Controls.Add(this.lbTot);
            this.groupBox2.Controls.Add(this.lbNow);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.progressTotal);
            this.groupBox2.Controls.Add(this.progressNow);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(5, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 93);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Percentage ";
            // 
            // lbTotPercent
            // 
            this.lbTotPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotPercent.Location = new System.Drawing.Point(675, 55);
            this.lbTotPercent.Name = "lbTotPercent";
            this.lbTotPercent.Size = new System.Drawing.Size(92, 12);
            this.lbTotPercent.TabIndex = 18;
            this.lbTotPercent.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbNowPercent
            // 
            this.lbNowPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNowPercent.Location = new System.Drawing.Point(709, 15);
            this.lbNowPercent.Name = "lbNowPercent";
            this.lbNowPercent.Size = new System.Drawing.Size(58, 12);
            this.lbNowPercent.TabIndex = 17;
            this.lbNowPercent.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbTot
            // 
            this.lbTot.AutoSize = true;
            this.lbTot.Location = new System.Drawing.Point(43, 55);
            this.lbTot.Name = "lbTot";
            this.lbTot.Size = new System.Drawing.Size(0, 12);
            this.lbTot.TabIndex = 20;
            this.lbTot.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbNow
            // 
            this.lbNow.AutoSize = true;
            this.lbNow.Location = new System.Drawing.Point(43, 15);
            this.lbNow.Name = "lbNow";
            this.lbNow.Size = new System.Drawing.Size(0, 12);
            this.lbNow.TabIndex = 19;
            this.lbNow.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 12);
            this.label15.TabIndex = 16;
            this.label15.Text = "Total:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 12);
            this.label16.TabIndex = 15;
            this.label16.Text = "Now:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // progressTotal
            // 
            this.progressTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressTotal.Location = new System.Drawing.Point(5, 69);
            this.progressTotal.Name = "progressTotal";
            this.progressTotal.Size = new System.Drawing.Size(764, 15);
            this.progressTotal.TabIndex = 14;
            // 
            // progressNow
            // 
            this.progressNow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressNow.Location = new System.Drawing.Point(5, 29);
            this.progressNow.Name = "progressNow";
            this.progressNow.Size = new System.Drawing.Size(764, 15);
            this.progressNow.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(5, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(774, 5);
            this.label4.TabIndex = 16;
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbLog);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(5, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(774, 208);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Log ";
            // 
            // tbLog
            // 
            this.tbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Location = new System.Drawing.Point(3, 17);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(768, 188);
            this.tbLog.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.Location = new System.Drawing.Point(5, 174);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(774, 5);
            this.label17.TabIndex = 18;
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // worker1
            // 
            this.worker1.WorkerReportsProgress = true;
            this.worker1.WorkerSupportsCancellation = true;
            this.worker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker1_DoWork);
            this.worker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker1_ProgressChanged);
            this.worker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker1_RunWorkerCompleted);
            // 
            // chkExit
            // 
            this.chkExit.AutoSize = true;
            this.chkExit.Checked = true;
            this.chkExit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExit.Location = new System.Drawing.Point(2, 6);
            this.chkExit.Name = "chkExit";
            this.chkExit.Size = new System.Drawing.Size(302, 16);
            this.chkExit.TabIndex = 15;
            this.chkExit.Text = "End of Program after completion of compression.";
            this.chkExit.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 419);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(350, 380);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Auto Zip Maker - JBH";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTot;
        private System.Windows.Forms.Label lbNow;
        private System.Windows.Forms.Label lbTotPercent;
        private System.Windows.Forms.Label lbNowPercent;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ProgressBar progressTotal;
        private System.Windows.Forms.ProgressBar progressNow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.Button btnStop;
        private System.ComponentModel.BackgroundWorker worker1;
        private System.Windows.Forms.CheckBox chkExit;
    }
}

