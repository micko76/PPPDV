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
            ds.ReadXml("C:\\Documents and Settings\\Micko\\Desktop\\opstine.xml", XmlReadMode.InferSchema);
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
        static public List<PodaciOPrihodimaTip> Citac(Popuna[] info, List<PodaciOPrihodimaTip> spisak)
        {

            FileHelperEngine motorce = new FileHelperEngine(typeof(Popuna));
            try
            {
                info = motorce.ReadFile(putanja) as Popuna[];

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            LinkedList<Popuna> infolista = new LinkedList<Popuna>();
            foreach (Popuna pop in info)
            {
                infolista.AddLast(pop);
            }
            LinkedListNode<Popuna> tour = infolista.First;

            //int i = 0;
            //try
            //{
            while (tour != null)
            {
                PodaciOPrihodimaTip sp = new PodaciOPrihodimaTip();
                MultifunkcionalnoPolje pom = new MultifunkcionalnoPolje();
                MultifunkcionalnoPolje pom1 = new MultifunkcionalnoPolje();
                MultifunkcionalnoPolje pom2 = new MultifunkcionalnoPolje();
                MultifunkcionalnoPolje pom3 = new MultifunkcionalnoPolje();
                MultifunkcionalnoPolje pom4 = new MultifunkcionalnoPolje();
                MultifunkcionalnoPolje pom5 = new MultifunkcionalnoPolje();
                LinkedListNode<Popuna> tour1 = tour.Next;
                List<MultifunkcionalnoPolje> pomocni = new List<MultifunkcionalnoPolje>();
                switch (tour.Value.SVP)
                {

                    case 101101000:
                        {

                            if (tour1 != null && tour.Value.IdentifikatorPrimaoca == tour1.Value.IdentifikatorPrimaoca)
                            {
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
                                sp.OsnovicaPorez = tour.Value.OsnovicaPorez;
                                sp.Porez = tour.Value.Porez;
                                sp.OsnovicaDoprinosi = tour.Value.OsnovicaDoprinosi;
                                sp.PIO = tour.Value.PIO;
                                sp.ZDR = tour.Value.ZDR;
                                sp.NEZ = tour.Value.NEZ;
                                sp.PIOBen = tour.Value.PIOBen;
                                pom.Oznaka = MultifunkcionalnoPoljeOznaka.MFP1;
                                pom.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF1));
                                pomocni.Add(pom);
                                pom1.Oznaka = MultifunkcionalnoPoljeOznaka.MFP2;
                                pom1.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF2));
                                pomocni.Add(pom1);
                                pom2.Oznaka = MultifunkcionalnoPoljeOznaka.MFP4;
                                pom2.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF4));
                                pomocni.Add(pom2);
                                pom5.Oznaka = MultifunkcionalnoPoljeOznaka.MFP10;
                                pom5.Vrednost = "1";
                                pomocni.Add(pom5);
                                //pom3.Oznaka = MultifunkcionalnoPoljeOznaka.MFP11;
                                //pom3.Vrednost = Convert.ToString(tour.Value.MF11);
                                //pomocni.Add(pom3);
                                pom4.Oznaka = MultifunkcionalnoPoljeOznaka.MFP12;
                                pom4.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF12));
                                pomocni.Add(pom4);
                                sp.DeklarisaniMFP.MFP.AddRange(pomocni);
                                sp.DeklarisaniMFPSpecified = true;
                                spisak.Add(sp);
                                tour = tour1;

                            }
                            else
                            {
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
                                sp.OsnovicaPorez = tour.Value.OsnovicaPorez;
                                sp.Porez = tour.Value.Porez;
                                sp.OsnovicaDoprinosi = tour.Value.OsnovicaDoprinosi;
                                sp.PIO = tour.Value.PIO;
                                sp.ZDR = tour.Value.ZDR;
                                sp.NEZ = tour.Value.NEZ;
                                sp.PIOBen = tour.Value.PIOBen;
                                pom.Oznaka = MultifunkcionalnoPoljeOznaka.MFP1;
                                pom.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF1));
                                pomocni.Add(pom);
                                pom1.Oznaka = MultifunkcionalnoPoljeOznaka.MFP2;
                                pom1.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF2));
                                pomocni.Add(pom1);
                                pom2.Oznaka = MultifunkcionalnoPoljeOznaka.MFP4;
                                pom2.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF4));
                                pomocni.Add(pom2);
                                //pom5.Oznaka = MultifunkcionalnoPoljeOznaka.MFP10;
                                //pom5.Vrednost = "1";
                                //pomocni.Add(pom5);
                                //pom3.Oznaka = MultifunkcionalnoPoljeOznaka.MFP11;
                                //pom3.Vrednost = Convert.ToString(tour.Value.MF11);
                                //pomocni.Add(pom3);
                                pom4.Oznaka = MultifunkcionalnoPoljeOznaka.MFP12;
                                pom4.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF12));
                                pomocni.Add(pom4);
                                sp.DeklarisaniMFP.MFP.AddRange(pomocni);
                                sp.DeklarisaniMFPSpecified = true;
                                spisak.Add(sp);
                                tour = tour.Next;
                            }

                        }

                        #region MyRegion


                        /* else
                             {
                                 if (tour.Value.IdentifikatorPrimaoca == tour.Next.Value.IdentifikatorPrimaoca)
                                 {
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
                                     sp.OsnovicaPorez = tour.Value.OsnovicaPorez;
                                     sp.Porez = tour.Value.Porez;
                                     sp.OsnovicaDoprinosi = tour.Value.OsnovicaDoprinosi;
                                     sp.PIO = tour.Value.PIO;
                                     sp.ZDR = tour.Value.ZDR;
                                     sp.NEZ = tour.Value.NEZ;
                                     sp.PIOBen = tour.Value.PIOBen;
                                     pom.Oznaka = MultifunkcionalnoPoljeOznaka.MFP10;
                                     pom.Vrednost = "1";
                                     sp.DeklarisaniMFP.MFP.Add(pom);
                                     sp.DeklarisaniMFPSpecified = true;
                                     spisak.Add(sp);
                                     tour = tour.Next;
                                 }
                                 else 
                                 {
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
                                
                            }*/
                        #endregion
                        break;
                    case 101201000:
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
                        sp.OsnovicaPorez = tour.Value.OsnovicaPorez;
                        sp.Porez = tour.Value.Porez;
                        sp.OsnovicaDoprinosi = tour.Value.OsnovicaDoprinosi;
                        sp.PIO = tour.Value.PIO;
                        sp.ZDR = tour.Value.ZDR;
                        sp.NEZ = tour.Value.NEZ;
                        sp.PIOBen = tour.Value.PIOBen;
                        pom.Oznaka = MultifunkcionalnoPoljeOznaka.MFP1;
                        pom.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF1));
                        pomocni.Add(pom);
                        pom1.Oznaka = MultifunkcionalnoPoljeOznaka.MFP2;
                        pom1.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF2));
                        pomocni.Add(pom1);
                        pom2.Oznaka = MultifunkcionalnoPoljeOznaka.MFP4;
                        pom2.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF4));
                        pomocni.Add(pom2);
                        pom5.Oznaka = MultifunkcionalnoPoljeOznaka.MFP10;
                        pom5.Vrednost = "1";
                        pomocni.Add(pom5);
                        //pom3.Oznaka = MultifunkcionalnoPoljeOznaka.MFP11;
                        //pom3.Vrednost = Convert.ToString(tour.Value.MF11);
                        //pomocni.Add(pom3);
                        pom4.Oznaka = MultifunkcionalnoPoljeOznaka.MFP12;
                        pom4.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF12));
                        pomocni.Add(pom4);
                        sp.DeklarisaniMFP.MFP.AddRange(pomocni);
                        sp.DeklarisaniMFPSpecified = true;
                        spisak.Add(sp);
                        tour = tour.Next;
                        break;
                    case 101204000:
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
                        sp.OsnovicaPorez = tour.Value.OsnovicaPorez;
                        sp.Porez = tour.Value.Porez;
                        sp.OsnovicaDoprinosi = tour.Value.OsnovicaDoprinosi;
                        sp.PIO = tour.Value.PIO;
                        sp.ZDR = tour.Value.ZDR;
                        sp.NEZ = tour.Value.NEZ;
                        sp.PIOBen = tour.Value.PIOBen;
                        pom.Oznaka = MultifunkcionalnoPoljeOznaka.MFP1;
                        pom.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF1));
                        pomocni.Add(pom);
                        pom1.Oznaka = MultifunkcionalnoPoljeOznaka.MFP2;
                        pom1.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF2));
                        pomocni.Add(pom1);
                        pom2.Oznaka = MultifunkcionalnoPoljeOznaka.MFP4;
                        pom2.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF4));
                        pomocni.Add(pom2);
                        pom5.Oznaka = MultifunkcionalnoPoljeOznaka.MFP10;
                        pom5.Vrednost = "1";
                        pomocni.Add(pom5);
                        //pom3.Oznaka = MultifunkcionalnoPoljeOznaka.MFP11;
                        //pom3.Vrednost = Convert.ToString(tour.Value.MF11);
                        //pomocni.Add(pom3);
                        pom4.Oznaka = MultifunkcionalnoPoljeOznaka.MFP12;
                        pom4.Vrednost = Convert.ToString(Convert.ToInt32(tour.Value.MF12));
                        pomocni.Add(pom4);
                        sp.DeklarisaniMFP.MFP.AddRange(pomocni);
                        sp.DeklarisaniMFPSpecified = true;
                        spisak.Add(sp);
                        tour = tour.Next;
                        break;
                    default:
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
                        sp.OsnovicaPorez = tour.Value.OsnovicaPorez;
                        sp.Porez = tour.Value.Porez;
                        sp.OsnovicaDoprinosi = tour.Value.OsnovicaDoprinosi;
                        sp.PIO = tour.Value.PIO;
                        sp.ZDR = tour.Value.ZDR;
                        sp.NEZ = tour.Value.NEZ;
                        sp.PIOBen = tour.Value.PIOBen;
                        spisak.Add(sp);
                        tour = tour.Next;
                        break;
                }

            }
            //}/
            //catch (NullReferenceException e)
            //{
            //   // Console.WriteLine(e.Message);

            //}
            return spisak;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            PodaciPoreskeDeklaracijeTip prijava = new PodaciPoreskeDeklaracijeTip();
            int br = Brojac();
            int br1 = BrojacRadnika();
            prijava.PodaciOPrijavi.ObracunskiPeriod = periodObracuna.Text;
            if (Konacna.Checked)
            {
                prijava.PodaciOPrijavi.OznakaZaKonacnu = new PodaciOPrijaviTipOznakaZaKonacnu();
                prijava.PodaciOPrijavi.OznakaZaKonacnuSpecified = true;
            }
            prijava.PodaciOPrijavi.DatumPlacanja = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            prijava.PodaciOPrijavi.DatumPlacanjaSpecified = true;
            prijava.PodaciOIsplatiocu.TipIsplatioca = 1;
            prijava.PodaciOIsplatiocu.PoreskiIdentifikacioniBroj = textPib.Text;
            prijava.PodaciOIsplatiocu.BrojZaposlenih = Convert.ToString(br1);
            prijava.PodaciOIsplatiocu.SedistePrebivaliste = comboBox1.SelectedValue.ToString();
            //fali nesto redova.....

            Popuna[] pomocni = new Popuna[br + 1];
            var spisak = new List<PodaciOPrihodimaTip>(br + 1);
            Citac(pomocni, spisak);
            prijava.DeklarisaniPrihodi.PodaciOPrihodima = spisak;
            Serialize(prijava);





        }
        static public void Serialize(PodaciPoreskeDeklaracijeTip prijava)
        {
            XmlSerializer swosh = new XmlSerializer(typeof(PodaciPoreskeDeklaracijeTip));
            TextWriter pisac = new StreamWriter(@"D:\Simpen\konacna.xml");
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
