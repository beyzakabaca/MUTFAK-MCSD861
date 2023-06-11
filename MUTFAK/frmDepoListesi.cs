using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUTFAK
{
    public partial class frmDepoListesi : Form
    {
        SqlConnection conn;
        string connectionString = "Server=OZELDERS004\\SQLEXPRESS;Database=MUTFAK;Trusted_Connection=True;";
        public frmDepoListesi()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            frmDepoKayit frm = new frmDepoKayit();
            frm.ShowDialog();
        }
        DataTable dt= new DataTable();
        private void frmDepoListesi_Load(object sender, EventArgs e)
        {
            ListeyiGetir();

        }
            public void ListeyiGetir()
            {
            
                try
                {
                    string query = "select * from depo";
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    var datareader = command.ExecuteReader();
                    dt.Load(datareader);
                    conn.Close();


                    dataDepoList.DataSource = dt;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "HATA");
                }
            }

        private void dataDepoList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataDepoList.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataDepoList.CurrentRow.Cells[1].Value.ToString();
            pnlBilgiler.Visible = true;
            btnSil.Enabled = true;
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            try
            {
                string query = "delete from depo where id=" + txtID.Text;
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();

              
                conn.Close();

                txtID.Text = "";
                txtAdi.Text = "";
                pnlBilgiler.Visible = true;
                btnSil.Enabled = true;
                MessageBox.Show("Depo Silindi");


                ListeyiGetir();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "HATA");
            }

        }
    }
}
