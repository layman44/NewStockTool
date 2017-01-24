using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool.Common;
using Tool.Model;

namespace Tool.GetStock
{
    public class GetSZStock
    {
        public static List<Base_Stock> Convert(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0) return null;

            List<Base_Stock> baseinfos = new List<Base_Stock>();
            Base_Stock item = null;
            DateTime ipoDate;
            foreach (DataRow dr in dt.Rows)
            {
                item = new Base_Stock();
                item.Code = dr["公司代码"].ToString();
                item.Name = dr["公司简称"].ToString();
                if (DateTime.TryParse(dr["A股上市日期"].ToString(), out ipoDate))
                {
                    item.DateOfIPO = ipoDate;
                }
                else
                {
                    Console.WriteLine(string.Format("code:{0}---ipo:{1}", dr["公司代码"].ToString(), dr["A股上市日期"].ToString()));
                    continue;
                }
                item.FK_AreaId = 0;
                item.FK_IndustryId = 0;
                item.StockType = (int)Enums.StockType.SZ;
                baseinfos.Add(item);
            }
            return baseinfos;
        }
    }
}
