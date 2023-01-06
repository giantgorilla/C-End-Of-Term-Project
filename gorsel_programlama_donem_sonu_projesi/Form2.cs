using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
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
using System.Windows.Input;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gorsel_programlama_donem_sonu_projesi
{
    public partial class Form2 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public Form2()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=emlak_otomasyonu;user=root;Pwd='';");

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_goruntule_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=emlak_otomasyonu;port=3306;password='';";
            MySqlConnection connection = new MySqlConnection(connectionString);

            // Veritabanında Kullanacağımız Tablo
            string queryString = "SELECT * FROM ev";
            MySqlCommand command = new MySqlCommand(queryString, connection);
            MySqlDataReader reader;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                // ListView'e Data Ekleme
                listView1.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["emlak_ID"].ToString());
                    item.SubItems.Add(reader["oda_Sayisi"].ToString());
                    item.SubItems.Add(reader["kat_Sayisi"].ToString());
                    item.SubItems.Add(reader["ev_Alani"].ToString());
                    item.SubItems.Add(reader["yapim_Tarihi"].ToString());
                    item.SubItems.Add(reader["ev_Turu"].ToString());
                    item.SubItems.Add(reader["isinma_Sekli"].ToString());
                    item.SubItems.Add(reader["ev_İl"].ToString());
                    item.SubItems.Add(reader["ev_İlce"].ToString());
                    item.SubItems.Add(reader["ev_Semt"].ToString());
                    // ListView'e Item Ekleme
                    listView1.Items.Add(item);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=emlak_otomasyonu;port=3306;password='';";
            MySqlConnection connection = new MySqlConnection(connectionString);
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                // Bağlantı İçin String İfade
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;

                MessageBox.Show("Silmek İstediğiniz Emlak_ID'yi Emlak_ID Adlı Kutucuğa Belirtiniz Ve Siliniz!");

                // DELETE KOMUTU
                cmd.CommandText = "DELETE FROM ev WHERE emlak_ID = @emlak_ID";

                // Parametre ekleme
                cmd.Parameters.AddWithValue("@emlak_ID", emlakID_tBox.Text);
                cmd.Parameters.AddWithValue("@oda_Sayisi", odaSayisi_tBox.Text);
                cmd.Parameters.AddWithValue("@kat_Sayisi", katSayisi_tBox.Text);
                cmd.Parameters.AddWithValue("@ev_Alani", evAlani_tBox.Text);
                cmd.Parameters.AddWithValue("@yapim_Tarihi", yapimTarihi_tBox.Text);
                cmd.Parameters.AddWithValue("@ev_Turu", evTuru_tBox.Text);
                cmd.Parameters.AddWithValue("@isinma_Sekli", isinmaSekli_tBox.Text);
                cmd.Parameters.AddWithValue("@ev_İl", evİl_tBox.Text);
                cmd.Parameters.AddWithValue("@ev_İlce", evİlce_tBox.Text);
                cmd.Parameters.AddWithValue("@ev_Semt", evSemt_tBox.Text);

                // Bağlantı Açma ve DELETE Komutunu Sorgulatma
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if the DELETE statement was successful
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Record deleted successfully.");
                }

            }

        }

            private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_kaydet2_Click(object sender, EventArgs e)
        {

            string emlak_ID = emlakID_tBox.Text;
            string oda_Sayisi = odaSayisi_tBox.Text;
            string kat_Sayisi = katSayisi_tBox.Text;
            string ev_Alani = evAlani_tBox.Text;
            string yapim_Tarihi = yapimTarihi_tBox.Text;
            string ev_Turu = evTuru_tBox.Text;
            string isinma_Sekli = isinmaSekli_tBox.Text;
            string ev_İl = evİl_tBox.Text;
            string ev_İlce = evİlce_tBox.Text;
            string ev_Semt = evSemt_tBox.Text;

            // Eve değer ekleme
            cmd = new MySqlCommand("INSERT INTO ev(emlak_ID, oda_Sayisi, kat_Sayisi, ev_Alani, yapim_Tarihi, ev_Turu, isinma_Sekli, ev_İl, ev_İlce, ev_Semt) VALUES (@emlak_ID, @oda_Sayisi, @kat_Sayisi, @ev_Alani, @yapim_Tarihi, @ev_Turu, @isinma_Sekli, @ev_İl, @ev_İlce, @ev_Semt)");
            con.Open();
            cmd.Connection = con;


            cmd.Parameters.AddWithValue("@emlak_ID", emlakID_tBox.Text);
            cmd.Parameters.AddWithValue("@oda_Sayisi", odaSayisi_tBox.Text);
            cmd.Parameters.AddWithValue("@kat_Sayisi", katSayisi_tBox.Text);
            cmd.Parameters.AddWithValue("@ev_Alani", evAlani_tBox.Text);
            cmd.Parameters.AddWithValue("@yapim_Tarihi", yapimTarihi_tBox.Text);
            cmd.Parameters.AddWithValue("@ev_Turu", evTuru_tBox.Text);
            cmd.Parameters.AddWithValue("@isinma_Sekli", isinmaSekli_tBox.Text);
            cmd.Parameters.AddWithValue("@ev_İl", evİl_tBox.Text);
            cmd.Parameters.AddWithValue("@ev_İlce", evİlce_tBox.Text);
            cmd.Parameters.AddWithValue("@ev_Semt", evSemt_tBox.Text);


            int ekle = cmd.ExecuteNonQuery();
            if (ekle > 0)
            {
                MessageBox.Show("Kayıt başarıyla eklendi!");
            }
            else
            {
                MessageBox.Show("Girilen Bilgiler Hatalı, Tekrar Deneyiniz!");
            }
            con.Close();

            /*
            string connectionString = "server=localhost;user=root;database=emlak_otomasyonu;port=3306;password='';";
            MySqlConnection connection = new MySqlConnection(connectionString);

            // Veritabanına Eklenecek Kolonlar ve Değerleri
            string queryString = "INSERT INTO ev(emlak_ID, oda_Sayisi, kat_Sayisi, ev_Alani, yapim_Tarihi, ev_Turu, isinma_Sekli, ev_İl, ev_İlce, ev_Semt, ev_Mahalle) VALUES (@emlak_ID, @oda_Sayisi, @kat_Sayisi, @ev_Alani, @yapim_Tarihi, @ev_Turu, @isinma_Sekli, @ev_İl, @ev_İlce, @ev_Semt)";
            MySqlCommand command = new MySqlCommand(queryString, connection);
            con.Open();

            if (emlakID_tBox != null && odaSayisi_tBox != null && katSayisi_tBox != null && evAlani_tBox != null && yapimTarihi_tBox != null && evTuru_tBox != null && isinmaSekli_tBox != null && evİl_tBox != null && evİlce_tBox != null && evSemt_tBox != null)
            {
                cmd.Parameters.AddWithValue("@emlak_ID", emlakID_tBox);
                cmd.Parameters.AddWithValue("@oda_Sayisi", odaSayisi_tBox);
                cmd.Parameters.AddWithValue("@kat_Sayisi", katSayisi_tBox);
                cmd.Parameters.AddWithValue("@ev_Alani", evAlani_tBox);
                cmd.Parameters.AddWithValue("@yapim_Tarihi", yapimTarihi_tBox);
                cmd.Parameters.AddWithValue("@ev_Turu", evTuru_tBox);
                cmd.Parameters.AddWithValue("@isinma_Sekli", isinmaSekli_tBox);
                cmd.Parameters.AddWithValue("@ev_İl", evİl_tBox);
                cmd.Parameters.AddWithValue("@ev_İlce", evİlce_tBox);
                cmd.Parameters.AddWithValue("@ev_Semt", evSemt_tBox);
            }

            int ekle = cmd.ExecuteNonQuery();
            if (ekle > 0)
            {
                MessageBox.Show("Kayıt başarıyla eklendi!");
            }
            else
            {
                MessageBox.Show("Girilen Bilgiler Hatalı, Tekrar Deneyiniz!");
            }
            con.Close();

            */

            /*

            // Veritabanı Bağlantısı
            string connectionString = "server=localhost;user=root;database=emlak_otomasyonu;port=3306;password='';";
            MySqlConnection connection = new MySqlConnection(connectionString);

            // Veritabanına Eklenecek Kolonlar ve Değerleri
            string queryString = "INSERT INTO ev(emlak_ID, oda_Sayisi, kat_Sayisi, ev_Alani, yapim_Tarihi, ev_Turu, isinma_Sekli, ev_İl, ev_İlce, ev_Semt, ev_Mahalle) VALUES (@emlak_ID, @oda_Sayisi, @kat_Sayisi, @ev_Alani, @yapim_Tarihi, @ev_Turu, @isinma_Sekli, @ev_İl, @ev_İlce, @ev_Semt)";
            MySqlCommand command = new MySqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@emlak_ID", emlakID_tBox.Text);
            command.Parameters.AddWithValue("@oda_Sayisi", odaSayisi_cBox.Text);
            command.Parameters.AddWithValue("@kat_Sayisi", katSayisi_cBox.Text);
            command.Parameters.AddWithValue("@ev_Alani", evAlani_cBox.Text);
            command.Parameters.AddWithValue("@ev_Turu", evTuru_cBox.Text);
            command.Parameters.AddWithValue("@isinma_Sekli", isinmaSekli_cBox.Text);
            command.Parameters.AddWithValue("@ev_İl", evİl_cBox.Text);
            command.Parameters.AddWithValue("@ev_İlce", evİlce_cBox.Text);
            command.Parameters.AddWithValue("@ev_Semt", evSemt_cBox.Text);
            // Add more parameters as needed

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            */

        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            
            string connectionString = "server=localhost;user=root;database=emlak_otomasyonu;port=3306;password='';";
            MySqlConnection connection = new MySqlConnection(connectionString);
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                // Set the connection string of the MySqlCommand object
                MySqlCommand command = new MySqlCommand();
                command.Connection = con;

                // UPDATE KOMUTU
                command.CommandText = "UPDATE ev SET emlak_ID = @emlak_ID, oda_Sayisi = @oda_Sayisi, kat_Sayisi = @kat_Sayisi, ev_Alani = @ev_Alani, yapim_Tarihi = @yapim_Tarihi, ev_Turu = @ev_Turu, isinma_Sekli = @isinma_Sekli, ev_İl = @ev_İl, ev_İlce = @ev_İlce, ev_Semt = @ev_Semt WHERE emlak_ID = @emlak_ID";

                // Parametre ekleme
                command.Parameters.AddWithValue("@emlak_ID", emlakID_tBox.Text);
                command.Parameters.AddWithValue("@oda_Sayisi", odaSayisi_tBox.Text);
                command.Parameters.AddWithValue("@kat_Sayisi", katSayisi_tBox.Text);
                command.Parameters.AddWithValue("@ev_Alani", evAlani_tBox.Text);
                command.Parameters.AddWithValue("@yapim_Tarihi", yapimTarihi_tBox.Text);
                command.Parameters.AddWithValue("@ev_Turu", evTuru_tBox.Text);
                command.Parameters.AddWithValue("@isinma_Sekli", isinmaSekli_tBox.Text);
                command.Parameters.AddWithValue("@ev_İl", evİl_tBox.Text);
                command.Parameters.AddWithValue("@ev_İlce", evİlce_tBox.Text);
                command.Parameters.AddWithValue("@ev_Semt", evSemt_tBox.Text);

                // Bağlantıyı Açma ve Güncelleme
                con.Open();
                int rowsAffected = command.ExecuteNonQuery();

                // Güncelleme Başarılıysa Measaj
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Record updated successfully.");
                }
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int emlak_ID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            int oda_Sayisi = int.Parse(listView1.SelectedItems[0].SubItems[1].Text);
            int kat_Sayisi = int.Parse(listView1.SelectedItems[0].SubItems[2].Text);
            int ev_Alani = int.Parse(listView1.SelectedItems[0].SubItems[3].Text);
            string yapim_Tarihi = listView1.SelectedItems[0].SubItems[4].Text;
            string ev_Turu = listView1.SelectedItems[0].SubItems[5].Text;
            string isinma_Sekli = listView1.SelectedItems[0].SubItems[6].Text;
            string ev_İl = listView1.SelectedItems[0].SubItems[7].Text;
            string ev_İlce = listView1.SelectedItems[0].SubItems[8].Text;
            string ev_Semt = listView1.SelectedItems[0].SubItems[9].Text;


        }

        private void btn_cikisyap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();

            MessageBox.Show("Giriş Sayfasına Yönlendiriliyor...");
            foreach (Process process in Process.GetProcessesByName("emlak_otomasyonu"))
            {
                process.Kill();
            }
            Application.Exit();
        }

        private void btn_cikisyap_Click_1(object sender, EventArgs e)
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

