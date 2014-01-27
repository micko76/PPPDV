using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using PPPPDPrijava;
using ConsoleApplication1;
using FileHelpers;

namespace ConsoleApplication1
{
    class Program
    {
        
        
        static public void Serialize(PodaciPoreskeDeklaracijeTip prijava)
        {
            XmlSerializer swosh = new XmlSerializer(typeof(PodaciPoreskeDeklaracijeTip));
            TextWriter pisac = new StreamWriter(@"F:\Porezi,Prijave i ostalo\prijavicaprobna.xml");
            swosh.Serialize(pisac, prijava);
            pisac.Close();
        }
        static public List<PodaciOPrihodimaTip> Citac(Popuna[] info,List<PodaciOPrihodimaTip> spisak)
        {

            FileHelperEngine motorce = new FileHelperEngine(typeof(Popuna));
            info = motorce.ReadFile(@"F:\Porezi,Prijave i ostalo\ppppd septembar II deo 2013-simpo.txt") as Popuna[];
            int i = 0;
            while (i < info.Length)
            {
                PodaciOPrihodimaTip sp = new PodaciOPrihodimaTip();
                sp.RedniBroj = info[i].RedniBroj;
                sp.VrstaIdentifikatoraPrimaoca = info[i].VrstaIdentifikatoraPrimaoca;
                sp.IdentifikatorPrimaoca = info[i].IdentifikatorPrimaoca;
                sp.Ime = info[i].Ime.Trim();
                sp.Prezime = info[i].Prezime.Trim();
                sp.OznakaPrebivalista = info[i].OznakaPrebivalista;
                sp.SVP = info[i].SVP;
                sp.BrojKalendarskihDana = info[i].BrojKalendarskihDana;
                sp.BrojKalendarskihDanaSpecified = true;
                sp.MesecniFondSati = info[i].MesecniFondSati;
                sp.MesecniFondSatiSpecified = true;
                sp.BrojEfektivnihSati = info[i].BrojEfektivnihSati;
                sp.BrojEfektivnihSatiSpecified = true;
                sp.Bruto = info[i].Bruto;
                sp.OsnovicaPorez = info[i].OsnovicaPorez;
                sp.Porez = info[i].Porez;
                sp.OsnovicaDoprinosi = info[i].OsnovicaDoprinosi;
                sp.PIO = info[i].PIO;
                sp.ZDR = info[i].ZDR;
                sp.NEZ = info[i].NEZ;
                sp.PIOBen = info[i].PIOBen;
                spisak.Add(sp);
                i++;
            }
            return spisak;
        }
        static public int Brojac()
        {
            FileHelperEngine motorce = new FileHelperEngine(typeof(Popuna));
            Popuna[] sp = motorce.ReadFile(@"F:\Porezi,Prijave i ostalo\ppppd septembar II deo 2013-simpo.txt") as Popuna[];
            return sp.Length;
 
        }
        static void Main(string[] args)
        {
            
            
            PodaciPoreskeDeklaracijeTip prijava = new PodaciPoreskeDeklaracijeTip();
            int br = Brojac();
            //podaci o prijavi, ovo ide uvek isto//
            prijava.PodaciOPrijavi.KlijentskaOznakaDeklaracije = 21212121;
            prijava.PodaciOPrijavi.VrstaPrijave = 1;
            prijava.PodaciOPrijavi.ObracunskiPeriod = "2013-9";
            prijava.PodaciOPrijavi.OznakaZaKonacnu = new PodaciOPrijaviTipOznakaZaKonacnu();
            prijava.PodaciOPrijavi.OznakaZaKonacnuSpecified = true;
            prijava.PodaciOPrijavi.DatumPlacanja = System.DateTime.Now.ToString("yyyy-MM-dd");
            prijava.PodaciOPrijavi.DatumPlacanjaSpecified = true;
            
            //podaci o isplatiocu, fiksno za istog//
            prijava.PodaciOIsplatiocu.TipIsplatioca = 1;
            prijava.PodaciOIsplatiocu.VrstaIdentifikatorIsplatioca = 0;
            prijava.PodaciOIsplatiocu.PoreskiIdentifikacioniBroj = "10084333";
            prijava.PodaciOIsplatiocu.BrojZaposlenih = br.ToString();
            prijava.PodaciOIsplatiocu.MaticniBrojisplatioca = "23231112";
            prijava.PodaciOIsplatiocu.NazivPrezimeIme = "Simpo A.D. Vranje";
            prijava.PodaciOIsplatiocu.SedistePrebivaliste = "22";
            prijava.PodaciOIsplatiocu.Telefon = "017 407 418";
            prijava.PodaciOIsplatiocu.UlicaIBroj = "Radnicka 12";
            prijava.PodaciOIsplatiocu.eMail = "cvetko@simpo.rs";

            //Deklarisani prihodi....
            
            Popuna[] pomocni= new Popuna[br];
            var spisak = new List<PodaciOPrihodimaTip>(br);
            Citac(pomocni,spisak);
            prijava.DeklarisaniPrihodi.PodaciOPrihodima = spisak;
            Serialize(prijava);
        }
    }
}
