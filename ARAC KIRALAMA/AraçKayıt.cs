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
    public partial class AraçKayıt : Form
    {
        Araç_kiralama araçkiralama = new Araç_kiralama();
        public AraçKayıt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAraçMarkası_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbAraçSeri.Items.Clear();
                if (cmbAraçMarkası.SelectedIndex == 0)
                {
                    cmbAraçSeri.Items.Add("Astra");
                    cmbAraçSeri.Items.Add("Vectra");
                    cmbAraçSeri.Items.Add("Corsa");
                }
                else if (cmbAraçMarkası.SelectedIndex == 1)
                {
                    cmbAraçSeri.Items.Add("Megane");
                    cmbAraçSeri.Items.Add("Clio");
                }
                else if (cmbAraçMarkası.SelectedIndex == 2)
                {
                    cmbAraçSeri.Items.Add("Linea");
                    cmbAraçSeri.Items.Add("Egea");
                }
                else if (cmbAraçMarkası.SelectedIndex == 3)
                {
                    cmbAraçSeri.Items.Add("Fiesta");
                    cmbAraçSeri.Items.Add("Focus");
                }
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string komut = "insert into araçlar (plaka,marka,seri,yıl,renk,km,yakıt,kiraücreti,resim,tarih,durumu) values (@plaka,@marka,@seri,@yıl,@renk,@km,@yakıt," + txtKiralamaücreti.Text + ",'" + pictureBox1.ImageLocation + "','" + DateTime.Now.ToString() + "',@durumu)";
            OleDbCommand komut2 = new OleDbCommand();
            komut2.Parameters.AddWithValue("@plaka", txtAraçPlakası.Text);
            komut2.Parameters.AddWithValue("@marka", cmbAraçMarkası.Text);
            komut2.Parameters.AddWithValue("@seri", cmbAraçSeri.Text);
            komut2.Parameters.AddWithValue("@yıl", txtAraçyıl.Text);
            komut2.Parameters.AddWithValue("@renk", txtAraçrenk.Text);
            komut2.Parameters.AddWithValue("@km", txtAraçkm.Text);
            komut2.Parameters.AddWithValue("@yakıt", cmbAraçyakıt.Text);
            komut2.Parameters.AddWithValue("@durumu", "boş");
            cmbAraçSeri.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            araçkiralama.ekle_sil_guncelle(komut2, komut);
        }
    }
}
