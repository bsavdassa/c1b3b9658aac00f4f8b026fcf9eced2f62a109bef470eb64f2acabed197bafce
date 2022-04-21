using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ARAC_KIRALAMA
{
    class Araç_kiralama
    {
        OleDbConnection bağlantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=arackiralama.accdb");
        DataTable tablo;
        public void ekle_sil_guncelle(OleDbCommand komut, string sorgu)
        {
            bağlantı.Open();
            komut.Connection = bağlantı;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            bağlantı.Close();
        }
        public DataTable listele(OleDbDataAdapter adtr, string sorgu)
        {
            bağlantı.Open();
            tablo = new DataTable();
            adtr = new OleDbDataAdapter(sorgu, bağlantı);
            adtr.Fill(tablo);
            bağlantı.Close();
            return tablo;
        }
        public void Boş_araçlar(ComboBox combo, string sorgu)
        {
            bağlantı.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, bağlantı);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["plaka"].ToString());
            }
            bağlantı.Close();
        }
        public void TC_ARA(TextBox tc, TextBox adsoyad, TextBox telefon, string sorgu)
        {
            bağlantı.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, bağlantı);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                telefon.Text = read["telefon"].ToString();
                adsoyad.Text = read["adsoyad"].ToString();
            }
            bağlantı.Close();
        }
        public void CombodanGetir(ComboBox araclar, TextBox marka, TextBox seri, TextBox yil, TextBox renk, string sorgu)
        {
            bağlantı.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, bağlantı);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["marka"].ToString();
                seri.Text = read["seri"].ToString();
                yil.Text = read["yıl"].ToString();
                renk.Text = read["renk"].ToString();

            }
            bağlantı.Close();
        }
        public void Ücrethesapla(ComboBox combokira, TextBox ucret, string sorgu)
        {
            bağlantı.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, bağlantı);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (combokira.SelectedIndex == 0) ucret.Text = (int.Parse(read["kiraücreti"].ToString()) * 1).ToString();
                else if (combokira.SelectedIndex == 1) ucret.Text = (int.Parse(read["kiraücreti"].ToString()) * 0.80).ToString();
                else if (combokira.SelectedIndex == 2) ucret.Text = (int.Parse(read["kiraücreti"].ToString()) * 0.70).ToString();
            }
            bağlantı.Close();
        }
    }
}
