using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Xml.Serialization;
using FileHelpers;
using PPPPD;
using System.Xml.Linq;


namespace Prijava
{
    public partial class Form1 : Form
    {
        public static string putanja;
        
        public Form1()
        {
            InitializeComponent();
            Generisi.Enabled = false;
            DataSet ds = new DataSet();
            ds.ReadXml("C:\\Program Files\\PPPPD Prijava\\opstine.xml", XmlReadMode.InferSchema);
            comboBox1.DataSource = ds.Tables["OPSTINA"];
            comboBox1.DisplayMember = "naziv";
            comboBox1.ValueMember = @"id";
        
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
                putanjaBox.Text = putanja;
                putanjaBox.BackColor = Color.White;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        static public List<PodaciOPrihodimaTip> CitacAkontacija(Popuna[] info, List<PodaciOPrihodimaTip> spisak)
        {
            FileHelperEngine motorce = new FileHelperEngine(typeof(Popuna));
            try
            {
                info = motorce.ReadFile(putanja) as Popuna[];

            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.ToString());
            }
            LinkedList<Popuna> infolista = new LinkedList<Popuna>();
            foreach (Popuna pop in info)
            {
                infolista.AddLast(pop);
            }
            LinkedListNode<Popuna> tour = infolista.First;
            while (tour != null)
            {
                PodaciOPrihodimaTip sp = new PodaciOPrihodimaTip();
                sp.RedniBroj = tour.Value.RedniBroj;
                sp.VrstaIdentifikatoraPrimaoca = tour.Value.VrstaIdentifikatoraPrimaoca;
                sp.IdentifikatorPrimaoca = tour.Value.IdentifikatorPrimaoca;
                sp.Ime = tour.Value.Ime.Trim();
                sp.Prezime = tour.Value.Prezime.Trim();
                sp.OznakaPrebivalista = tour.Value.OznakaPrebivalista;
                sp.SVP = tour.Value.SVP;
                sp.Bruto = tour.Value.Bruto;
                sp.OsnovicaPorez = tour.Value.OsnovicaPorez;
                sp.Porez = tour.Value.Porez;
                sp.OsnovicaDoprinosi = tour.Value.OsnovicaDoprinosi;
                sp.PIO = tour.Value.PIO;
                sp.ZDR = tour.Value.ZDR;
                sp.NEZ = tour.Value.NEZ;
                sp.PIOBen = tour.Value.PIOBen;
                spisak.Add(sp);
                tour = tour.Next; 

            }
            return spisak;
 
        }
        static public List<PodaciOPrihodimaTip> CitacKonacna(Popuna[] info, List<PodaciOPrihodimaTip> spisak)
        {

            FileHelperEngine motorce = new FileHelperEngine(typeof(Popuna));
            try
            {
                info = motorce.ReadFile(putanja) as Popuna[];

            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.ToString());
            }
            LinkedList<Popuna> infolista = new LinkedList<Popuna>();
            foreach (Popuna pop in info)
            {
                infolista.AddLast(pop);
            }
            LinkedListNode<Popuna> tour = infolista.First;
            
