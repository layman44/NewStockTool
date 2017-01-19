﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool.Common;

namespace Tool.GetStock
{
    interface IGetStock
    {
        DataSet GetStock(Enums.StockType stype);
    }
}
