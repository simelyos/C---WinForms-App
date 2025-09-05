using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APITEST
{


    public partial class TEDARIK_LISTE : Form
    {
        public static readonly HttpClient client = new HttpClient();
        public TEDARIK_LISTE()
        {
            InitializeComponent();
        }

        private async Task<List<TEDARIKCI>> GetApiDataAsync(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();


            string json = await response.Content.ReadAsStringAsync();



            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<List<TEDARIKCI>>(json, options);
        }

        private void TEDARIK_LISTE_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string url = "http://127.0.0.1:5000/api/tedarikci/";

            var products = await GetApiDataAsync(url);

            dataGridView1.DataSource = products;

        }

        
    }
}
