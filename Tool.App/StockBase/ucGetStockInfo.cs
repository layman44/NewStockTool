﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool.Common;

namespace Tool.App.StockBase
{
    public partial class ucGetStockInfo : UserControl
    {
        private Enums.StockType currentType = Enums.StockType.SH;
        public ucGetStockInfo(Enums.StockType stype)
        {
            InitializeComponent();
            if (stype == Enums.StockType.SH)
            {
                this.btnStart.Text = "开始获取上证A股";
            }
            else
            {
                this.btnStart.Text = "开始获取深成A股";
            }
            this.currentType = stype;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }
    }
}
