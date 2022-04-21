using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARAC_KIRALAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriEklemeFormu ekle = new MusteriEklemeFormu();
            ekle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MüşteriListelemeFormu listele = new MüşteriListelemeFormu();
            listele.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AraçKayıt araçkayıt = new AraçKayıt();
            araçkayıt.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AraçlistelemeFormu araçlisteleme = new AraçlistelemeFormu();
            araçlisteleme.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sözleşmeformu sözleşmeformu = new Sözleşmeformu();
            sözleşmeformu.ShowDialog();
        }
    }
}
