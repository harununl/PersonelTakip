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
    public partial class Pozisyon : Form
    {
        public Pozisyon()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static DataClasses1DataContext db = new DataClasses1DataContext();
        List<PozisyonClass> liste = new List<PozisyonClass>();
        private void Pozisyon_Load(object sender, EventArgs e)
        {


            try
            {
                liste = db.PozisyonClass.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           

            dataGridView1.DataSource = liste;
           
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PozisyonEkle frmPzs = new PozisyonEkle();
            this.Hide();
            frmPzs.ShowDialog();
            this.Visible = true;
            try
            {
                liste = db.PozisyonClass.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }


            dataGridView1.DataSource = liste;
        }
    }
}
