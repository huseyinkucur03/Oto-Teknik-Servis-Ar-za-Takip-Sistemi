namespace arizatespit
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            ArizaBildir_button = new Button();
            textBoxTelNo = new TextBox();
            label2 = new Label();
            textBoxAdSoyad = new TextBox();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            textBoxSehir = new TextBox();
            label12 = new Label();
            label5 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            comboBoxMarkaSec = new ComboBox();
            comboBoxTip = new ComboBox();
            comboBoxKasko = new ComboBox();
            label6 = new Label();
            label9 = new Label();
            label7 = new Label();
            label8 = new Label();
            label25 = new Label();
            textBoxRenk = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBoxModel = new TextBox();
            textBoxPlaka = new TextBox();
            textBoxSeriNo = new TextBox();
            label13 = new Label();
            groupBox3 = new GroupBox();
            buttonHesapla = new Button();
            label24 = new Label();
            label22 = new Label();
            label23 = new Label();
            label11 = new Label();
            label19 = new Label();
            label18 = new Label();
            label21 = new Label();
            label17 = new Label();
            label20 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            comboBoxArizaSec = new ComboBox();
            groupBox4 = new GroupBox();
            label10 = new Label();
            label26 = new Label();
            label27 = new Label();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ArizaBildir_button
            // 
            ArizaBildir_button.BackColor = Color.FromArgb(255, 128, 0);
            ArizaBildir_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ArizaBildir_button.Image = (Image)resources.GetObject("ArizaBildir_button.Image");
            ArizaBildir_button.ImageAlign = ContentAlignment.MiddleRight;
            ArizaBildir_button.Location = new Point(878, 383);
            ArizaBildir_button.Name = "ArizaBildir_button";
            ArizaBildir_button.Size = new Size(178, 64);
            ArizaBildir_button.TabIndex = 14;
            ArizaBildir_button.Text = "Arıza Bildir";
            ArizaBildir_button.TextAlign = ContentAlignment.MiddleLeft;
            ArizaBildir_button.UseVisualStyleBackColor = false;
            ArizaBildir_button.Click += ArizaBildir_button_Click;
            // 
            // textBoxTelNo
            // 
            textBoxTelNo.Location = new Point(165, 112);
            textBoxTelNo.MaxLength = 11;
            textBoxTelNo.Name = "textBoxTelNo";
            textBoxTelNo.Size = new Size(201, 27);
            textBoxTelNo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 192, 192);
            label2.Location = new Point(3, 115);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 0;
            label2.Text = "Telefon Numarası:";
            // 
            // textBoxAdSoyad
            // 
            textBoxAdSoyad.Location = new Point(165, 57);
            textBoxAdSoyad.Name = "textBoxAdSoyad";
            textBoxAdSoyad.Size = new Size(201, 27);
            textBoxAdSoyad.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 192);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBoxSehir);
            groupBox1.Controls.Add(textBoxTelNo);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxAdSoyad);
            groupBox1.Location = new Point(24, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 278);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(165, 222);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(201, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // textBoxSehir
            // 
            textBoxSehir.Location = new Point(165, 167);
            textBoxSehir.Name = "textBoxSehir";
            textBoxSehir.Size = new Size(201, 27);
            textBoxSehir.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(0, 192, 192);
            label12.Location = new Point(92, 225);
            label12.Name = "label12";
            label12.Size = new Size(48, 20);
            label12.TabIndex = 0;
            label12.Text = "Tarih:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 192, 192);
            label5.Location = new Point(91, 170);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 0;
            label5.Text = "Şehir:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(53, 60);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Adı Soyadı:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 192, 192);
            groupBox2.Controls.Add(comboBoxMarkaSec);
            groupBox2.Controls.Add(comboBoxTip);
            groupBox2.Controls.Add(comboBoxKasko);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label25);
            groupBox2.Controls.Add(textBoxRenk);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxModel);
            groupBox2.Controls.Add(textBoxPlaka);
            groupBox2.Controls.Add(textBoxSeriNo);
            groupBox2.Location = new Point(417, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 278);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Araç Bilgileri";
            // 
            // comboBoxMarkaSec
            // 
            comboBoxMarkaSec.FormattingEnabled = true;
            comboBoxMarkaSec.Items.AddRange(new object[] { "Audi", "Bmw", "Chevrolet", "Citroen", "Ferrari", "Fiat", "Ford", "Honda", "Lamborghini", "Maserati", "Mercedes", "Mini", "Mitsubishi", "Nissan", "Opel", "Peugeot", "Porcshe", "Renault", "Seat", "Skoda", "Toyota", "Togg", "Volkswagen" });
            comboBoxMarkaSec.Location = new Point(148, 104);
            comboBoxMarkaSec.Name = "comboBoxMarkaSec";
            comboBoxMarkaSec.Size = new Size(151, 28);
            comboBoxMarkaSec.TabIndex = 7;
            // 
            // comboBoxTip
            // 
            comboBoxTip.FormattingEnabled = true;
            comboBoxTip.Items.AddRange(new object[] { "Arazi", "Kamyon", "Minivan", "Otomobil", "Panelvan", "Pickup", "Suv", "Tır" });
            comboBoxTip.Location = new Point(148, 137);
            comboBoxTip.Name = "comboBoxTip";
            comboBoxTip.Size = new Size(151, 28);
            comboBoxTip.TabIndex = 8;
            // 
            // comboBoxKasko
            // 
            comboBoxKasko.FormattingEnabled = true;
            comboBoxKasko.Items.AddRange(new object[] { "Var", "Yok" });
            comboBoxKasko.Location = new Point(148, 234);
            comboBoxKasko.Name = "comboBoxKasko";
            comboBoxKasko.Size = new Size(151, 28);
            comboBoxKasko.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(192, 0, 0);
            label6.Location = new Point(70, 206);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 0;
            label6.Text = "Rengi:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(192, 0, 0);
            label9.Location = new Point(1, 239);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 0;
            label9.Text = "Kaskosu var mı?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(192, 0, 0);
            label7.Location = new Point(66, 173);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 0;
            label7.Text = "Modeli";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(192, 0, 0);
            label8.Location = new Point(84, 140);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 0;
            label8.Text = "Tipi:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.FromArgb(192, 0, 0);
            label25.Location = new Point(73, 76);
            label25.Name = "label25";
            label25.Size = new Size(50, 20);
            label25.TabIndex = 0;
            label25.Text = "Plaka:";
            // 
            // textBoxRenk
            // 
            textBoxRenk.Location = new Point(148, 202);
            textBoxRenk.Name = "textBoxRenk";
            textBoxRenk.Size = new Size(151, 27);
            textBoxRenk.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(55, 107);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 0;
            label4.Text = "Markası:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(59, 43);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 0;
            label3.Text = "Seri No:";
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(148, 170);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(151, 27);
            textBoxModel.TabIndex = 9;
            // 
            // textBoxPlaka
            // 
            textBoxPlaka.Location = new Point(148, 72);
            textBoxPlaka.MaxLength = 10;
            textBoxPlaka.Name = "textBoxPlaka";
            textBoxPlaka.Size = new Size(151, 27);
            textBoxPlaka.TabIndex = 6;
            // 
            // textBoxSeriNo
            // 
            textBoxSeriNo.Location = new Point(148, 40);
            textBoxSeriNo.MaxLength = 6;
            textBoxSeriNo.Name = "textBoxSeriNo";
            textBoxSeriNo.Size = new Size(151, 27);
            textBoxSeriNo.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Britannic Bold", 18F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(0, 0, 192);
            label13.Location = new Point(382, 8);
            label13.Name = "label13";
            label13.Size = new Size(396, 33);
            label13.TabIndex = 13;
            label13.Text = "Araç ve Kullanıcı Bilgi Paneli";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(255, 192, 192);
            groupBox3.Controls.Add(buttonHesapla);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Location = new Point(805, 70);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(337, 275);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Fiyatlandırma";
            // 
            // buttonHesapla
            // 
            buttonHesapla.BackColor = Color.FromArgb(255, 255, 192);
            buttonHesapla.Location = new Point(90, 211);
            buttonHesapla.Name = "buttonHesapla";
            buttonHesapla.Size = new Size(147, 47);
            buttonHesapla.TabIndex = 13;
            buttonHesapla.Text = "Hesapla";
            buttonHesapla.UseVisualStyleBackColor = false;
            buttonHesapla.Click += buttonHesapla_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label24.Location = new Point(194, 156);
            label24.Name = "label24";
            label24.Size = new Size(27, 20);
            label24.TabIndex = 2;
            label24.Text = "00";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(194, 130);
            label22.Name = "label22";
            label22.Size = new Size(27, 20);
            label22.TabIndex = 2;
            label22.Text = "00";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(90, 156);
            label23.Name = "label23";
            label23.Size = new Size(95, 20);
            label23.TabIndex = 1;
            label23.Text = "Model Farkı:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(112, 130);
            label11.Name = "label11";
            label11.Size = new Size(73, 20);
            label11.TabIndex = 1;
            label11.Text = "Tip Farkı:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(194, 101);
            label19.Name = "label19";
            label19.Size = new Size(27, 20);
            label19.TabIndex = 2;
            label19.Text = "00";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(89, 101);
            label18.Name = "label18";
            label18.Size = new Size(96, 20);
            label18.TabIndex = 1;
            label18.Text = "Arıza Bedeli:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(194, 40);
            label21.Name = "label21";
            label21.Size = new Size(27, 20);
            label21.TabIndex = 2;
            label21.Text = "00";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(194, 71);
            label17.Name = "label17";
            label17.Size = new Size(27, 20);
            label17.TabIndex = 2;
            label17.Text = "00";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(12, 40);
            label20.Name = "label20";
            label20.Size = new Size(173, 20);
            label20.TabIndex = 1;
            label20.Text = "İşçilik ve Hizmet Bedeli:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(90, 71);
            label16.Name = "label16";
            label16.Size = new Size(95, 20);
            label16.TabIndex = 1;
            label16.Text = "Marka Farkı:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(194, 185);
            label15.Name = "label15";
            label15.Size = new Size(27, 20);
            label15.TabIndex = 2;
            label15.Text = "00";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(13, 185);
            label14.Name = "label14";
            label14.Size = new Size(172, 20);
            label14.TabIndex = 1;
            label14.Text = "Toplam Ortalama Fiyat:";
            // 
            // comboBoxArizaSec
            // 
            comboBoxArizaSec.FormattingEnabled = true;
            comboBoxArizaSec.Items.AddRange(new object[] { "Motor arızası", "Elektrik arızası", "Akü bitmesi", "Lastik patlaması", "Fren arızası", "Yağ azalması", "Marş arızası", "Yakıt pompası arızası", "Şanzıman arızası", "Boyama işlemi", "Aks sorunu", "Amortisör arızası", "Vites dişli bozulması", "Radyatör sorunu", "Hararet yapması", "Direksiyon sertleşmesi", "Yakıt deposu arızası" });
            comboBoxArizaSec.Location = new Point(237, 68);
            comboBoxArizaSec.Name = "comboBoxArizaSec";
            comboBoxArizaSec.Size = new Size(476, 28);
            comboBoxArizaSec.TabIndex = 12;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(255, 192, 192);
            groupBox4.Controls.Add(comboBoxArizaSec);
            groupBox4.Controls.Add(label10);
            groupBox4.Location = new Point(24, 351);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(755, 135);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(55, 71);
            label10.Name = "label10";
            label10.Size = new Size(176, 20);
            label10.TabIndex = 0;
            label10.Text = "Arızanızın Türünü Seçin:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label26.Location = new Point(1136, 0);
            label26.Name = "label26";
            label26.Size = new Size(29, 31);
            label26.TabIndex = 18;
            label26.Text = "X";
            label26.Click += label26_Click;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label27.Location = new Point(1090, 0);
            label27.Name = "label27";
            label27.Size = new Size(48, 31);
            label27.TabIndex = 19;
            label27.Text = "<--";
            label27.Click += label27_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label27);
            panel1.Controls.Add(label26);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1165, 52);
            panel1.TabIndex = 20;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1167, 497);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(groupBox4);
            Controls.Add(ArizaBildir_button);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Kullanıcı Ekranı";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ArizaBildir_button;
        private TextBox textBoxAdSoyad;
        private TextBox textBoxTelNo;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private TextBox textBoxSehir;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label8;
        private TextBox textBoxRenk;
        private TextBox textBoxModel;
        private TextBox textBoxSeriNo;
        private Label label9;
        private ComboBox comboBoxKasko;
        private DateTimePicker dateTimePicker1;
        private Label label12;
        private Label label13;
        private Label label1;
        private GroupBox groupBox3;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label20;
        private Label label21;
        private ComboBox comboBoxTip;
        private ComboBox comboBoxArizaSec;
        private GroupBox groupBox4;
        private Label label10;
        private Button buttonHesapla;
        private ComboBox comboBoxMarkaSec;
        private Label label22;
        private Label label11;
        private Label label24;
        private Label label23;
        private Label label25;
        private TextBox textBoxPlaka;
        private Label label26;
        private Label label27;
        private Panel panel1;
    }
}