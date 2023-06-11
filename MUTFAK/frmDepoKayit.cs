using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUTFAK
{
    public partial class frmDepoKayit : Form
    {
        SqlConnection conn;
        string connectionString = "Server=OZELDERS004\\SQLEXPRESS;Database=MUTFAK;Trusted_Connection=True;";
        public frmDepoKayit()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try { 
            string query = "insert into depo(adi) values('" + txtAdi.Text + "')";
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();


            txtAdi.Text = "";
            MessageBox.Show("Yeni depo eklendi");

                
        }
        catch (Exception ex){

            MessageBox.Show(ex.Message, "HATA");
            }

        }
    }
}
