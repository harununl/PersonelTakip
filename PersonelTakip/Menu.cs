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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel prs= new Personel();
            this.Hide();
            prs.ShowDialog();
            this.Visible= true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IsListesi frmis = new IsListesi();
            this.Hide();
            frmis.ShowDialog(); 
            this.Visible= true;
        }

        private void btnMaas_Click(object sender, EventArgs e)
        {
            MaasListesi frmMaas = new MaasListesi();
            this.Hide();
            frmMaas.ShowDialog();
            this.Visible= true;
        }

        private void btnIzin_Click(object sender, EventArgs e)
        {
            IzınListesi frmIzin = new IzınListesi();
            this.Hide();
            frmIzin.ShowDialog(); this.Visible= true;
        }

        private void btnDepartman_Click(object sender, EventArgs e)
        {
            Departman frmDpt = new Departman();
            this.Hide();
            frmDpt.ShowDialog(); this.Visible= true;
        }

        private void btnPozisyon_Click(object sender, EventArgs e)
        {
            Pozisyon frmPzs= new Pozisyon();
            this.Hide();
            frmPzs.ShowDialog(); this.Visible= true;
        }
    }
}
