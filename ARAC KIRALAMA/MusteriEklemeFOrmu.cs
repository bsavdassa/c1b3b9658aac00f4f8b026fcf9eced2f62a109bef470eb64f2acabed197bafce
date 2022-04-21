using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace ARAC_KIRALAMA
{
    public partial class MusteriEklemeFormu : Form
    {
        Araç_kiralama arac_kiralama = new Araç_kiralama();
        public MusteriEklemeFormu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string komut = "insert into MUSTERİ(tc,adsoyad,telefon,adres,eposta)values(@tc,@adsoyad,@telefon,@adres,@eposta)";
            OleDbCommand komut2 = new OleDbCommand();
            komut2.Parameters.AddWithValue("@tc", txttc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut2.Parameters.AddWithValue("@adres", txtadres.Text);
            komut2.Parameters.AddWithValue("@eposta", txteposta.Text);
            arac_kiralama.ekle_sil_guncelle(komut2, komut);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }
    }
}
