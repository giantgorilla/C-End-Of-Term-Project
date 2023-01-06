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
    public partial class Form4 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Form4()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;database=emlak_otomasyonu;port=3306;password='';";
            MySqlConnection connection = new MySqlConnection(connectionString);
        }

        private void kullanici_btn_Click(object sender, EventArgs e)
        {

            // Girilen Bilgilerin Veritabanında Olup Olmadığını Kontrol Et
            string musteriadi = musteriAdi_tBox.Text;
            string musterisifre = sifre_tBox.Text;


            // Veritabanı Bağlantısının Kurulması
            string connectionString = "server=localhost;user=root;database=emlak_otomasyonu;port=3306;password='';";
            MySqlConnection connection = new MySqlConnection(connectionString);

            // Girilen Bilgilerin Veritabanındaki Herhangi Bir Kayıtla Eşleşip Eşleşmediğini Kontrol Edin
            string queryString = "SELECT COUNT(*) FROM musteri WHERE musteri_Adi = @musteri_Adi AND musteriSifre = @musteriSifre";
            MySqlCommand command = new MySqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@musteri_Adi", musteriAdi_tBox.Text);
            command.Parameters.AddWithValue("@musteriSifre", sifre_tBox.Text);

            connection.Open();
            int count = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            if (count > 0)
            {
                // Giriş Başarılı
                MessageBox.Show("Kullanıcı Girişi Başarılı Hoşgeldiniz!");
                // 5. Forma Yönlendirme 
                this.Hide();
                Form5 frm = new Form5();
                frm.Show();
            }
            else
            {
                // Giriş Başarısız
                MessageBox.Show("Girilen Bilgiler Hatalı Tekrar Deneyiniz.");
                this.Hide();
                Form4 frm = new Form4();
                frm.Show();
            }
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
    }
    }

