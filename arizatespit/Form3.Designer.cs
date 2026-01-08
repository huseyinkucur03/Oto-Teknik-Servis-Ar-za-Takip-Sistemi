namespace arizatespit
{
    partial class Form3
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
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButtonSehir = new RadioButton();
            radioButtonAdSoyad = new RadioButton();
            radioButtonModel = new RadioButton();
            radioButtonTip = new RadioButton();
            radioButtonMarka = new RadioButton();
            radioButtonSeriNo = new RadioButton();
            textBoxArama = new TextBox();
            buttonArama = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listBoxSonuclar = new ListBox();
            label3 = new Label();
            panel1 = new Panel();
            label26 = new Label();
            label27 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButtonSehir);
            groupBox1.Controls.Add(radioButtonAdSoyad);
            groupBox1.Controls.Add(radioButtonModel);
            groupBox1.Controls.Add(radioButtonTip);
            groupBox1.Controls.Add(radioButtonMarka);
            groupBox1.Controls.Add(radioButtonSeriNo);
            groupBox1.Controls.Add(textBoxArama);
            groupBox1.Controls.Add(buttonArama);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(31, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 169);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Arama";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(200, 58);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 24);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Plaka";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(200, 89);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 24);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tümü";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButtonSehir
            // 
            radioButtonSehir.AutoSize = true;
            radioButtonSehir.Location = new Point(123, 118);
            radioButtonSehir.Name = "radioButtonSehir";
            radioButtonSehir.Size = new Size(63, 24);
            radioButtonSehir.TabIndex = 7;
            radioButtonSehir.TabStop = true;
            radioButtonSehir.Text = "Şehir";
            radioButtonSehir.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdSoyad
            // 
            radioButtonAdSoyad.AutoSize = true;
            radioButtonAdSoyad.Location = new Point(20, 89);
            radioButtonAdSoyad.Name = "radioButtonAdSoyad";
            radioButtonAdSoyad.Size = new Size(94, 24);
            radioButtonAdSoyad.TabIndex = 3;
            radioButtonAdSoyad.TabStop = true;
            radioButtonAdSoyad.Text = "Ad Soyad";
            radioButtonAdSoyad.UseVisualStyleBackColor = true;
            // 
            // radioButtonModel
            // 
            radioButtonModel.AutoSize = true;
            radioButtonModel.Location = new Point(123, 58);
            radioButtonModel.Name = "radioButtonModel";
            radioButtonModel.Size = new Size(73, 24);
            radioButtonModel.TabIndex = 5;
            radioButtonModel.TabStop = true;
            radioButtonModel.Text = "Model";
            radioButtonModel.UseVisualStyleBackColor = true;
            // 
            // radioButtonTip
            // 
            radioButtonTip.AutoSize = true;
            radioButtonTip.Location = new Point(20, 119);
            radioButtonTip.Name = "radioButtonTip";
            radioButtonTip.Size = new Size(51, 24);
            radioButtonTip.TabIndex = 4;
            radioButtonTip.TabStop = true;
            radioButtonTip.Text = "Tip";
            radioButtonTip.UseVisualStyleBackColor = true;
            // 
            // radioButtonMarka
            // 
            radioButtonMarka.AutoSize = true;
            radioButtonMarka.Location = new Point(123, 88);
            radioButtonMarka.Name = "radioButtonMarka";
            radioButtonMarka.Size = new Size(71, 24);
            radioButtonMarka.TabIndex = 6;
            radioButtonMarka.TabStop = true;
            radioButtonMarka.Text = "Marka";
            radioButtonMarka.UseVisualStyleBackColor = true;
            // 
            // radioButtonSeriNo
            // 
            radioButtonSeriNo.AutoSize = true;
            radioButtonSeriNo.Location = new Point(20, 59);
            radioButtonSeriNo.Name = "radioButtonSeriNo";
            radioButtonSeriNo.Size = new Size(79, 24);
            radioButtonSeriNo.TabIndex = 2;
            radioButtonSeriNo.TabStop = true;
            radioButtonSeriNo.Text = "Seri No";
            radioButtonSeriNo.UseVisualStyleBackColor = true;
            // 
            // textBoxArama
            // 
            textBoxArama.Location = new Point(58, 26);
            textBoxArama.Name = "textBoxArama";
            textBoxArama.Size = new Size(125, 27);
            textBoxArama.TabIndex = 1;
            // 
            // buttonArama
            // 
            buttonArama.BackColor = Color.FromArgb(255, 224, 192);
            buttonArama.ForeColor = SystemColors.ControlText;
            buttonArama.Location = new Point(275, 60);
            buttonArama.Name = "buttonArama";
            buttonArama.Size = new Size(163, 53);
            buttonArama.TabIndex = 8;
            buttonArama.Text = "Arama Yap";
            buttonArama.UseVisualStyleBackColor = false;
            buttonArama.Click += buttonArama_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 29);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 0;
            label2.Text = "Ara:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-9, 271);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1072, 227);
            dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(278, 10);
            label1.Name = "label1";
            label1.Size = new Size(465, 32);
            label1.TabIndex = 10;
            label1.Text = "Arıza Takip Yönetici Ekranı";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBoxSonuclar);
            groupBox2.Location = new Point(564, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(431, 140);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "İstatistik";
            // 
            // listBoxSonuclar
            // 
            listBoxSonuclar.FormattingEnabled = true;
            listBoxSonuclar.ItemHeight = 20;
            listBoxSonuclar.Location = new Point(6, 30);
            listBoxSonuclar.Name = "listBoxSonuclar";
            listBoxSonuclar.Size = new Size(419, 104);
            listBoxSonuclar.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(467, 245);
            label3.Name = "label3";
            label3.Size = new Size(100, 26);
            label3.TabIndex = 12;
            label3.Text = "Veriler";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(label27);
            panel1.Controls.Add(label26);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1054, 63);
            panel1.TabIndex = 13;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label26.Location = new Point(1022, 3);
            label26.Name = "label26";
            label26.Size = new Size(29, 31);
            label26.TabIndex = 19;
            label26.Text = "X";
            label26.Click += label26_Click;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label27.Location = new Point(968, 3);
            label27.Name = "label27";
            label27.Size = new Size(48, 31);
            label27.TabIndex = 20;
            label27.Text = "<--";
            label27.Click += label27_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1054, 500);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Yönetici Ekranı";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Label label2;
        private Button buttonArama;
        private TextBox textBoxArama;
        private DataGridView dataGridView1;
        private RadioButton radioButtonSeriNo;
        private RadioButton radioButtonSehir;
        private RadioButton radioButtonAdSoyad;
        private RadioButton radioButtonModel;
        private RadioButton radioButtonTip;
        private RadioButton radioButtonMarka;
        private RadioButton radioButton1;
        private Label label1;
        private RadioButton radioButton2;
        private GroupBox groupBox2;
        private ListBox listBoxSonuclar;
        private Label label3;
        private Panel panel1;
        private Label label26;
        private Label label27;
    }
}