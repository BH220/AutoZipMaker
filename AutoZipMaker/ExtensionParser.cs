using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoZipMaker
{
    public static class ExtensionParser
    {
        /// <summary>
        /// object 객체를 int형으로 변환. 변환실패 시 0 반환
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static int ToIntEx(this object o)
        {
            int val = 0;

            if (o != null)
            {
                int.TryParse(o.ToString(), out val);
            }

            return val;
        }

        /// <summary>
        /// object 객체를 long형으로 변환. 변환실패 시 0L 반환
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static long ParseLongEx(this object o)
        {
            long val = 0L;

            if (o != null)
            {
                long.TryParse(o.ToString(), out val);
            }

            return val;
        }

        /// <summary>
        /// object 객체를 double형으로 변환. 변환실패 시 0d 반환
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static double ToDoubleEx(this object o)
        {
            double val = 0d;

            if (o != null)
            {
                double.TryParse(o.ToString(), out val);
            }

            return val;
        }

        /// <summary>
        /// object 객체를 decimal형으로 변환. 변환실패 시 0m 반환
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static decimal ToDecimalEx(this object o)
        {
            decimal val = decimal.Zero;

            if (o != null)
            {
                decimal.TryParse(o.ToString(), out val);
            }

            return val;
        }

        /// <summary>
        /// object 객체를 float형으로 변환. 변환실패 시 0f 반환
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static float ToFloatEx(this object o)
        {
            float val = 0f;

            if (o != null)
            {
                float.TryParse(o.ToString(), out val);
            }

            return val;
        }

        /// <summary>
        /// object 객체를 string형으로 변환. 변환실패 시 string.Empty 반환
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static string ToStringEx(this object o)
        {
            string val = string.Empty;

            if (o != null)
            {
                val = o.ToString();
            }

            return val;
        }

        /// <summary>
        /// object 객체를 bool형으로 변환. 변환실패 시 false 반환
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static bool ToBoolEx(this object o)
        {
            bool val = false;

            if (o != null)
            {
                bool.TryParse(o.ToString(), out val);
            }

            return val;
        }

        public static object GetDefaultValue(Type t)
        {
            if (t.IsValueType)
            {
                return Activator.CreateInstance(t);
            }
            else
            {
                if (t.Equals(typeof(string)))
                {
                    return string.Empty;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// object 객체를 int?형으로 변환. 변환실패 시 null 반환
        /// 2013.04.24 진병호
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static int? ToIntNullEx(this object o)
        {
            int? val = null;

            if (o != null)
            {
                int inVal = 0;
                bool blResult = int.TryParse(o.ToString(), out inVal);
                if (blResult)
                    val = inVal;
            }

            return val;
        }

        /// <summary>
        /// object 객체를 long형으로 변환. 변환실패 시 null 반환
        /// 2013.04.24 진병호
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static long? ToLongNullEx(this object o)
        {
            long? val = null;

            if (o != null)
            {
                long inVal = 0L;
                bool blResult = long.TryParse(o.ToString(), out inVal);
                if (blResult)
                    val = inVal;
            }

            return val;
        }

        public static long ToLongEx(this object o)
        {
            long val = 0L;

            if (o != null)
            {
                long inVal = 0L;
                bool blResult = long.TryParse(o.ToString(), out inVal);
                if (blResult)
                    val = inVal;
            }

            return val;
        }

        /// <summary>
        /// object 객체를 decimal형으로 변환. 변환실패 시 null 반환
        /// 2013.04.24 진병호
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static decimal? ToDecimalNullEx(this object o)
        {
            decimal? val = null;

            if (o != null)
            {
                decimal inVal = decimal.Zero;
                bool blResult = decimal.TryParse(o.ToString(), out inVal);
                if (blResult)
                    val = inVal;
            }

            return val;
        }

        /// <summary>
        /// object 객체를 float형으로 변환. 변환실패 시 null 반환
        /// 2013.04.24 진병호
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static float? ToFloatNullEx(this object o)
        {
            float? val = null;

            if (o != null)
            {
                float inVal = 0f;
                bool blResult = float.TryParse(o.ToString(), out inVal);
                if (blResult)
                    val = inVal;
            }

            return val;
        }

        public static char? ToCharNullEx(this object o)
        {
            char? var = null;
            if (o != null)
            {
                var = System.Convert.ToChar(o);
            }
            return var;
        }

        /// <summary>
        /// object 객체를 string형으로 변환. 변환실패 시 null 반환
        /// 2013.04.24 진병호
        /// </summary>
        /// <param name="o"></param>
        /// <param name="inCludeEmpty">문자열이 empty일 경우도 null로 변환 시키려면 true</param>
        /// <returns></returns>
        public static string ToStringNullEx(this object o, bool inCludeEmpty = false)
        {
            string val = null;

            if (o != null)
            {
                val = o.ToString();
            }

            if (o != null && inCludeEmpty && string.IsNullOrEmpty(val))
            {
                val = null;
            }

            return val;
        }

        /// <summary>
        /// object 객체를 DateTime? 형으로 변환
        /// </summary>
        /// <param name="o"></param>
        /// <returns>변환에 성공하면 DateTime 객체를 반환, 변환에 실패하면 null 반환</returns>
        public static DateTime? ToDateTimeEx(this object o)
        {
            DateTime? val = null;

            if (o != null && !System.Convert.IsDBNull(o))
            {
                try
                {
                    string[] allowFomattings = new string[] { "yyyyMMdd", "yyyy-MM-dd" };
                    System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("ko-KR");
                    DateTime ret = DateTime.MinValue;
                    if (DateTime.TryParseExact(o.ToString(), allowFomattings, cultureInfo, System.Globalization.DateTimeStyles.None, out ret))
                    {
                        val = ret;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return val;
        }

        public static DateTime ToDateTimeFromStringYYYYMMDD(this string str)
        {
            DateTime val = DateTime.Now;
            if (str.Length == 8)
            {
                try
                {
                    int year = str.Substring(0, 4).ToIntEx();
                    int month = str.Substring(4, 2).ToIntEx();
                    int day = str.Substring(6, 2).ToIntEx();
                    if (month > 0 && month <= 12 && day > 0 && day <= 31)
                        val = new DateTime(year, month, day);
                }
                catch { }
            }
            return val;
        }

        /// <summary>
        /// object 객체를 DateTime 형으로 변환
        /// </summary>
        /// <param name="o"></param>
        /// <returns>변환에 성공하면 DateTime 객체를 반환, 변환에 실패하면 기본값 반환(0001-01-01 12:00:00)</returns>
        public static DateTime ToDateTimeDefaultEx(this object o)
        {
            DateTime val = DateTime.MinValue;

            if (o != null && !System.Convert.IsDBNull(o))
            {
                try
                {
                    object valObj = TypeDescriptor.GetConverter(typeof(DateTime)).ConvertFromString(o.ToString());
                    if (valObj is DateTime)
                    {
                        val = (DateTime)valObj;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            return val;
        }

        public static DataTable MakePrintDataTable(this DataTable origin, string[] columns)
        {
            List<string> colList = new List<string>();
            colList.AddRange(columns);

            for (int idx = origin.Columns.Count - 1; idx >= 0; idx--)
            {
                if (colList.Contains(origin.Columns[idx].ColumnName) == false)
                    origin.Columns.RemoveAt(idx);
            }
            return origin.SetColumnsOrder(columns);
        }

        public static DataTable SetColumnsOrder(this DataTable table, params string[] columnNames)
        {
            int columnIndex = 0;
            foreach (var columnName in columnNames)
            {
                table.Columns[columnName].SetOrdinal(columnIndex);
                columnIndex++;
            }
            return table;
        }

        public static string GetFileSizeEx(this long byteSize)
        {
            string result = "";
            long size = byteSize;
            long left = 0;
            int step = 0;
            long defaultSize = 1024;

            while (size > defaultSize)
            {
                left = size % defaultSize;
                size = size / defaultSize;
                step++;
            }

            var strLeft = left.ToStringEx();
            if (strLeft.Length > 2)
                strLeft = strLeft.Substring(0, 2);

            switch (step)
            {
                case 0: result = string.Format("{0}Byte", size.ToString("#,0")); break;
                case 1: result = string.Format("{0}.{1}KB", size.ToString("#,0"), strLeft); break;
                case 2: result = string.Format("{0}.{1}MB", size.ToString("#,0"), strLeft); break;
                case 3: result = string.Format("{0}.{1}GB", size.ToString("#,0"), strLeft); break;
                case 4: result = string.Format("{0}.{1}TB", size.ToString("#,0"), strLeft); break;
            }
            return result;
        }
    }
}
