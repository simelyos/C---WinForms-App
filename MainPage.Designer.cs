namespace APITEST
{
    partial class MainPage
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1386, 451);
            button1.Name = "button1";
            button1.Size = new Size(234, 137);
            button1.TabIndex = 0;
            button1.Text = "Ürünler";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(209, 451);
            button3.Name = "button3";
            button3.Size = new Size(234, 137);
            button3.TabIndex = 2;
            button3.Text = "Çıkış";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(968, 451);
            button4.Name = "button4";
            button4.Size = new Size(234, 137);
            button4.TabIndex = 3;
            button4.Text = "Tedarikçiler";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(596, 451);
            button5.Name = "button5";
            button5.Size = new Size(234, 137);
            button5.TabIndex = 4;
            button5.Text = "Birimler";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1842, 864);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "MainPage";
            Text = "MainPage";
            Load += MainPage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}