            while (tour != null)
            {
                PodaciOPrihodimaTip sp = new PodaciOPrihodimaTip();
                MultifunkcionalnoPolje pom1 = new MultifunkcionalnoPolje();
                MultifunkcionalnoPolje pom2 = new MultifunkcionalnoPolje();
                MultifunkcionalnoPolje pom3 = new MultifunkcionalnoPolje();
                MultifunkcionalnoPolje pom4 = new MultifunkcionalnoPolje();
                MultifunkcionalnoPolje pom5 = new MultifunkcionalnoPolje();
                MultifunkcionalnoPolje pom6 = new MultifunkcionalnoPolje();
                MultifunkcionalnoPolje pom7 = new MultifunkcionalnoPolje();
                List<MultifunkcionalnoPolje> pomocni = new List<MultifunkcionalnoPolje>();
              
                sp.RedniBroj = tour.Value.RedniBroj;
                sp.VrstaIdentifikatoraPrimaoca = tour.Value.VrstaIdentifikatoraPrimaoca;
                sp.IdentifikatorPrimaoca = tour.Value.IdentifikatorPrimaoca;
                sp.Ime = tour.Value.Ime.Trim();
                sp.Prezime = tour.Value.Prezime.Trim();
                sp.OznakaPrebivalista = tour.Value.OznakaPrebivalista;
                sp.SVP = tour.Value.SVP;
                sp.BrojKalendarskihDana = tour.Value.BrojKalendarskihDana;
                sp.MesecniFondSati = tour.Value.MesecniFondSati;
                sp.MesecniFondSatiSpecified = true;
                sp.BrojEfektivnihSati = tour.Value.BrojEfektivnihSati;
                sp.BrojEfektivnihSatiSpecified = true;
                sp.Bruto = tour.Value.Bruto;

                if (tour.Value.SVP == 101110000)
                {
                    sp.OsnovicaPorez = sp.Bruto;
                    sp.Porez = sp.OsnovicaPorez / 10M;
                    sp.OsnovicaDoprinosi = 0M;

                    sp.PIO = sp.OsnovicaDoprinosi * 24M / 100;
                    sp.ZDR = sp.OsnovicaDoprinosi * 12.3M / 100;
                    sp.NEZ = sp.OsnovicaDoprinosi * 1.5M / 100;
                    sp.PIOBen = tour.Value.PIOBen;
                    pom1.Oznaka = MultifunkcionalnoPoljeOznaka.MFP2;
                    pom1.Vrednost = "0.00";
                    pomocni.Add(pom1);

                }
                else 
                {
                    sp.OsnovicaPorez = sp.Bruto - 11242M * sp.BrojEfektivnihSati / sp.MesecniFondSati;
                    sp.Porez = sp.OsnovicaPorez / 10M;
                    if (sp.Bruto <= 22282M)
                    {
                        if (tour.Value.SVP == 101204000 || tour.Value.SVP == 101206000)
                            sp.OsnovicaDoprinosi = sp.Bruto;
                        else if (tour.Value.SVP == 101101000)
                            sp.OsnovicaDoprinosi = sp.Bruto- 21210 * sp.BrojEfektivnihSati / sp.MesecniFondSati;
                        else
                            sp.OsnovicaDoprinosi = sp.Bruto - 21210 * sp.BrojEfektivnihSati / sp.MesecniFondSati;
                    }
                    else
                    {
                        if (tour.Value.SVP == 101204000 || tour.Value.SVP == 101206000)
                            sp.OsnovicaDoprinosi = sp.Bruto;
                        else
                            sp.OsnovicaDoprinosi = sp.Bruto - 21210 * sp.BrojEfektivnihSati / sp.MesecniFondSati;
                    }

                    sp.PIO = sp.OsnovicaDoprinosi * 24M / 100;
                    sp.ZDR = sp.OsnovicaDoprinosi * 12.3M / 100;
                    sp.NEZ = sp.OsnovicaDoprinosi * 1.5M / 100;
                    sp.PIOBen = tour.Value.PIOBen;
                    pom1.Oznaka = MultifunkcionalnoPoljeOznaka.MFP2;
                    pom1.Vrednost = Convert.ToString(21210 * sp.BrojEfektivnihSati / sp.MesecniFondSati);
                    pomocni.Add(pom1);
                    pom2.Oznaka = MultifunkcionalnoPoljeOznaka.MFP12;
                    pom2.Vrednost = "21210.00";
                    pomocni.Add(pom2);
                    if (tour.Value.MF10 != 0M)
                    {
                        pom5.Oznaka = MultifunkcionalnoPoljeOznaka.MFP10;
                        pom5.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF10));
                        pomocni.Add(pom5);
                    }
                }
             ////Muljaza zbog prijave za novembar
                //if (tour.Value.MF1 != 0M)
                //{
                //    pom1.Oznaka = MultifunkcionalnoPoljeOznaka.MFP1;
                //    pom1.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF1));
                //    pomocni.Add(pom1);
                //}
                //if (tour.Value.MF2 != 0M)
                //{
                //    pom2.Oznaka = MultifunkcionalnoPoljeOznaka.MFP2;
                //    pom2.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF2));
                //    pomocni.Add(pom2);
                //}
                //if (tour.Value.MF3 != 0M)
                //{
                //    pom3.Oznaka = MultifunkcionalnoPoljeOznaka.MFP3;
                //    pom3.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF3));
                //    pomocni.Add(pom3);
                //}
                //if (tour.Value.MF4 != 0M)
                //{
                //    pom4.Oznaka = MultifunkcionalnoPoljeOznaka.MFP4;
                //    pom4.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF4));
                //    pomocni.Add(pom4);
                //}
                //if (tour.Value.MF10 != 0M)
                //{
                //    pom5.Oznaka = MultifunkcionalnoPoljeOznaka.MFP10;
                //    pom5.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF10));
                //    pomocni.Add(pom5);
                //}
                //if (tour.Value.MF11 != 0M)
                //{
                //    pom6.Oznaka = MultifunkcionalnoPoljeOznaka.MFP11;
                //    pom6.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF11));
                //    pomocni.Add(pom6);
                //}
                //if (tour.Value.MF12 != 0M)
                //{
                //    pom7.Oznaka = MultifunkcionalnoPoljeOznaka.MFP12;
                //    pom7.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF12));
                //    pomocni.Add(pom7);
                //}
                
