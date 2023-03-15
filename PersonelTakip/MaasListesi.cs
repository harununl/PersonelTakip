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
    public partial class MaasListesi : Form
    {
        public MaasListesi()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaasBilgileri frmMaas = new MaasBilgileri();
            this.Hide();
            frmMaas.ShowDialog();
            this.Visible= true;
        }

        private void MaasListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet1.Pozisyon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           

        }
    }
}
