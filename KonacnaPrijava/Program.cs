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
            swosh.Serialize(pisac, prijava);
            pisac.Close();
        }
        static public List<PodaciOPrihodimaTip> Citac(Popuna[] info, List<PodaciOPrihodimaTip> spisak)
        {

            FileHelperEngine motorce = new FileHelperEngine(typeof(Popuna));
            info = motorce.ReadFile(@"D:\Simpen\konacna.txt") as Popuna[];
            LinkedList<Popuna> infolista = new LinkedList<Popuna>();
            
            foreach (Popuna pop in info)
            {
                infolista.AddLast(pop);
            }
            LinkedListNode<Popuna> tour = infolista.First;
            //int i = 0;
            while (tour!=null)
            {
                PodaciOPrihodimaTip sp = new PodaciOPrihodimaTip();
                MultifunkcionalnoPolje pom = new MultifunkcionalnoPolje();
                List<MultifunkcionalnoPolje> pom1 = new List<MultifunkcionalnoPolje>();
                switch (tour.Value.SVP)
                {
                    case 101101000:
                        
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
                            pom.Vrednost = Convert.ToString(tour.Value.MF1);
                            pom1.Add(pom);
                            pom.Oznaka = MultifunkcionalnoPoljeOznaka.MFP2;
                            pom.Vrednost = Convert.ToString(tour.Value.MF2);
                            pom1.Add(pom);
                            pom.Oznaka = MultifunkcionalnoPoljeOznaka.MFP4;
                            pom.Vrednost = Convert.ToString(tour.Value.MF4);
                            pom1.Add(pom);
                            pom.Oznaka = MultifunkcionalnoPoljeOznaka.MFP11;
                            pom.Vrednost = Convert.ToString(tour.Value.MF11);
                            pom1.Add(pom);
                            pom.Oznaka = MultifunkcionalnoPoljeOznaka.MFP12;
                            pom.Vrednost = Convert.ToString(tour.Value.MF12);
                            pom1.Add(pom);
                            sp.DeklarisaniMFP.MFP.AddRange(pom1);
                            sp.DeklarisaniMFPSpecified = true;
                            spisak.Add(sp);
                            tour = tour.Next;
                            
                        }
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
                        
                       break;
                    case 101202000:
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
                            pom.Oznaka = MultifunkcionalnoPoljeOznaka.MFP10;
                            pom.Vrednost = "1";
                            sp.DeklarisaniMFP.MFP.Add(pom);
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
            return spisak;
        }
        static public int Brojac()
        {
            FileHelperEngine motorce = new FileHelperEngine(typeof(Popuna));
            Popuna[] sp = motorce.ReadFile(@"D:\Simpen\konacna.txt") as Popuna[];
            return sp.Length;
        }
        static public int BrojacRadnika()
        {
            FileHelperEngine motorce = new FileHelperEngine(typeof(Popuna));
            Popuna[] sp = motorce.ReadFile(@"D:\Simpen\konacna.txt") as Popuna[];
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
                if (j < sp.Length-1)
                    j++;
            }
            
            return broj;

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

            Popuna[] pomocni = new Popuna[br+1];
            var spisak = new List<PodaciOPrihodimaTip>(br+1);
            Citac(pomocni, spisak);
            prijava.DeklarisaniPrihodi.PodaciOPrihodima = spisak;
            Serialize(prijava);
        }
    }
}
