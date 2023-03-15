using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace PersonelTakip
{
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
                    }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<DepartmanClass> departman = new List<DepartmanClass>();
        List<PozisyonClass> pozisyon= new List<PozisyonClass>();
        public static DataClasses1DataContext db = new DataClasses1DataContext();
        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            departman = db.DepartmanClass.ToList();

            cmbDpt.DataSource= departman;

            cmbDpt.DisplayMember = "DepartmanAd";
            cmbDpt.ValueMember = "ID";
            cmbDpt.SelectedIndex = -1;


            pozisyon = db.PozisyonClass.ToList();
            cmbPzs.DataSource = pozisyon;

            cmbPzs.DisplayMember= "PozisyonAdı";
            cmbPzs.ValueMember = "ID";
            cmbPzs.SelectedIndex = -1;

            if (departman.Count > 0)
            {
                comboFull = true;
            }


        }
        string resimAd = "";
        PersonelClass personel = new PersonelClass();
        private void button2_Click(object sender, EventArgs e)
        {
           
            if (txtUser.Text.Trim() == "")
                MessageBox.Show("User No");
            if (txtAd.Text.Trim() == "")
                MessageBox.Show("Ad");
            if (txtSoyad.Text.Trim() == "")
                MessageBox.Show("Soyad");
            if (txtMaas.Text.Trim() == "")
                MessageBox.Show("Maas");
            if (txtResim.Text.Trim() == "")
                MessageBox.Show("Resim");
            if (txtAdres.Text.Trim() == "")
                MessageBox.Show("Adres");
            if (cmbDpt.SelectedIndex == -1)
                MessageBox.Show("Departman");
            if (cmbPzs.SelectedIndex == -1)
                MessageBox.Show("Pozisyon");
           
            else
            {
                personel.UserNo = Convert.ToInt32(txtUser.Text);
                personel.Ad = txtAd.Text;
                personel.Soyad = txtSoyad.Text;
                personel.Adres = txtAdres.Text;
                personel.DogumGunu = dateTimePicker1.Value;
                personel.Resim = resimAd;
                personel.Maas = Convert.ToInt32(txtMaas.Text);
                personel.isAdmin = chAdmin.Checked;
                personel.Password = txtSifre.Text;
                personel.PozisyonID = Convert.ToInt32(cmbPzs.SelectedValue);
                personel.DepartmanID = Convert.ToInt32(cmbDpt.SelectedValue);

                try
                {
                     
                    db.PersonelClass.InsertOnSubmit(personel);
                    db.SubmitChanges();

                }
                catch (Exception ex)
                {

                    throw ex;
                }
                File.Copy(txtResim.Text, @"resimlerNew\\" + resimAd);
                MessageBox.Show("personel eklendi.");
                txtUser.Clear();
                txtAd.Clear();
                txtSoyad.Clear();
                txtAdres.Clear();
                txtSifre.Clear();
                txtResim.Clear();
                resimAd = "";
                txtMaas.Clear();
                txtAdres.Clear();
                dateTimePicker1.Value = DateTime.Today;
                cmbDpt.SelectedIndex = -1;
                cmbPzs.SelectedIndex = -1;
                chAdmin.Checked = false;


            }
           

        }
        bool comboFull = false;
        private void cmbDpt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFull)
            {
                int departmanID = Convert.ToInt32(cmbDpt.SelectedValue);

                cmbPzs.DataSource = pozisyon.Where(x => x.DepartmanID == departmanID).ToList();
            }
           
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                txtResim.Text = openFileDialog1.FileName;

            }
            resimAd = Guid.NewGuid().ToString();
            resimAd += openFileDialog1.SafeFileName;
        }
        Personel prs = new Personel();
       

        private void button1_Click(object sender, EventArgs e)
        {


            
            
           



            if (txtUser.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen user no alanını doldurunuz.");

            }
            //else if (prs.dataGridView1.Rows.Contains(Convert.ToInt32(txtUser.Text)))
            //{
            //    MessageBox.Show("bu user no kullanılmaktadır");



            //}
            //else
            //{
            //    MessageBox.Show("User no kullanılabilir.");
            //}


        }
    }
}
