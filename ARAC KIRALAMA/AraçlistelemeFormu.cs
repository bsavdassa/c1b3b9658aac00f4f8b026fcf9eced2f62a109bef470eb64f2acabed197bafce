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
    public partial class AraçlistelemeFormu : Form
    {
        Araç_kiralama araçkiralama = new Araç_kiralama();
        public AraçlistelemeFormu()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtAraçPlakası.Text = satır.Cells["plaka"].Value.ToString();
            cmbAraçMarkası.Text = satır.Cells["marka"].Value.ToString();
            cmbAraçSeri.Text = satır.Cells["seri"].Value.ToString();
            txtAraçyıl.Text = satır.Cells["yıl"].Value.ToString();
            txtAraçrenk.Text = satır.Cells["renk"].Value.ToString();
            txtAraçkm.Text = satır.Cells["km"].Value.ToString();
            cmbAraçyakıt.Text = satır.Cells["yakıt"].Value.ToString();
            txtKiralamaücreti.Text = satır.Cells["kiraücreti"].Value.ToString();
            pictureBox2.ImageLocation = satır.Cells["resim"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string komut = "update araçlar set marka=@marka,seri=@seri,yıl=@yıl,renk=@renk,km=@km,yakıt=@yakıt,kiraücreti=@kiraücreti,resim=@resim,tarih=@tarih,durumu=@durumu where plaka=@plaka";
            OleDbCommand komut2 = new OleDbCommand();
            komut2.Parameters.AddWithValue("@plaka", txtAraçPlakası.Text);
            komut2.Parameters.AddWithValue("@marka", cmbAraçMarkası.Text);
            komut2.Parameters.AddWithValue("@seri", cmbAraçSeri.Text);
            komut2.Parameters.AddWithValue("@yıl", txtAraçyıl.Text);
            komut2.Parameters.AddWithValue("@renk", txtAraçrenk.Text);
            komut2.Parameters.AddWithValue("@km", txtAraçkm.Text);
            komut2.Parameters.AddWithValue("@yakıt", cmbAraçyakıt.Text);
            komut2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@kiraücreti", int.Parse(txtKiralamaücreti.Text));
            araçkiralama.ekle_sil_guncelle(komut2, komut);
            cmbAraçSeri.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox2.ImageLocation = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AraçlistelemeFormu_Load(object sender, EventArgs e)
        {
            YenileAraçListesi();
        }

        private void YenileAraçListesi()
        {
            string komut = "select * from araçlar";
            OleDbDataAdapter adtr2 = new OleDbDataAdapter();
            dataGridView1.DataSource = araçkiralama.listele(adtr2, komut);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string komut = "delete from araçlar where plaka = '" + satır.Cells["plaka"].Value.ToString() + "'";
            OleDbCommand komut2 = new OleDbCommand();
            araçkiralama.ekle_sil_guncelle(komut2, komut);
            YenileAraçListesi();
            pictureBox2.ImageLocation = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    YenileAraçListesi();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    string komut = "select * from araçlar WHERE durumu='boş'";
                    OleDbDataAdapter adtr2 = new OleDbDataAdapter();
                    dataGridView1.DataSource = araçkiralama.listele(adtr2, komut);
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    string komut = "select * from araçlar WHERE durumu='dolu'";
                    OleDbDataAdapter adtr2 = new OleDbDataAdapter();
                    dataGridView1.DataSource = araçkiralama.listele(adtr2, komut);
                }
            }
            catch
            {

            }
        }
    }
}
