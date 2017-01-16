namespace Tool.App
{
    partial class frmGetStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetStock));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSH = new System.Windows.Forms.ToolStripButton();
            this.tsbSZ = new System.Windows.Forms.ToolStripButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSH,
            this.tsbSZ});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(719, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSH
            // 
            this.tsbSH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSH.Image = ((System.Drawing.Image)(resources.GetObject("tsbSH.Image")));
            this.tsbSH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSH.Name = "tsbSH";
            this.tsbSH.Size = new System.Drawing.Size(56, 22);
            this.tsbSH.Text = "上证A股";
            this.tsbSH.Click += new System.EventHandler(this.tsbSH_Click);
            // 
            // tsbSZ
            // 
            this.tsbSZ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSZ.Image = ((System.Drawing.Image)(resources.GetObject("tsbSZ.Image")));
            this.tsbSZ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSZ.Name = "tsbSZ";
            this.tsbSZ.Size = new System.Drawing.Size(56, 22);
            this.tsbSZ.Text = "深成A股";
            this.tsbSZ.Click += new System.EventHandler(this.tsbSZ_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 25);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(719, 457);
            this.panelContainer.TabIndex = 1;
            // 
            // frmGetStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 482);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmGetStock";
            this.Text = "获取股票基本信息";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSH;
        private System.Windows.Forms.ToolStripButton tsbSZ;
        private System.Windows.Forms.Panel panelContainer;
    }
}