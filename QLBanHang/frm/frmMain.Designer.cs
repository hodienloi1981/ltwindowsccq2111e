namespace QLBanHang.frm
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buôi2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Bai1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Bai2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buôi2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buôi2ToolStripMenuItem
            // 
            this.buôi2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bai1ToolStripMenuItem,
            this.Bai2ToolStripMenuItem,
            this.toolStripSeparator1,
            this.ThoatToolStripMenuItem});
            this.buôi2ToolStripMenuItem.Name = "buôi2ToolStripMenuItem";
            this.buôi2ToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.buôi2ToolStripMenuItem.Text = "Buôi 2";
            // 
            // Bai1ToolStripMenuItem
            // 
            this.Bai1ToolStripMenuItem.Image = global::QLBanHang.Properties.Resources._default;
            this.Bai1ToolStripMenuItem.Name = "Bai1ToolStripMenuItem";
            this.Bai1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.Bai1ToolStripMenuItem.Text = "Bài 1";
            this.Bai1ToolStripMenuItem.Click += new System.EventHandler(this.Bai1ToolStripMenuItem_Click);
            // 
            // Bai2ToolStripMenuItem
            // 
            this.Bai2ToolStripMenuItem.Image = global::QLBanHang.Properties.Resources.hitu40nam;
            this.Bai2ToolStripMenuItem.Name = "Bai2ToolStripMenuItem";
            this.Bai2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.Bai2ToolStripMenuItem.Text = "Bài 2";
            this.Bai2ToolStripMenuItem.Click += new System.EventHandler(this.Bai2ToolStripMenuItem_Click);
            // 
            // ThoatToolStripMenuItem
            // 
            this.ThoatToolStripMenuItem.Image = global::QLBanHang.Properties.Resources.Team5_800eb5c;
            this.ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem";
            this.ThoatToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ThoatToolStripMenuItem.Text = "Thoát";
            this.ThoatToolStripMenuItem.Click += new System.EventHandler(this.ThoatToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buôi2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Bai1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Bai2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}