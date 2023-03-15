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
    public partial class IsListesi : Form
    {
        public IsListesi()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static DataClasses1DataContext db = new DataClasses1DataContext();
        List<isDetay> liste = new List<isDetay>();
        List<İs> bilgi = new List<İs>();
        private void IsListesi_Load(object sender, EventArgs e)
        {

            var isb = (from i in db.İs
                       join p in db.PersonelClass on i.PersonelID equals p.ID
                       join d in db.DepartmanClass on p.DepartmanID equals d.ID
                       join pz in db.PozisyonClass on p.PozisyonID equals pz.ID
                       join durum in db.İsDurum on i.IsDurumID equals durum.ID
                       select new
                       {
                           isID = i.ID,
                           baslik = i.Baslik,
                           icerik = i.Icerik,
                           baslamaTarihi = i.IsBaslamaTarih,
                           bitisTarihi = i.IsBitisTarih,
                           userno = p.UserNo,
                           ad = p.Ad,
                           soyad = p.Soyad,
                           departman = d.DepartmanAd,
                           departmanID = p.DepartmanID,
                           pozisyonID = p.PozisyonID,
                           pozisyon = pz.PozisyonAdı,
                           isdurumu = durum.IsDurumAd,
                           isdurumID = i.IsDurumID
                       }).OrderBy(x => x.baslamaTarihi).ToList();
            foreach (var item in isb)
            {
                isDetay isbilgi = new isDetay();

                isbilgi.isID = item.isID;
                isbilgi.Baslik = item.baslik;
                isbilgi.Icerik = item.icerik;
                isbilgi.isBaslamaTarihi = item.baslamaTarihi;
                isbilgi.isBitisTarihi = item.bitisTarihi;
                isbilgi.UserNo = item.userno;
                isbilgi.Ad = item.ad;   
                isbilgi.Soyad= item.soyad;
                isbilgi.DepartmanAd = item.departman;
                isbilgi.PozisyonAd = item.pozisyon;
                isbilgi.DepartmanID = item.departmanID;
                isbilgi.PozisyonID = item.pozisyonID;
                isbilgi.isDurumAd = item.isdurumu;
                isbilgi.isDurumID = item.isdurumID;
               
               liste.Add(isbilgi);


            }



            bilgi = db.İs.ToList();

            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }


            dataGridView1.DataSource = bilgi;





        }

        private void button2_Click(object sender, EventArgs e)
        {
            IsBilgileri frmIs = new IsBilgileri();
            this.Hide();
            frmIs.ShowDialog();
            this.Visible= true;

            //isb = db.İs.ToList();

            //try
            //{

            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}


            //dataGridView1.DataSource = isb;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {







        }
    }
}
