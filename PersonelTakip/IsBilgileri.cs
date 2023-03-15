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
    public partial class IsBilgileri : Form
    {
        public IsBilgileri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        List<PersonelClass> personels= new List<PersonelClass>();
        public static DataClasses1DataContext db = new DataClasses1DataContext();
        List<PozisyonClass> pozisyons = new List<PozisyonClass>();
        List<DepartmanClass> departmans = new List<DepartmanClass>();
         bool combofull = false;
        private void IsBilgileri_Load(object sender, EventArgs e)
        {

            try
            {
                personels = db.PersonelClass.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }

           
            dataGridView1.DataSource= personels;

            dataGridView1.Columns[0].Visible=false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;

            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;


            try
            {
                pozisyons = db.PozisyonClass.ToList();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            cmbpzs.DataSource = pozisyons;

            cmbpzs.DisplayMember= "PozisyonAdı";
            cmbpzs.ValueMember= "ID";
            cmbpzs.SelectedIndex = -1;

            try
            {
                departmans = db.DepartmanClass.ToList();

            }
            catch (Exception ex)
            {

                throw ex;
            }

            cmbdpt.DataSource = departmans;


            cmbdpt.DisplayMember = "DepartmanAd";
            cmbdpt.ValueMember = "ID";
            cmbdpt.SelectedIndex = -1;
            if (departmans.Count > 0)
            {
                combofull = true;
            }



        }
     
        private void cmbdpt_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (combofull)
            {
                int departmanId = Convert.ToInt32(cmbdpt.SelectedValue);

                cmbpzs.DataSource = pozisyons.Where(x =>x.DepartmanID== departmanId).ToList();
            }

        }
        İs isb = new İs();
        private void button2_Click(object sender, EventArgs e)
        {
            if(isb.PersonelID == 0)
            {
                MessageBox.Show("Personel seçin.");
            }
           else if (txtbs.Text.Trim() == "")
                MessageBox.Show("başlık");
           else if (rctxtbs.Text.Trim() == "")
                MessageBox.Show("başlık");
            else
            {
                isb.Baslik = txtbs.Text;
                isb.Icerik = rctxtbs.Text;
                isb.IsDurumID = 1;
                isb.IsBaslamaTarih = DateTime.Today;
               



                try
                {
                    db.İs.InsertOnSubmit(isb);
                    db.SubmitChanges();

                }
                catch (Exception ex)
                {

                    throw ex;
                }

                MessageBox.Show("İş Bilgileri Kaydedildi.");

                txtbs.Clear();
                rctxtbs.Clear();
                txtad.Clear();
                txtsoyad.Clear();
                txtuser.Clear();



            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView dg = new DataGridView();
            //dg = dataGridView1;
            
            ////txtuser.Text = dg.CurrentRow.Cells[1].Value.ToString();
            ////txtad.Text = dg.CurrentRow.Cells[2].Value.ToString();
            ////txtsoyad.Text = dg.CurrentRow.Cells[3].Value.ToString();

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            isb.PersonelID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            txtuser.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

        }
    }
}
