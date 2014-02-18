namespace Prijava
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.putanjaBox = new System.Windows.Forms.TextBox();
            this.Nadji = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Konacna = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.periodObracuna = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textPib = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textMatBr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textNaziv = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textAdresa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textTel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textMail = new System.Windows.Forms.TextBox();
            this.Generisi = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // putanjaBox
            // 
            this.putanjaBox.BackColor = System.Drawing.Color.IndianRed;
            this.putanjaBox.Location = new System.Drawing.Point(22, 45);
            this.putanjaBox.Name = "putanjaBox";
            this.putanjaBox.Size = new System.Drawing.Size(401, 20);
            this.putanjaBox.TabIndex = 0;
            this.putanjaBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nadji
            // 
            this.Nadji.Location = new System.Drawing.Point(447, 44);
            this.Nadji.Name = "Nadji";
            this.Nadji.Size = new System.Drawing.Size(75, 23);
            this.Nadji.TabIndex = 1;
            this.Nadji.Text = "Pronadji";
            this.Nadji.UseVisualStyleBackColor = true;
            this.Nadji.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Putanja do dokumenta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(334, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Konacna
            // 
            this.Konacna.AutoSize = true;
            this.Konacna.Location = new System.Drawing.Point(241, 178);
            this.Konacna.Name = "Konacna";
            this.Konacna.Size = new System.Drawing.Size(69, 17);
            this.Konacna.TabIndex = 5;
            this.Konacna.Text = "Konacna";
            this.Konacna.UseVisualStyleBackColor = true;
            this.Konacna.CheckedChanged += new System.EventHandler(this.Konacna_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Podaci o Prijavi";
            // 
            // periodObracuna
            // 
            this.periodObracuna.BackColor = System.Drawing.Color.IndianRed;
            this.periodObracuna.Location = new System.Drawing.Point(22, 172);
            this.periodObracuna.Name = "periodObracuna";
            this.periodObracuna.Size = new System.Drawing.Size(59, 20);
            this.periodObracuna.TabIndex = 8;
            this.periodObracuna.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Obracunski Period";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Datum Prijave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(194, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Podaci o Isplatiocu";
            // 
            // textPib
            // 
            this.textPib.BackColor = System.Drawing.Color.IndianRed;
            this.textPib.Location = new System.Drawing.Point(25, 272);
            this.textPib.Name = "textPib";
            this.textPib.Size = new System.Drawing.Size(131, 20);
            this.textPib.TabIndex = 12;
            this.textPib.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "PIB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Maticni Broj";
            // 
            // textMatBr
            // 
            this.textMatBr.BackColor = System.Drawing.Color.IndianRed;
            this.textMatBr.Location = new System.Drawing.Point(25, 325);
            this.textMatBr.Name = "textMatBr";
            this.textMatBr.Size = new System.Drawing.Size(131, 20);
            this.textMatBr.TabIndex = 14;
            this.textMatBr.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Naziv";
            // 
            // textNaziv
            // 
            this.textNaziv.BackColor = System.Drawing.Color.IndianRed;
            this.textNaziv.Location = new System.Drawing.Point(25, 374);
            this.textNaziv.Name = "textNaziv";
            this.textNaziv.Size = new System.Drawing.Size(131, 20);
            this.textNaziv.TabIndex = 16;
            this.textNaziv.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Opstina";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 461);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Adresa";
            // 
            // textAdresa
            // 
            this.textAdresa.BackColor = System.Drawing.Color.IndianRed;
            this.textAdresa.Location = new System.Drawing.Point(27, 477);
            this.textAdresa.Name = "textAdresa";
            this.textAdresa.Size = new System.Drawing.Size(131, 20);
            this.textAdresa.TabIndex = 20;
            this.textAdresa.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 510);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Telefon";
            // 
            // textTel
            // 
            this.textTel.BackColor = System.Drawing.Color.IndianRed;
            this.textTel.Location = new System.Drawing.Point(27, 526);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(131, 20);
            this.textTel.TabIndex = 22;
            this.textTel.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 563);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "eMail";
            // 
            // textMail
            // 
            this.textMail.BackColor = System.Drawing.Color.IndianRed;
            this.textMail.Location = new System.Drawing.Point(27, 579);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(131, 20);
            this.textMail.TabIndex = 24;
            this.textMail.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // Generisi
            // 
            this.Generisi.Location = new System.Drawing.Point(408, 563);
            this.Generisi.Name = "Generisi";
            this.Generisi.Size = new System.Drawing.Size(125, 36);
            this.Generisi.TabIndex = 26;
            this.Generisi.Text = "Generisi";
            this.Generisi.UseVisualStyleBackColor = true;
            this.Generisi.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 428);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 37);
            this.label3.TabIndex = 30;
            this.label3.Text = "ZAVRSENO";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 656);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Generisi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textMail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textAdresa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textNaziv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textMatBr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textPib);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.periodObracuna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Konacna);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nadji);
            this.Controls.Add(this.putanjaBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PPPPD Prijava";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox putanjaBox;
        private System.Windows.Forms.Button Nadji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox Konacna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox periodObracuna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPib;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textMatBr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textNaziv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textAdresa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.Button Generisi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}

