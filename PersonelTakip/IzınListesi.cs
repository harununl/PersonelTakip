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
    public partial class IzınListesi : Form
    {
        public IzınListesi()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IzınListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet1.Pozisyon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Izin_Bilgileri frmIzin = new Izin_Bilgileri();
            this.Hide();
            frmIzin.ShowDialog();
            this.Visible= true;
        }
    }
}
