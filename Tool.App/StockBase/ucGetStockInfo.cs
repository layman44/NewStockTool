using System;
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
        public Enums.StockType CurrentType
        {
            get; private set;
        }
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
            DataTable result = Tool.GetStock.GetStockFactory.GetStock(currentType);
            if (result == null)
            {
                MessageBox.Show("数据获取异常");
                return;
            }
            dgvStock.DataSource = result;
        }
    }
}
