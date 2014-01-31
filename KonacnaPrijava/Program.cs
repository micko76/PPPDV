using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using ConsoleApplication1;
using FileHelpers;
using PPPPDPrijava;

namespace ConsoleApplication1
{
    class Program
    {


        static public void Serialize(PodaciPoreskeDeklaracijeTip prijava)
        {
            XmlSerializer swosh = new XmlSerializer(typeof(PodaciPoreskeDeklaracijeTip));
            TextWriter pisac = new StreamWriter(@"D:\Simpen\konacna.xml");
            TextReader citac = new StreamReader(@"D:\Simpen\konacna.xml");
            swosh.Serialize(pisac, prijava);
            pisac.Close();
        }
        static public List<PodaciOPrihodimaTip> Citac(Popuna[] info, List<PodaciOPrihodimaTip> spisak)
        {

            FileHelperEngine motorce = new FileHelperEngine(typeof(Popuna));
            try
            {
                info = motorce.ReadFile(@"D:\Simpen\konacna.txt") as Popuna[];

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
        static public int Brojac()
        {
            FileHelperEngine motorce = new FileHelperEngine(typeof(Popuna));
            try
            {
                Popuna[] sp = motorce.ReadFile(@"D:\Simpen\konacna.txt") as Popuna[];
                return sp.Length;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

        }
        static public int BrojacRadnika()
        {
            FileHelperEngine motorce = new FileHelperEngine(typeof(Popuna));

            try
            {
                Popuna[] sp = motorce.ReadFile(@"D:\Simpen\konacna.txt") as Popuna[];
                LinkedList<Popuna> infolista = new LinkedList<Popuna>();
                foreach (Popuna pop in sp)
                {
                    infolista.AddLast(pop);
                }
                LinkedListNode<Popuna> tour = infolista.First;
                LinkedListNode<Popuna> pomocni = tour.Next;
                int broj = 0;
                while (tour.Next != null)
                {

                    while (pomocni != null)
                    {
                        if (tour.Value.IdentifikatorPrimaoca != pomocni.Value.IdentifikatorPrimaoca)
                        {
                            broj++;
                            pomocni = pomocni.Next;
                        }
                        else
                            pomocni = pomocni.Next;
                    }
                    tour = tour.Next;
                }
                #region Stari Brojac
                /*  int broj = 1;
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
                  }*/
                #endregion

                return broj + 1;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

        }
        static void Main(string[] args)
        {


            PodaciPoreskeDeklaracijeTip prijava = new PodaciPoreskeDeklaracijeTip();
            int br = Brojac();
            int br1 = BrojacRadnika();
            //podaci o prijavi, ovo ide uvek isto//
            prijava.PodaciOPrijavi.KlijentskaOznakaDeklaracije = "21212121";
            prijava.PodaciOPrijavi.VrstaPrijave = 1;
            prijava.PodaciOPrijavi.ObracunskiPeriod = "2013-12";
            prijava.PodaciOPrijavi.OznakaZaKonacnu = new PodaciOPrijaviTipOznakaZaKonacnu();
            prijava.PodaciOPrijavi.OznakaZaKonacnuSpecified = true;
            prijava.PodaciOPrijavi.DatumPlacanja = System.DateTime.Now.ToString("yyyy-MM-dd");
            prijava.PodaciOPrijavi.DatumPlacanjaSpecified = true;

            //podaci o isplatiocu, fiksno za istog//
            prijava.PodaciOIsplatiocu.TipIsplatioca = 1;
            // prijava.PodaciOIsplatiocu.VrstaIdentifikatorIsplatioca = 0;
            prijava.PodaciOIsplatiocu.PoreskiIdentifikacioniBroj = "102859935";
            prijava.PodaciOIsplatiocu.BrojZaposlenih = br1.ToString();
            prijava.PodaciOIsplatiocu.MaticniBrojisplatioca = "17498185";
            prijava.PodaciOIsplatiocu.NazivPrezimeIme = "SIMPEN D.O.O";
            prijava.PodaciOIsplatiocu.SedistePrebivaliste = "030";
            prijava.PodaciOIsplatiocu.Telefon = "017 650 201";
            prijava.PodaciOIsplatiocu.UlicaIBroj = "Industrijska b.b.";
            prijava.PodaciOIsplatiocu.eMail = "v.petrovic@simpen.biz";

            //Deklarisani prihodi....

            Popuna[] pomocni = new Popuna[br + 1];
            var spisak = new List<PodaciOPrihodimaTip>(br + 1);
            Citac(pomocni, spisak);
            prijava.DeklarisaniPrihodi.PodaciOPrihodima = spisak;
            Serialize(prijava);

        }
    }
}
