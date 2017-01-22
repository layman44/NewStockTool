using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool.App.StockBase;
using Tool.Common;

namespace Tool.App
{
    public partial class frmGetStock : Form
    {
        private frmGetStock()
        {
            InitializeComponent();
        }
        static frmGetStock instance = null;
        public static frmGetStock GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmGetStock();
            }
            return instance;
        }

        private void tsbSH_Click(object sender, EventArgs e)
        {
            bool isCreated = false;
            foreach (Control control in panelContainer.Controls)
            {
                if (control.GetType() == typeof(ucGetStockInfo) && (control as ucGetStockInfo).CurrentType == Enums.StockType.SH)
                {
                    isCreated = true;
                    control.Show();
                    control.BringToFront();
                    break;
                }
            }
            if (!isCreated)
            {
                ucGetStockInfo uc = new ucGetStockInfo(Enums.StockType.SH);
                uc.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(uc);
            }
        }

        private void tsbSZ_Click(object sender, EventArgs e)
        {
            bool isCreated = false;
            foreach (Control control in panelContainer.Controls)
            {
                if (control.GetType() == typeof(ucGetStockInfo) && (control as ucGetStockInfo).CurrentType == Enums.StockType.SZ)
                {
                    isCreated = true;
                    control.Show();
                    control.BringToFront();
                    break;
                }
            }
            if (!isCreated)
            {
                ucGetStockInfo uc = new ucGetStockInfo(Enums.StockType.SZ);
                uc.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(uc);
            }
        }
    }
}