                sp.DeklarisaniMFP.MFP.AddRange(pomocni);
                sp.DeklarisaniMFPSpecified = true;
                spisak.Add(sp);
                tour = tour.Next;   
                
                
            }
            return spisak;
         }
          

        
        private void button2_Click(object sender, EventArgs e)
        {
            string saveputanja=" ";
            saveFileDialog1.Filter = "XML Files (.xml)|*.xml";
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.FilterIndex = 1;
            DialogResult rezultat = saveFileDialog1.ShowDialog();
            if (rezultat == DialogResult.OK)
            {

                saveputanja = saveFileDialog1.FileName;

            }
            
            PodaciPoreskeDeklaracijeTip prijava = new PodaciPoreskeDeklaracijeTip();
            int br = Brojac();
            int br1 = BrojacRadnika();
            prijava.PodaciOPrijavi.VrstaPrijave = 1;
            prijava.PodaciOPrijavi.ObracunskiPeriod = periodObracuna.Text;
            if (Konacna.Checked)
            {
                prijava.PodaciOPrijavi.OznakaZaKonacnu = new PodaciOPrijaviTipOznakaZaKonacnu();
                prijava.PodaciOPrijavi.OznakaZaKonacnuSpecified = true;
                prijava.PodaciOPrijavi.DatumPlacanja = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                prijava.PodaciOPrijavi.DatumPlacanjaSpecified = true;
                prijava.PodaciOIsplatiocu.TipIsplatioca = 1;
                prijava.PodaciOIsplatiocu.PoreskiIdentifikacioniBroj = textPib.Text;
                prijava.PodaciOIsplatiocu.BrojZaposlenih = Convert.ToString(br1);
                prijava.PodaciOIsplatiocu.SedistePrebivaliste = comboBox1.SelectedValue.ToString();
                prijava.PodaciOIsplatiocu.MaticniBrojisplatioca = textMatBr.Text;
                prijava.PodaciOIsplatiocu.NazivPrezimeIme = textNaziv.Text;
                prijava.PodaciOIsplatiocu.Telefon = textTel.Text;
                prijava.PodaciOIsplatiocu.eMail = textMail.Text;
                prijava.PodaciOIsplatiocu.UlicaIBroj = textAdresa.Text;
                Popuna[] pomocni = new Popuna[br + 1];
                var spisak = new List<PodaciOPrihodimaTip>(br + 1);
                CitacKonacna(pomocni, spisak);
                prijava.DeklarisaniPrihodi.PodaciOPrihodima = spisak;
                Serialize(prijava, saveputanja);
                label3.Visible = true;
            }
            else
            {
                prijava.PodaciOPrijavi.DatumPlacanja = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                prijava.PodaciOPrijavi.DatumPlacanjaSpecified = true;
                prijava.PodaciOIsplatiocu.TipIsplatioca = 1;
                prijava.PodaciOIsplatiocu.PoreskiIdentifikacioniBroj = textPib.Text;
                prijava.PodaciOIsplatiocu.BrojZaposlenih = Convert.ToString(br1);
                prijava.PodaciOIsplatiocu.SedistePrebivaliste = comboBox1.SelectedValue.ToString();
                prijava.PodaciOIsplatiocu.MaticniBrojisplatioca = textMatBr.Text;
                prijava.PodaciOIsplatiocu.NazivPrezimeIme = textNaziv.Text;
                prijava.PodaciOIsplatiocu.Telefon = textTel.Text;
                prijava.PodaciOIsplatiocu.eMail = textMail.Text;
                prijava.PodaciOIsplatiocu.UlicaIBroj = textAdresa.Text;
                Popuna[] pomocni = new Popuna[br + 1];
                var spisak = new List<PodaciOPrihodimaTip>(br + 1);
                CitacAkontacija(pomocni, spisak);
                prijava.DeklarisaniPrihodi.PodaciOPrihodima = spisak;
                Serialize(prijava, saveputanja);
                label3.Visible = true;
 
            }




        }
        static public void Serialize(PodaciPoreskeDeklaracijeTip prijava,string putanja)
        {
            
            XmlSerializer swosh = new XmlSerializer(typeof(PodaciPoreskeDeklaracijeTip));
            TextWriter pisac = new StreamWriter(putanja);
            swosh.Serialize(pisac, prijava);
            pisac.Close();
        }
        static public int Brojac()
        {
            FileHelperEngine motorce = new FileHelperEngine(typeof(Popuna));
            try
            {
                Popuna[] sp = motorce.ReadFile(putanja) as Popuna[];
                return sp.Length;
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.ToString());
                return 0;
            }

        }
        static public int BrojacRadnika()
        {
            FileHelperEngine motorce = new FileHelperEngine(typeof(Popuna));

            try
            {
                Popuna[] sp = motorce.ReadFile(putanja) as Popuna[];
                int broj = 1;
                int i = 0;
                int j = 1;
                string sp1, sp2;
                while (i < sp.Length)
                {
                    sp1 = sp[i].IdentifikatorPrimaoca;
                    sp2 = sp[j].IdentifikatorPrimaoca;
                    if (sp1 != sp2)
                        broj++;
                    i++;
                    if (j < sp.Length - 1)
                        j++;
                }
                return broj;
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.ToString());
                return 0;
            }
           
        }

        private void UpdateUserInterface()
        {
            this.Generisi.Enabled = !string.IsNullOrWhiteSpace(this.putanjaBox.Text) &&
                                    !string.IsNullOrWhiteSpace(this.periodObracuna.Text) &&
                                    !string.IsNullOrWhiteSpace(this.textNaziv.Text) &&
                                    !string.IsNullOrWhiteSpace(this.textPib.Text) &&
                                    !string.IsNullOrWhiteSpace(this.textMatBr.Text) &&
                                    
                                    !string.IsNullOrWhiteSpace(this.textAdresa.Text) &&
                                    !string.IsNullOrWhiteSpace(this.textTel.Text) &&
                                    !string.IsNullOrWhiteSpace(this.textMail.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            UpdateUserInterface();
            periodObracuna.BackColor = Color.White;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            UpdateUserInterface();
            textPib.BackColor = Color.White;
        }

        

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            UpdateUserInterface();
            textMatBr.BackColor = Color.White;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            UpdateUserInterface();
            textAdresa.BackColor = Color.White;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            UpdateUserInterface();
            textMail.BackColor = Color.White;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            UpdateUserInterface();
            textNaziv.BackColor = Color.White;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            UpdateUserInterface();
            textTel.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateUserInterface();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //var tekst = "Fajl: " + putanja + "\n" + "Period: " + textBox3.Text;
            //textBox2.Text = tekst;
        }

        private void Konacna_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        
    }
        
}       
