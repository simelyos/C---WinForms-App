using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace APITEST
{
    public partial class UrünEkle : Form
    {
        public UrünEkle()
        {
            InitializeComponent();

        }

        public static readonly HttpClient client = new HttpClient();

        private async Task<List<URUN>> GetApiDataAsync(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();


            string json = await response.Content.ReadAsStringAsync();



            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<List<URUN>>(json, options);
        }

        private async void UrünEkle_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            alis_birim.SelectedIndex = 0;
            satis_birim.SelectedIndex = 0;
            ithal_yerli.SelectedIndex = 0;
            satis_durum.SelectedIndex = 0;

            string url = "http://127.0.0.1:5000/api/urun/";

            var products = await GetApiDataAsync(url);

            dataGridView1.DataSource = products;
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrWhiteSpace(urun_id.Text) ||
                    string.IsNullOrWhiteSpace(urun_adi.Text) ||
                    string.IsNullOrWhiteSpace(satis_fiyat.Text) ||
                    string.IsNullOrWhiteSpace(alis_fiyat.Text) || 
                    string.IsNullOrWhiteSpace(alis_birim.Text) ||
                    string.IsNullOrWhiteSpace(satis_birim.Text) ||
                    string.IsNullOrWhiteSpace(satis_durum.Text) ||
                    string.IsNullOrWhiteSpace(ithal_yerli.Text) ||
                    string.IsNullOrWhiteSpace(tedarikci_id.Text) ||
                    string.IsNullOrWhiteSpace(birim_id.Text) 
                    
                    )
                {
                    MessageBox.Show("Please fill all required fields.");
                    return;
                }


                HttpClient client = new HttpClient();

                string url = "http://127.0.0.1:5000/api/urun/urun_ekle/";



                var json = $"{{\"urun_id\":{urun_id.Text},\"urun_adi\":\"{urun_adi.Text}\"," +
                    $"\"satis_fiyati\":{satis_fiyat.Text},\"alis_fiyati\":{alis_fiyat.Text}," +
                    $"\"alis_birimi\":\"{alis_birim.Text}\",\"satis_birimi\":\"{satis_birim.Text}\"," +
                    $"\"satis_durumu\":\"{satis_durum.Text}\",\"ithal_yerli\":\"{ithal_yerli.Text}\"," +
                    $"\"tedarikci_id\":{tedarikci_id.Text},\"birim_id\":{birim_id.Text},\"barkod_id\":{urun_id.Text}}}";

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);

                string url1 = "http://127.0.0.1:5000/api/urun/";
                var products = await GetApiDataAsync(url1);

                dataGridView1.DataSource = products;

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Error" + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
