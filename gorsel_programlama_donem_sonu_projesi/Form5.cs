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
    public partial class Form5 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Form5()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=emlak_otomasyonu;user=root;Pwd='';");
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
    }
}
