using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using FileHelpers;


namespace Prijava
{
    public partial class Form1 : Form
    {
        public static string putanja;
        
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (.txt)|*.txt";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.FilterIndex = 1;
           
            DialogResult rezultat = openFileDialog1.ShowDialog();
            if (rezultat == DialogResult.OK)
            {
                
                putanja = openFileDialog1.FileName;
                textBox1.Text = putanja;
                textBox1.BackColor = Color.White;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tekst = "Fajl: " + putanja + "\n" + "Period: " + textBox3.Text;
            textBox2.Text = tekst;
        }
        private void UpdateUserInterface()
        {
            this.button2.Enabled = !string.IsNullOrWhiteSpace(this.textBox1.Text) &&
                                    !string.IsNullOrWhiteSpace(this.textBox3.Text) &&
                                    !string.IsNullOrWhiteSpace(this.textBox6.Text) &&
                                    !string.IsNullOrWhiteSpace(this.textBox4.Text) &&
                                    !string.IsNullOrWhiteSpace(this.textBox5.Text) &&
                                    !string.IsNullOrWhiteSpace(this.textBox7.Text) &&
                                    !string.IsNullOrWhiteSpace(this.textBox8.Text) &&
                                    !string.IsNullOrWhiteSpace(this.textBox9.Text) &&
                                    !string.IsNullOrWhiteSpace(this.textBox10.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            UpdateUserInterface();
            textBox3.BackColor = Color.White;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            UpdateUserInterface();
            textBox4.BackColor = Color.White;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            UpdateUserInterface();
            textBox7.BackColor = Color.White;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            UpdateUserInterface();
            textBox5.BackColor = Color.White;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            UpdateUserInterface();
            textBox8.BackColor = Color.White;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            UpdateUserInterface();
            textBox10.BackColor = Color.White;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            UpdateUserInterface();
            textBox6.BackColor = Color.White;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            UpdateUserInterface();
            textBox9.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateUserInterface();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var tekst = "Fajl: " + putanja + "\n" + "Period: " + textBox3.Text;
            textBox2.Text = tekst;
        }
        
    }
        
}       
