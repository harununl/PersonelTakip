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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PersonelEkle frmPrs = new PersonelEkle();
            this.Hide();
            frmPrs.ShowDialog();
            this.Visible= true;
            try
            {
                personel = db.PersonelClass.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }


            dataGridView1.DataSource = personel;
        }
        List<PersonelClass> personel= new List<PersonelClass>();
       
       
        public static DataClasses1DataContext db = new DataClasses1DataContext();
        private void Personel_Load(object sender, EventArgs e)
        {
            
            try
            {
                personel = db.PersonelClass.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           

            dataGridView1.DataSource= personel;
            dataGridView1.Columns[0].Visible = false;



            
            

        }
    }
}
