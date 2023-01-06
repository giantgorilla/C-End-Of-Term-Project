using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace gorsel_programlama_donem_sonu_projesi
{
    public partial class Form1 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;database=emlak_otomasyonu;port=3306;password='';";
            MySqlConnection connection = new MySqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();
            */

            // Girilen Bilgilerin Veritabanında Olup Olmadığını Kontrol Et
            string id = kulID_tBox.Text;
            string username = kulUsername_tBox.Text;
            string password = kulPass_tBox.Text;
            string permlevel = kulPerm_tBox.Text;

            // Veritabanı Bağlantısının Kurulması
            string connectionString = "server=localhost;user=root;database=emlak_otomasyonu;port=3306;password='';";
            MySqlConnection connection = new MySqlConnection(connectionString);

            // Girilen Bilgilerin Veritabanındaki Herhangi Bir Kayıtla Eşleşip Eşleşmediğini Kontrol Edin
            string queryString = "SELECT COUNT(*) FROM kullanici WHERE kullanici_ID = @kullanici_ID AND kullanici_Adi = @kullanici_Adi AND kullanici_Sifre = @kullanici_Sifre AND kullanici_Yetki = @kullanici_Yetki";
            MySqlCommand command = new MySqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@kullanici_ID", kulID_tBox.Text);
            command.Parameters.AddWithValue("@kullanici_Adi", kulUsername_tBox.Text);
            command.Parameters.AddWithValue("@kullanici_Sifre", kulPass_tBox.Text);
            command.Parameters.AddWithValue("@kullanici_Yetki", kulPerm_tBox.Text);

            connection.Open();
            int count = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            if (count > 0)
            {
                // Giriş Başarılı
                MessageBox.Show("Admin Girişi Başarılı Hoşgeldiniz!");
                // 2. Forma Yönlendirme 
                this.Hide();
                Form2 frm = new Form2();
                frm.Show();
            }
            else
            {
                // Giriş Başarısız
                MessageBox.Show("Girilen Bilgiler Hatalı Tekrar Deneyiniz.");
                this.Hide();
                Form1 frm = new Form1();
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt Sayfasına Yönlendiriliyorsunuz!");
            this.Hide();
            Form3 frm = new Form3();
            frm.Show();
        }

        private void kullanici_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Müşteri Sayfasına Yönlendiriliyorsunuz!");
            this.Hide();
            Form4 frm = new Form4();
            frm.Show();
        }
    }
}
