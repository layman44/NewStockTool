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
using Tool.Model;

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

            this.btnImport.Enabled = false;
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
            if (result.Rows.Count > 0)
            {
                this.btnImport.Enabled = true;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            int itype = 0;
            using (Tool.Model.StockEntities context = new Model.StockEntities())
            {
                List<Base_Stock> baseinfos = null;
                if (currentType == Enums.StockType.SH)
                {
                    baseinfos = GetStock.GetSHStock.Convert(dgvStock.DataSource as DataTable);
                }
                else
                {

                }
                if (baseinfos == null || baseinfos.Count == 0)
                {
                    MessageBox.Show("数据获取异常");
                    return;
                }
                Base_Stock old = null;
                foreach (var item in baseinfos)
                {
                    old = (from s in context.Base_Stock where s.Code == item.Code select s).FirstOrDefault();
                    if (old != null)
                    {
                        continue;
                    }
                    context.Base_Stock.Add(item);
                }
                context.SaveChanges();
            }
        }
    }
}
