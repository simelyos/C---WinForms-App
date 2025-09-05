using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APITEST
{
    public partial class URUNGuncellecs : Form


    {
        public static readonly HttpClient client = new HttpClient();
        public URUNGuncellecs()
        {
            InitializeComponent();
        }

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

        private async void URUNGuncellecs_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            string url = "http://127.0.0.1:5000/api/urun/";

            var products = await GetApiDataAsync(url);

            dataGridView1.DataSource = products;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string product_id = textBox1.Text;

                string url = $"http://127.0.0.1:5000/api/urun/{product_id}/";

                var products = await GetApiDataAsync(url);

                dataGridView1.DataSource = products;
            }
            catch (Exception ex)
            {
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string url = "http://127.0.0.1:5000/api/urun/urun_guncelle/";
            try {
                var urun_id = Convert.ToInt32(dataGridView1.Rows[0].Cells["UrunId"].Value);
                var urun_adi = dataGridView1.Rows[0].Cells["UrunAdi"].Value.ToString();
                var satis_fiyat = Convert.ToDecimal(dataGridView1.Rows[0].Cells["SatisFiyati"].Value);
                var alis_fiyat = Convert.ToDecimal(dataGridView1.Rows[0].Cells["AlisFiyati"].Value);
                var alis_birim = dataGridView1.Rows[0].Cells["AlisBirimi"].Value.ToString();
                var satis_birim = dataGridView1.Rows[0].Cells["SatisBirimi"].Value.ToString();
                var satis_durum = dataGridView1.Rows[0].Cells["SatisDurumu"].Value.ToString();
                var ithal_yerli = dataGridView1.Rows[0].Cells["IthalYerli"].Value.ToString();
                var tedarikci_id = Convert.ToInt32(dataGridView1.Rows[0].Cells["TedarikciId"].Value);
                var birim_id = Convert.ToInt32(dataGridView1.Rows[0].Cells["BirimId"].Value);
                var barkod_id = Convert.ToInt32(dataGridView1.Rows[0].Cells["BarkodId"].Value);



                var json = $"{{\"urun_id\":{urun_id},\"urun_adi\":\"{urun_adi}\"," +
                        $"\"satis_fiyati\":{satis_fiyat},\"alis_fiyati\":{alis_fiyat}," +
                        $"\"alis_birimi\":\"{alis_birim}\",\"satis_birimi\":\"{satis_birim}\"," +
                        $"\"satis_durumu\":\"{satis_durum}\",\"ithal_yerli\":\"{ithal_yerli}\"," +
                        $"\"tedarikci_id\":{tedarikci_id},\"birim_id\":{birim_id},\"barkod_id\":{barkod_id}}}";

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

                
            }
            catch (Exception ex)
            {
            }



        }
            
}
    }

