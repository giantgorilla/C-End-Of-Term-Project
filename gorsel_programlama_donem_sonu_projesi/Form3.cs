using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorsel_programlama_donem_sonu_projesi
{
    public partial class Form3 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Form3()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=emlak_otomasyonu;user=root;Pwd='';");
        }

        private void kayit_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_cikisyap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uyuglama Kapatılıyor...");
            foreach (Process process in Process.GetProcessesByName("emlak_otomasyonu"))
            {
                process.Kill();
            }
            Application.Exit();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            string mausteri_Adi = musteriAdi_tBox.Text;
            string musteriSifre = sifre_tBox.Text;
            cmd = new MySqlCommand("INSERT INTO musteri(musteri_Adi, musteriSifre) VALUES (@musteri_Adi, @musteriSifre)");
            con.Open();
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@musteri_Adi", musteriAdi_tBox.Text);
            cmd.Parameters.AddWithValue("@musteriSifre", sifre_tBox.Text);

            int ekle = cmd.ExecuteNonQuery();
            if (ekle > 0)
            {
                MessageBox.Show("Kaydınız başarıyla oluşturuldu!");
            }
            con.Close();
            MessageBox.Show("Müşteri sayfasına yönlendiriliyorsunuz!");
            this.Hide();
            Form4 frm = new Form4();
            frm.Show();
        }
    }
}
