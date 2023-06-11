namespace MUTFAK
{
    partial class frmDepoListesi
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
            this.BtnEkle = new System.Windows.Forms.Button();
            this.dataDepoList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBilgiler = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDepoList)).BeginInit();
            this.pnlBilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(22, 159);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 0;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // dataDepoList
            // 
            this.dataDepoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDepoList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataDepoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDepoList.Location = new System.Drawing.Point(22, 202);
            this.dataDepoList.Name = "dataDepoList";
            this.dataDepoList.Size = new System.Drawing.Size(240, 150);
            this.dataDepoList.TabIndex = 1;
            this.dataDepoList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDepoList_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adı:";
            // 
            // pnlBilgiler
            // 
            this.pnlBilgiler.Controls.Add(this.txtAdi);
            this.pnlBilgiler.Controls.Add(this.txtID);
            this.pnlBilgiler.Controls.Add(this.label1);
            this.pnlBilgiler.Controls.Add(this.label2);
            this.pnlBilgiler.Location = new System.Drawing.Point(22, 42);
            this.pnlBilgiler.Name = "pnlBilgiler";
            this.pnlBilgiler.Size = new System.Drawing.Size(240, 100);
            this.pnlBilgiler.TabIndex = 4;
            this.pnlBilgiler.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(49, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtAdi
            // 
            this.txtAdi.Enabled = false;
            this.txtAdi.Location = new System.Drawing.Point(48, 62);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 5;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(162, 159);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmDepoListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 387);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.pnlBilgiler);
            this.Controls.Add(this.dataDepoList);
            this.Controls.Add(this.BtnEkle);
            this.Name = "frmDepoListesi";
            this.Text = "frmDepoListesi";
            this.Load += new System.EventHandler(this.frmDepoListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDepoList)).EndInit();
            this.pnlBilgiler.ResumeLayout(false);
            this.pnlBilgiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.DataGridView dataDepoList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlBilgiler;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSil;
    }
}