using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip
{
    public partial class PozisyonEkle : Form
    {
        public PozisyonEkle()
        {
            InitializeComponent();
        }
        public static DataClasses1DataContext db = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<DepartmanClass> liste = new List<DepartmanClass>();
        private void PozisyonEkle_Load(object sender, EventArgs e)
        {
           
            
           liste =  db.DepartmanClass.ToList();

            cmbDpt.DataSource = liste;
            cmbDpt.DisplayMember = "DepartmanAd";
            cmbDpt.ValueMember = "ID";
            cmbDpt.SelectedIndex = -1;

           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            PozisyonClass pzs = new PozisyonClass();





            if (txtPzs.Text.Trim() != "" && cmbDpt.SelectedIndex != -1)
            {
                pzs.PozisyonAdı = txtPzs.Text;

                pzs.DepartmanID = Convert.ToInt32(cmbDpt.SelectedValue);
                MessageBox.Show("Pozisyon Eklendi.");
                try
                {
                    db.PozisyonClass.InsertOnSubmit(pzs);
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                txtPzs.Clear();
                cmbDpt.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Lütfen eksik bilgileri doldurunuz");
            }
        }
    }
}
