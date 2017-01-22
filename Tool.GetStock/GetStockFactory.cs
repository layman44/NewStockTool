using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool.Common;

namespace Tool.GetStock
{
    public class GetStockFactory
    {
        public static DataTable GetStock(Enums.StockType stype)
        {
            IGetStock stock = new GetStockBaseInfoFormUrl();
            return stock.GetStock(stype);
        }
    }
}
