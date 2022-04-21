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
    public partial class MüşteriListelemeFormu : Form
    {
        Araç_kiralama arac_kiralama = new Araç_kiralama();
        public MüşteriListelemeFormu()
        {
            InitializeComponent();
        }
        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            YenileListele();
        }

        private void YenileListele()
        {
            string komut = "select * from MUSTERİ";
            OleDbDataAdapter adtr2 = new OleDbDataAdapter();
            dataGridView1.DataSource = arac_kiralama.listele(adtr2, komut);
        }

        private void txttcara_TextChanged(object sender, EventArgs e)
        {
            string komut = "select * from MUSTERİ where tc like '%" + txttcara.Text + "%'";
            OleDbDataAdapter adtr2 = new OleDbDataAdapter();
            dataGridView1.DataSource = arac_kiralama.listele(adtr2, komut);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txttc.Text = satır.Cells[0].Value.ToString();
            txtadsoyad.Text = satır.Cells[1].Value.ToString();
            txttelefon.Text = satır.Cells[2].Value.ToString();
            txtadres.Text = satır.Cells[3].Value.ToString();
            txteposta.Text = satır.Cells[4].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string komut = "update MUSTERİ set adsoyad='" + txtadsoyad.Text + "',telefon='" + txttelefon.Text + "',adres='" + txtadres.Text + "',eposta='" + txteposta.Text + "' where tc='" + txttc.Text + "'";
            OleDbCommand komut2 = new OleDbCommand();
            arac_kiralama.ekle_sil_guncelle(komut2, komut);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string komut = "delete from MUSTERİ where tc='" + satır.Cells["tc"].Value.ToString() + "'";
            OleDbCommand komut2 = new OleDbCommand();
            arac_kiralama.ekle_sil_guncelle(komut2, komut);
            //foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();
        }
    }
}
