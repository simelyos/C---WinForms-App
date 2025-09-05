using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APITEST
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrünEkle ürün_ekle_form = new UrünEkle();
            ürün_ekle_form.ShowDialog();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TEDARIK_LISTE tedarikciler = new TEDARIK_LISTE();
            tedarikciler.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BirimListe birimler = new BirimListe();
            birimler.ShowDialog();
        }
    }
}
