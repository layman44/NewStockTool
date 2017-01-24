using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool.App
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void tsmiGetStockInfo_Click(object sender, EventArgs e)
        {
            frmGetStock frmstock = frmGetStock.GetInstance();
            frmstock.MdiParent = this;
            frmstock.Show();
            frmstock.WindowState = FormWindowState.Maximized;
        }

        private void tsmiGetDailyData_Click(object sender, EventArgs e)
        {

        }

        private void tsmiGetLiftedShare_Click(object sender, EventArgs e)
        {

        }

        private void tsmiGetShareholderNum_Click(object sender, EventArgs e)
        {

        }
    }
}
