namespace APITEST
{
    partial class UrünEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            urun_id = new TextBox();
            urun_adi = new TextBox();
            satis_fiyat = new TextBox();
            tedarikci_id = new TextBox();
            birim_id = new TextBox();
            alis_birim = new ComboBox();
            satis_birim = new ComboBox();
            satis_durum = new ComboBox();
            ithal_yerli = new ComboBox();
            alis_fiyat = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(921, 3);
            button1.Name = "button1";
            button1.Size = new Size(912, 56);
            button1.TabIndex = 0;
            button1.Text = "Ürün Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(912, 56);
            button2.TabIndex = 2;
            button2.Text = "Geri";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // urun_id
            // 
            urun_id.Location = new Point(3, 3);
            urun_id.Name = "urun_id";
            urun_id.PlaceholderText = "Ürün ID";
            urun_id.Size = new Size(177, 27);
            urun_id.TabIndex = 1;
            // 
            // urun_adi
            // 
            urun_adi.Location = new Point(186, 3);
            urun_adi.Name = "urun_adi";
            urun_adi.PlaceholderText = "Ürün Adı";
            urun_adi.Size = new Size(177, 27);
            urun_adi.TabIndex = 1;
            // 
            // satis_fiyat
            // 
            satis_fiyat.Location = new Point(369, 3);
            satis_fiyat.Name = "satis_fiyat";
            satis_fiyat.PlaceholderText = "Satış Fiyatı";
            satis_fiyat.Size = new Size(177, 27);
            satis_fiyat.TabIndex = 1;
            // 
            // tedarikci_id
            // 
            tedarikci_id.Location = new Point(1467, 3);
            tedarikci_id.Name = "tedarikci_id";
            tedarikci_id.PlaceholderText = "Tedarikçi ID";
            tedarikci_id.Size = new Size(177, 27);
            tedarikci_id.TabIndex = 1;
            // 
            // birim_id
            // 
            birim_id.Location = new Point(1650, 3);
            birim_id.Name = "birim_id";
            birim_id.PlaceholderText = "Birim ID";
            birim_id.Size = new Size(183, 27);
            birim_id.TabIndex = 1;
            // 
            // alis_birim
            // 
            alis_birim.DisplayMember = "Ad";
            alis_birim.DropDownStyle = ComboBoxStyle.DropDownList;
            alis_birim.FormattingEnabled = true;
            alis_birim.Items.AddRange(new object[] { "--Alış Birimi--", "Kg", "Lt", "Ad" });
            alis_birim.Location = new Point(735, 3);
            alis_birim.Name = "alis_birim";
            alis_birim.Size = new Size(177, 28);
            alis_birim.TabIndex = 3;
            // 
            // satis_birim
            // 
            satis_birim.DisplayMember = "Ad";
            satis_birim.DropDownStyle = ComboBoxStyle.DropDownList;
            satis_birim.FormattingEnabled = true;
            satis_birim.Items.AddRange(new object[] { "--Satış Birimi--", "Kg", "Lt", "Ad" });
            satis_birim.Location = new Point(918, 3);
            satis_birim.Name = "satis_birim";
            satis_birim.Size = new Size(177, 28);
            satis_birim.TabIndex = 3;
            // 
            // satis_durum
            // 
            satis_durum.DisplayMember = "Ad";
            satis_durum.DropDownStyle = ComboBoxStyle.DropDownList;
            satis_durum.FormattingEnabled = true;
            satis_durum.Items.AddRange(new object[] { "--Satış Durumu--", "A", "K" });
            satis_durum.Location = new Point(1101, 3);
            satis_durum.Name = "satis_durum";
            satis_durum.Size = new Size(177, 28);
            satis_durum.TabIndex = 3;
            // 
            // ithal_yerli
            // 
            ithal_yerli.DisplayMember = "Ad";
            ithal_yerli.DropDownStyle = ComboBoxStyle.DropDownList;
            ithal_yerli.FormattingEnabled = true;
            ithal_yerli.Items.AddRange(new object[] { "--İthal/Yerli--", "I", "Y" });
            ithal_yerli.Location = new Point(1284, 3);
            ithal_yerli.Name = "ithal_yerli";
            ithal_yerli.Size = new Size(177, 28);
            ithal_yerli.TabIndex = 3;
            // 
            // alis_fiyat
            // 
            alis_fiyat.Location = new Point(552, 3);
            alis_fiyat.Name = "alis_fiyat";
            alis_fiyat.PlaceholderText = "Alış Fiyatı";
            alis_fiyat.Size = new Size(177, 27);
            alis_fiyat.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(button2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1836, 62);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 10;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(urun_adi, 1, 0);
            tableLayoutPanel2.Controls.Add(urun_id, 0, 0);
            tableLayoutPanel2.Controls.Add(satis_fiyat, 2, 0);
            tableLayoutPanel2.Controls.Add(alis_fiyat, 3, 0);
            tableLayoutPanel2.Controls.Add(alis_birim, 4, 0);
            tableLayoutPanel2.Controls.Add(satis_birim, 5, 0);
            tableLayoutPanel2.Controls.Add(birim_id, 9, 0);
            tableLayoutPanel2.Controls.Add(ithal_yerli, 7, 0);
            tableLayoutPanel2.Controls.Add(tedarikci_id, 8, 0);
            tableLayoutPanel2.Controls.Add(satis_durum, 6, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 62);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1836, 48);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 272);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1706, 448);
            dataGridView1.TabIndex = 7;
            // 
            // UrünEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1836, 936);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "UrünEkle";
            Text = "UrünEkle";
            Load += UrünEkle_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox urun_id;
        private TextBox urun_adi;
        private TextBox satis_fiyat;
        private TextBox tedarikci_id;
        private TextBox birim_id;
        private ComboBox alis_birim;
        private ComboBox satis_birim;
        private ComboBox satis_durum;
        private ComboBox ithal_yerli;
        private TextBox alis_fiyat;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridView1;
    }
}