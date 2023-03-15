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
    public partial class Departman : Form
    {
        public Departman()
        {
            InitializeComponent();
        }
        public static DataClasses1DataContext db = new DataClasses1DataContext();
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<DepartmanClass> liste = new List<DepartmanClass>();
        private void Departman_Load(object sender, EventArgs e)
        {
            try
            {
                liste = db.DepartmanClass.ToList();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            dataGridView1.DataSource = liste;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Departman Ad";


        }
       public static DepartmanClass dpt = new DepartmanClass();
      
        private void button2_Click(object sender, EventArgs e)
        {
            DepartmanEkle frmDpt = new DepartmanEkle();

            this.Hide();
            frmDpt.ShowDialog();
            this.Visible= true;

            try
            {
                liste = db.DepartmanClass.ToList();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            dataGridView1.DataSource = liste;
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            
        }
    }
}
