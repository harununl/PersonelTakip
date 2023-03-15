
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
    public partial class DepartmanEkle : Form
    {
        public DepartmanEkle()
        {
            InitializeComponent();
        }
        public static DataClasses1DataContext db = new DataClasses1DataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DepartmanEkle_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           DepartmanClass dpt = new DepartmanClass();

            if(txtDptAd.Text.Trim() != "")
            {
                dpt.DepartmanAd = txtDptAd.Text;
                MessageBox.Show("Departman Eklendi.");
                try
                {

                    db.DepartmanClass.InsertOnSubmit(dpt);
                    
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
              
                txtDptAd.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen Departman Adı giriniz..");

            }

           

           


               
            
      

            

            
        }
    }
}
