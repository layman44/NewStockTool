namespace Tool.App
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.主页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGetStockInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGetDailyData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGetLiftedShare = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGetShareholderNum = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主页ToolStripMenuItem,
            this.数据ToolStripMenuItem,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(909, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // 主页ToolStripMenuItem
            // 
            this.主页ToolStripMenuItem.Name = "主页ToolStripMenuItem";
            this.主页ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.主页ToolStripMenuItem.Text = "主页";
            // 
            // 数据ToolStripMenuItem
            // 
            this.数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGetStockInfo,
            this.tsmiGetDailyData,
            this.tsmiGetLiftedShare,
            this.tsmiGetShareholderNum});
            this.数据ToolStripMenuItem.Name = "数据ToolStripMenuItem";
            this.数据ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.数据ToolStripMenuItem.Text = "数据";
            // 
            // tsmiGetStockInfo
            // 
            this.tsmiGetStockInfo.Name = "tsmiGetStockInfo";
            this.tsmiGetStockInfo.Size = new System.Drawing.Size(196, 22);
            this.tsmiGetStockInfo.Text = "获取股票基本信息数据";
            this.tsmiGetStockInfo.Click += new System.EventHandler(this.tsmiGetStockInfo_Click);
            // 
            // tsmiGetDailyData
            // 
            this.tsmiGetDailyData.Name = "tsmiGetDailyData";
            this.tsmiGetDailyData.Size = new System.Drawing.Size(196, 22);
            this.tsmiGetDailyData.Text = "获取每日交易数据";
            this.tsmiGetDailyData.Click += new System.EventHandler(this.tsmiGetDailyData_Click);
            // 
            // tsmiGetLiftedShare
            // 
            this.tsmiGetLiftedShare.Name = "tsmiGetLiftedShare";
            this.tsmiGetLiftedShare.Size = new System.Drawing.Size(196, 22);
            this.tsmiGetLiftedShare.Text = "获取解禁限售信息数据";
            this.tsmiGetLiftedShare.Click += new System.EventHandler(this.tsmiGetLiftedShare_Click);
            // 
            // tsmiGetShareholderNum
            // 
            this.tsmiGetShareholderNum.Name = "tsmiGetShareholderNum";
            this.tsmiGetShareholderNum.Size = new System.Drawing.Size(196, 22);
            this.tsmiGetShareholderNum.Text = "获取股东人数数据";
            this.tsmiGetShareholderNum.Click += new System.EventHandler(this.tsmiGetShareholderNum_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(64, 21);
            this.windowsMenu.Text = "窗口(&W)";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.cascadeToolStripMenuItem.Text = "层叠(&C)";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.tileVerticalToolStripMenuItem.Text = "垂直平铺(&V)";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.tileHorizontalToolStripMenuItem.Text = "水平平铺(&H)";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.closeAllToolStripMenuItem.Text = "全部关闭(&L)";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.arrangeIconsToolStripMenuItem.Text = "排列图标(&A)";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(61, 21);
            this.helpMenu.Text = "帮助(&H)";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.aboutToolStripMenuItem.Text = "关于(&A) ... ...";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 517);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(909, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel.Text = "状态";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 539);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "主页";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem 主页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiGetStockInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiGetDailyData;
        private System.Windows.Forms.ToolStripMenuItem tsmiGetLiftedShare;
        private System.Windows.Forms.ToolStripMenuItem tsmiGetShareholderNum;
    }
}



