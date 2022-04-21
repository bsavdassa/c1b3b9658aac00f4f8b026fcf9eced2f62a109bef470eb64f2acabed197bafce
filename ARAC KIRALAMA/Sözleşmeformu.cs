using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARAC_KIRALAMA
{
    public partial class Sözleşmeformu : Form
    {
        Araç_kiralama araçkiralama = new Araç_kiralama();
        public Sözleşmeformu()
        {
            InitializeComponent();
        }

        private void Sözleşmeformu_Load(object sender, EventArgs e)
        {
            Boş_araçlar();
            Yenile();
        }

        private void Boş_araçlar()
        {
            string sorgu2 = "select * from araçlar where durumu='boş'";
            araçkiralama.Boş_araçlar(cmbAraçlar, sorgu2);
        }

        private void Yenile()
        {
            string sorgu3 = "select * from sözleşme";
            OleDbDataAdapter adtr2 = new OleDbDataAdapter();
            dataGridView1.DataSource = araçkiralama.listele(adtr2, sorgu3);
        }

        private void txtTcsi_TextChanged(object sender, EventArgs e)
        {
            if (txtTcsi.Text == "") foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "select * from MUSTERİ where tc like '" + txtTcsi.Text + "'";
            araçkiralama.TC_ARA(txtTcsi, txtAdısoyadı, txtTelefonnumarası, sorgu2);
        }

        private void cmbAraçlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select * from ARAÇLAR where plaka like '" + cmbAraçlar.SelectedItem + "'";
            araçkiralama.CombodanGetir(cmbAraçlar, txtAracınarkası, txtAraçseri, txtAracınmodeli, txtAracınrengi, sorgu2);
        }

        private void cmbKiralamatürü_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select * from ARAÇLAR where plaka like '" + cmbAraçlar.SelectedItem + "'";
            araçkiralama.Ücrethesapla(cmbKiralamatürü, txtKiraücreti, sorgu2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TimeSpan gunfarkı = DateTime.Parse(dateDonus.Text) - DateTime.Parse(dateCikis.Text);
            int gunfarkı2 = gunfarkı.Days;
            txtGün.Text = gunfarkı2.ToString();
            txtAracıntutarı.Text = (gunfarkı2 * int.Parse(txtKiraücreti.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Temizleme();
        }

        private void Temizleme()
        {
            dateCikis.Text = DateTime.Now.ToShortDateString();
            dateDonus.Text = DateTime.Now.ToShortDateString();
            cmbKiralamatürü.Text = "";
            txtGün.Text = "";
            txtAracıntutarı.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string komut = "insert into sözleşme(tc,adsoyad,telefon,e_belgeno,e_tarih,e_yer,plaka,marka,seri,yil,renk,kiraşekli,kiraucreti,gun,tutar,ctarih,dtarih) values (@tc,@adsoyad,@telefon,@e_belgeno,@e_tarihi,@e_yer,@plaka,@marka,@seri,@yil,@renk,@kiraşekli,@kiraucreti,@gun,@tutar,@ctarih,@dtarih)";
            OleDbCommand komut2 = new OleDbCommand();
            komut2.Parameters.AddWithValue("@tc", txtTcsi.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdısoyadı.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefonnumarası.Text);
            komut2.Parameters.AddWithValue("@e_belgeno", txtEhliyetnosu.Text);
            komut2.Parameters.AddWithValue("@e_tarihi", txtEhliyettarihi.Text);
            komut2.Parameters.AddWithValue("@e_yer", txtEhliyetinverildiğiyer.Text);
            komut2.Parameters.AddWithValue("@plaka", cmbAraçlar.Text);
            komut2.Parameters.AddWithValue("@marka", txtAracınarkası.Text);
            komut2.Parameters.AddWithValue("@seri", txtAraçseri.Text);
            komut2.Parameters.AddWithValue("@yil", txtAracınmodeli.Text);
            komut2.Parameters.AddWithValue("@renk", txtAracınrengi.Text);
            komut2.Parameters.AddWithValue("@kiraşekli", cmbKiralamatürü.Text);
            komut2.Parameters.AddWithValue("@gun", int.Parse(txtGün.Text));
            komut2.Parameters.AddWithValue("@tutar", int.Parse(txtAracıntutarı.Text));
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraücreti.Text));
            komut2.Parameters.AddWithValue("@ctarih", dateCikis.Text);
            komut2.Parameters.AddWithValue("@dtarih", dateDonus.Text);
            araçkiralama.ekle_sil_guncelle(komut2, komut);
            string sorgu3 = "update araçlar set durumu='dolu' where plaka='" + cmbAraçlar.Text + "'";
            OleDbCommand komut3 = new OleDbCommand();
            araçkiralama.ekle_sil_guncelle(komut3, sorgu3);
            cmbAraçlar.Items.Clear();
            Boş_araçlar();
            Yenile();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            Temizleme();
        }
    }
}
