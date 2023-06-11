using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUTFAK
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {

        }


        private void dEPOToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool formAcik = false;
            FormCollection fc = Application.OpenForms;
            foreach (var item in fc)
            {
                var form = (Form)item;
                if (form.Name == "frmDepoListesi") formAcik = true;
            }
            if (!formAcik)
            {
                frmDepoListesi frm1 = new frmDepoListesi();
                frm1.MdiParent = this;
                frm1.Show();


            }


        }

        private void esnaflarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formAcik = false;
            FormCollection fc = Application.OpenForms;
            foreach (var item in fc)
            {
                var form = (Form)item;
                if (form.Name == "frmEsnafListesi") formAcik = true;
            }
            if (!formAcik)
            {
                frmEsnafListesi frm1 = new frmEsnafListesi();
                frm1.MdiParent = this;
                frm1.Show();



            }
        }
    }
}
