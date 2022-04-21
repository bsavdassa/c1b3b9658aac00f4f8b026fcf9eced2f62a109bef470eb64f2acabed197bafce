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
            string komut = "update sözleşme set tc=@tc,adsoyad=@adsoyad,telefon=@telefon,e_belgeno=@e_belgeno,e_tarih=@e_tarih,e_yer=@e_yer,marka=@marka,seri=@seri,yil=@yil,renk=@renk,kiraşekli=@kiraşekli,kiraucreti=@kiraucreti,gun=@gun,tutar=@tutar,ctarih=@ctarih,dtarih=@dtarih where plaka=@plaka";
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
            MessageBox.Show("Sözleşme eklendi");
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTcsi.Text = satır.Cells[0].Value.ToString();
            txtAdısoyadı.Text = satır.Cells[1].Value.ToString();
            txtTelefonnumarası.Text = satır.Cells[2].Value.ToString();
            txtEhliyetnosu.Text = satır.Cells[3].Value.ToString();
            txtEhliyettarihi.Text = satır.Cells[4].Value.ToString();
            txtEhliyetinverildiğiyer.Text = satır.Cells[5].Value.ToString();
            cmbAraçlar.Text = satır.Cells[6].Value.ToString();
            txtAracınarkası.Text = satır.Cells[7].Value.ToString();
            txtAracınmodeli.Text = satır.Cells[8].Value.ToString();
            txtAracınmodeli.Text = satır.Cells[9].Value.ToString();
            txtAracınrengi.Text = satır.Cells[10].Value.ToString();
            cmbKiralamatürü.Text = satır.Cells[11].Value.ToString();
            txtKiraücreti.Text = satır.Cells[12].Value.ToString();
            txtGün.Text = satır.Cells[13].Value.ToString();
            txtAracıntutarı.Text = satır.Cells[14].Value.ToString();
            dateCikis.Text = satır.Cells[15].Value.ToString();
            dateDonus.Text = satır.Cells[16].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            int ucret = int.Parse(satır.Cells["kiraucreti"].Value.ToString());
            int tutar = int.Parse(satır.Cells["tutar"].Value.ToString());
            DateTime çıkış = DateTime.Parse(satır.Cells["ctarih"].Value.ToString());
            TimeSpan gun = bugün - çıkış;
            int _gun = gun.Days;
            int toplamTutar = _gun * ucret;
            string sorgu1 = "delete from sözleşme where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";
            OleDbCommand komut = new OleDbCommand();
            araçkiralama.ekle_sil_guncelle(komut, sorgu1);
            string sorgu2 = "update araçlar set durumu='boş' where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";
            OleDbCommand komut2 = new OleDbCommand();
            araçkiralama.ekle_sil_guncelle(komut2, sorgu2);
            Yenile(); 
        }
    }
}
