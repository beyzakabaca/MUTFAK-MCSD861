namespace MUTFAK
{
    partial class FrmAnaSayfa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kAYITLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEPOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esnaflarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kAYITLARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kAYITLARToolStripMenuItem
            // 
            this.kAYITLARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dEPOToolStripMenuItem,
            this.esnaflarToolStripMenuItem});
            this.kAYITLARToolStripMenuItem.Name = "kAYITLARToolStripMenuItem";
            this.kAYITLARToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.kAYITLARToolStripMenuItem.Text = "KAYITLAR";
            // 
            // dEPOToolStripMenuItem
            // 
            this.dEPOToolStripMenuItem.Name = "dEPOToolStripMenuItem";
            this.dEPOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dEPOToolStripMenuItem.Text = "depo";
            this.dEPOToolStripMenuItem.Click += new System.EventHandler(this.dEPOToolStripMenuItem_Click);
            // 
            // esnaflarToolStripMenuItem
            // 
            this.esnaflarToolStripMenuItem.Name = "esnaflarToolStripMenuItem";
            this.esnaflarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.esnaflarToolStripMenuItem.Text = "esnaflar";
            this.esnaflarToolStripMenuItem.Click += new System.EventHandler(this.esnaflarToolStripMenuItem_Click);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 392);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAnaSayfa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kAYITLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dEPOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esnaflarToolStripMenuItem;
    }
}

