using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;



namespace APITEST
{


    public partial class Form1 : Form
    {
        public static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string url = "http://127.0.0.1:5000/api/urun/";

            var products = await GetApiDataAsync(url);

            dataGridView1.DataSource = products;

        }


        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string product_name = textBox1.Text;

                string url = $"http://127.0.0.1:5000/api/urun/isim_arama/{product_name}";

                var products = await GetApiDataAsync(url);

                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = true;

                dataGridView1.DataSource = products;
            }
            catch (Exception ex)
            {
            }



        }

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var payload = new
                {
                    urun_id = textBox2.Text,
                    urun_adi = textBox1.Text,
                    tedarikci_id = textBox3.Text,
                    birim_id = textBox4.Text
                };


                //var json = $"{{\"urun_id\":{urun_id},\"urun_adi\":{urun_adi},\"tedarikci_id\":{tedarikci_id},\"birim_id\":{birim_id}}}";

                string url = $"http://127.0.0.1:5000/api/urun/urun_ara/";

                string json = JsonSerializer.Serialize(payload);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(url, content);
                string responseData = await response.Content.ReadAsStringAsync();

                var products = JsonSerializer.Deserialize<List<URUN>>(responseData);

                dataGridView1.DataSource = products;


            }
            catch (Exception ex)
            {
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string supplier_id = textBox3.Text;

                string url = $"http://127.0.0.1:5000/api/urun/tedarikci/{supplier_id}/";

                var products = await GetApiDataAsync(url);

                dataGridView1.DataSource = products;
            }
            catch (Exception ex)
            {
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string unit_id = textBox4.Text;

                string url = $"http://127.0.0.1:5000/api/urun/birim/{unit_id}/";

                var products = await GetApiDataAsync(url);

                dataGridView1.DataSource = products;
            }
            catch (Exception ex)
            {
            }
        }

        private async void button7_Click(object sender, EventArgs e)
        {

            string url = $"http://127.0.0.1:5000/api/urun/urun_sil/";

            var json = $"{{\"urun_id\":{textBox2.Text}}}";

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(url, content);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            URUNGuncellecs urun_guncelle = new URUNGuncellecs();
            urun_guncelle.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            UrünEkle ürün_ekle_form = new UrünEkle();
            ürün_ekle_form.ShowDialog();
        }
    }
}
