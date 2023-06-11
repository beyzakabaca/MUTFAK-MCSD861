namespace MUTFAK
{
    partial class frmEsnafListesi
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
            this.dataEsnafList = new System.Windows.Forms.DataGridView();
            this.pnlBilgiler = new System.Windows.Forms.Panel();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataEsnafList)).BeginInit();
            this.pnlBilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(32, 177);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 0;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click_1);
            // 
            // dataEsnafList
            // 
            this.dataEsnafList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataEsnafList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataEsnafList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEsnafList.Location = new System.Drawing.Point(32, 227);
            this.dataEsnafList.Name = "dataEsnafList";
            this.dataEsnafList.Size = new System.Drawing.Size(240, 150);
            this.dataEsnafList.TabIndex = 2;
            this.dataEsnafList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEsnafList_CellContentClick);
            // 
            // pnlBilgiler
            // 
            this.pnlBilgiler.Controls.Add(this.txtTelefon);
            this.pnlBilgiler.Controls.Add(this.txtAdres);
            this.pnlBilgiler.Controls.Add(this.label4);
            this.pnlBilgiler.Controls.Add(this.label3);
            this.pnlBilgiler.Controls.Add(this.txtAdi);
            this.pnlBilgiler.Controls.Add(this.txtID);
            this.pnlBilgiler.Controls.Add(this.label1);
            this.pnlBilgiler.Controls.Add(this.label2);
            this.pnlBilgiler.Location = new System.Drawing.Point(32, 12);
            this.pnlBilgiler.Name = "pnlBilgiler";
            this.pnlBilgiler.Size = new System.Drawing.Size(240, 135);
            this.pnlBilgiler.TabIndex = 5;
            // 
            // txtAdi
            // 
            this.txtAdi.Enabled = false;
            this.txtAdi.Location = new System.Drawing.Point(48, 38);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(48, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adı:";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(175, 177);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adres:";
            // 
            // txtAdres
            // 
            this.txtAdres.Enabled = false;
            this.txtAdres.Location = new System.Drawing.Point(48, 71);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 20);
            this.txtAdres.TabIndex = 8;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Enabled = false;
            this.txtTelefon.Location = new System.Drawing.Point(48, 105);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 9;
            // 
            // frmEsnafListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.pnlBilgiler);
            this.Controls.Add(this.dataEsnafList);
            this.Controls.Add(this.BtnEkle);
            this.Name = "frmEsnafListesi";
            this.Text = "ESNAF LİSTESİ";
            this.Load += new System.EventHandler(this.frmEsnafListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEsnafList)).EndInit();
            this.pnlBilgiler.ResumeLayout(false);
            this.pnlBilgiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.DataGridView dataEsnafList;
        private System.Windows.Forms.Panel pnlBilgiler;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}