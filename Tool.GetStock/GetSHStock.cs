using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using Tool.Common;
using Tool.Model;

namespace Tool.GetStock
{
    public class GetSHStock
    {
        private static List<DataItem> ReadData(string filePath, bool ingoreFirstRow)
        {
            string[] datas = File.ReadAllLines(filePath, Encoding.Default);
            if (datas == null || datas.Length == 0)
            {
                throw new Exception("数据错误");
            }
            if (ingoreFirstRow)
            {
                datas = datas.Skip(1).ToArray();
            }
            List<DataItem> result = new List<DataItem>();
            string[] spliteDatas = null;
            string tempItem = "";
            foreach (string item in datas)
            {
                tempItem = item.Trim();
                tempItem = System.Text.RegularExpressions.Regex.Replace(tempItem, @"\s+", "|");
                spliteDatas = tempItem.Split('|');
                result.Add(Parse(spliteDatas));
            }
            return result;
        }
        private static DataItem Parse(string[] datas)
        {
            if (datas == null || datas.Length != 7)
            {
                throw new Exception("格式错误");
            }
            DataItem item = new DataItem();
            item.Code = datas[0];
            item.Name = datas[1];
            DateTime dt;
            if (DateTime.TryParse(datas[4], out dt))
            {
                item.DateOfIPO = dt;
            }
            item.ZGB = Decimal.Parse(datas[5]);
            item.LTGB = Decimal.Parse(datas[6]);
            return item;
        }
        public DataTable GetStock(string filePath, bool ingoreFirstRow)
        {
            List<DataItem> result = ReadData(filePath, ingoreFirstRow);
            if (result == null || result.Count == 0)
            {
                return null;
            }
            return Common.DataTableExtend.ToDataTable(result);
        }
        public static List<Base_Stock> Convert(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0) return null;

            List<Base_Stock> baseinfos = new List<Base_Stock>();
            Base_Stock item = null;
            foreach (DataRow dr in dt.Rows)
            {
                item = new Base_Stock();
                item.Code = dr["Code"].ToString();
                item.Name = dr["Name"].ToString();
                item.DateOfIPO = DateTime.Parse(dr["DateOfIPO"].ToString());
                item.FK_AreaId = 0;
                item.FK_IndustryId = 0;
                item.StockType = (int)Enums.StockType.SH;
                baseinfos.Add(item);
            }
            return baseinfos;
        }
    }
    public class DataItem
    {
        /// <summary>
        /// 股票代码
        /// </summary>
        private string code;
        /// <summary>
        /// 股票简称
        /// </summary>
        private string name;
        /// <summary>
        /// 上市日期
        /// </summary>
        private DateTime dateOfIPO;
        /// <summary>
        /// 总股本(万股)
        /// </summary>
        private decimal zGB;
        /// <summary>
        /// 流通股本(万股)
        /// </summary>
        private decimal lTGB;

        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DateTime DateOfIPO
        {
            get
            {
                return dateOfIPO;
            }

            set
            {
                dateOfIPO = value;
            }
        }

        public decimal ZGB
        {
            get
            {
                return zGB;
            }

            set
            {
                zGB = value;
            }
        }

        public decimal LTGB
        {
            get
            {
                return lTGB;
            }

            set
            {
                lTGB = value;
            }
        }
    }
}
