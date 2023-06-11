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
    public partial class frmEsnafListesi : Form
    {
        SqlConnection conn;
        string connectionString = "Server=OZELDERS004\\SQLEXPRESS;Database=MUTFAK;Trusted_Connection=True;";
        public frmEsnafListesi()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void frmEsnafListesi_Load(object sender, EventArgs e)
        {
            ListeyiGetir();
          
        }

        private void BtnEkle_Click_1(object sender, EventArgs e)
        {
            frmEsnafKayit frm = new frmEsnafKayit();
            frm.ShowDialog();
        }
        DataTable dt = new DataTable();

        private void dataEsnafList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataEsnafList.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataEsnafList.CurrentRow.Cells[1].Value.ToString();
            pnlBilgiler.Visible = true;
            btnSil.Enabled = true;

        }
        public void ListeyiGetir()
        {
            dt.Rows.Clear();
            try
            {
                string query = "select * from esnaflar";
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                var datareader = command.ExecuteReader();
                dt.Load(datareader);
                conn.Close();


                dataEsnafList.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "HATA");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "delete from esnaflar where id=" + txtID.Text;
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();


                conn.Close();

                txtID.Text = "";
                txtAdi.Text = "";
                txtAdres.Text = "";
                txtTelefon.Text = "";
                pnlBilgiler.Visible = true;
                btnSil.Enabled = true;
                MessageBox.Show("Esnaf Silindi");


                ListeyiGetir();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "HATA");
            }
        }
    }
}
