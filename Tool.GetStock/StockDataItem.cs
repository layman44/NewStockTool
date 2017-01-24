using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool.GetStock
{
    public class StockDataItem
    {
        /// <summary>
        /// 股票代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 股票简称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 上市日期
        /// </summary>
        public DateTime DateOfIPO { get; set; }
        /// <summary>
        /// 总股本(万股)
        /// </summary>
        public decimal ZGB { get; set; }
        /// <summary>
        /// 流通股本(万股)
        /// </summary>
        public decimal LTGB { get; set; }

    }
}
