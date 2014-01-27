﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.37595
//    <NameSpace>PPPPDPrijava</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace PPPPDPrijava 
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
	using FileHelpers;


	[System.Xml.Serialization.XmlRoot("PodaciPoreskeDeklaracije", Namespace = "http://pid.purs.gov.rs", IsNullable = true)]
    
    
    public partial class PodaciPoreskeDeklaracijeTip 

	{
        
        private PodaciOPrijaviTip podaciOPrijaviField;
        
        private PodaciOIsplatiocuTip podaciOIsplatiocuField;
        
        private PodaciPoreskeDeklaracijeTipDeklarisaniPrihodi deklarisaniPrihodiField;

        
        private UkupnoTip ukupnoField;

        
        private KamataTip kamataField;

        
        public PodaciPoreskeDeklaracijeTip() {

            this.kamataField = new KamataTip();
            this.ukupnoField = new UkupnoTip();
            this.deklarisaniPrihodiField = new PodaciPoreskeDeklaracijeTipDeklarisaniPrihodi();
            this.podaciOIsplatiocuField = new PodaciOIsplatiocuTip();
            this.podaciOPrijaviField = new PodaciOPrijaviTip();
        }
		[System.Xml.Serialization.XmlElement("PodaciOPrijavi")]
        
        public PodaciOPrijaviTip PodaciOPrijavi {



            get {
                return this.podaciOPrijaviField;
            }


            set {
                this.podaciOPrijaviField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("PodaciOIsplatiocu")]
        
        public PodaciOIsplatiocuTip PodaciOIsplatiocu {



            get {
                return this.podaciOIsplatiocuField;
            }


            set {
                this.podaciOIsplatiocuField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("DeklarisaniPrihodi")]
        
        public PodaciPoreskeDeklaracijeTipDeklarisaniPrihodi DeklarisaniPrihodi {



            get {
                return this.deklarisaniPrihodiField;
            }


            set {
                this.deklarisaniPrihodiField = value;
            }
        }









        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public UkupnoTip Ukupno {
            get {
                return this.ukupnoField;
            }
            set {
                this.ukupnoField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public KamataTip Kamata {

            get {
                return this.kamataField;


            }
            set {
                this.kamataField = value;


            }
        }
    }
    

    public partial class PodaciOPrijaviTip {


        
        private string klijentskaOznakaDeklaracijeField;

        
        private int vrstaPrijaveField;

        
        private string obracunskiPeriodField;

        
        private PodaciOPrijaviTipOznakaZaKonacnu oznakaZaKonacnuField;

        
        private bool oznakaZaKonacnuFieldSpecified;

        
        private System.DateTime datumNastankaPoreskeObavezeField;

        
        private bool datumNastankaPoreskeObavezeFieldSpecified;

        
        private System.String datumPlacanjaField;

        
        private bool datumPlacanjaFieldSpecified;

        
        private int vrstaIzmeneField;

        
        private bool vrstaIzmeneFieldSpecified;

        
        private ulong jIPDField;

        
        private bool jIPDFieldSpecified;

        
        private string brojResenjaField;

        
        private int osnovField;

        
        private bool osnovFieldSpecified;

        
        private string najnizaOsnovicaField;


		[System.Xml.Serialization.XmlElement("KlijentskaOznakaDeklaracije")]
        
        public string KlijentskaOznakaDeklaracije {



            get {
                return this.klijentskaOznakaDeklaracijeField;
            }


            set {
                this.klijentskaOznakaDeklaracijeField = value;
            }
        }
		 [System.Xml.Serialization.XmlElement("VrstaPrijave")]
        
        public int VrstaPrijave {



            get {
                return this.vrstaPrijaveField;
            }


            set {
                this.vrstaPrijaveField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("ObracunskiPeriod")]
        
        public string ObracunskiPeriod {



            get {
                return this.obracunskiPeriodField;
            }


            set {
                this.obracunskiPeriodField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("OznakaZaKonacnu")]
        
        public PodaciOPrijaviTipOznakaZaKonacnu OznakaZaKonacnu {



            get {
                return this.oznakaZaKonacnuField;
            }


            set {
                this.oznakaZaKonacnuField = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OznakaZaKonacnuSpecified {



            get {
                return this.oznakaZaKonacnuFieldSpecified;
            }


            set {
                this.oznakaZaKonacnuFieldSpecified = value;
            }
        }

        
        public System.DateTime DatumNastankaPoreskeObaveze {



            get {
                return this.datumNastankaPoreskeObavezeField;
            }


            set {
                this.datumNastankaPoreskeObavezeField = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DatumNastankaPoreskeObavezeSpecified {



            get {
                return this.datumNastankaPoreskeObavezeFieldSpecified;
            }


            set {
                this.datumNastankaPoreskeObavezeFieldSpecified = value;
            }
        }
		[System.Xml.Serialization.XmlElement("DatumPlacanja")]
        
        public System.String DatumPlacanja {



            get {
                return this.datumPlacanjaField;
            }


            set {
                this.datumPlacanjaField = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DatumPlacanjaSpecified {



            get {
                return this.datumPlacanjaFieldSpecified;
            }


            set {
                this.datumPlacanjaFieldSpecified = value;
            }
        }

        
        public int VrstaIzmene {



            get {
                return this.vrstaIzmeneField;
            }


            set {
                this.vrstaIzmeneField = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VrstaIzmeneSpecified {



            get {
                return this.vrstaIzmeneFieldSpecified;
            }


            set {
                this.vrstaIzmeneFieldSpecified = value;
            }
        }

        
        public ulong JIPD {



            get {
                return this.jIPDField;
            }


            set {
                this.jIPDField = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool JIPDSpecified {



            get {
                return this.jIPDFieldSpecified;
            }


            set {
                this.jIPDFieldSpecified = value;
            }
        }

        
        public string BrojResenja {



            get {
                return this.brojResenjaField;
            }


            set {
                this.brojResenjaField = value;
            }
        }

        
        public int Osnov {



            get {
                return this.osnovField;
            }


            set {
                this.osnovField = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OsnovSpecified {



            get {
                return this.osnovFieldSpecified;
            }


            set {
                this.osnovFieldSpecified = value;
            }
        }

        
        public string NajnizaOsnovica {



            get {
                return this.najnizaOsnovicaField;
            }


            set {
                this.najnizaOsnovicaField = value;
            }
        }













    }

    
    public enum PodaciOPrijaviTipOznakaZaKonacnu {


        
        /// <remarks/>
        K,
    }

    
    public partial class KamataTip {


        
        private decimal porezField;

        
        private decimal pIOField;

        
        private decimal zDRField;

        
        private decimal nEZField;

        
        private decimal pIOBenField;

        
        public decimal Porez {



            get {
                return this.porezField;
            }


            set {
                this.porezField = value;
            }
        }

        
        public decimal PIO {



            get {
                return this.pIOField;
            }


            set {
                this.pIOField = value;
            }
        }

        
        public decimal ZDR {



            get {
                return this.zDRField;
            }


            set {
                this.zDRField = value;
            }
        }

        
        public decimal NEZ {



            get {
                return this.nEZField;
            }


            set {
                this.nEZField = value;
            }
        }

        
        public decimal PIOBen {



            get {
                return this.pIOBenField;
            }


            set {
                this.pIOBenField = value;
            }
        }
    }

    
    public partial class UkupnoTip {


        
        private decimal brutoField;

        
        private decimal osnovicaPorezField;

        
        private decimal porezField;

        
        private decimal osnovicaDoprinosiField;

        
        private decimal pIOField;

        
        private decimal zDRField;

        
        private decimal nEZField;

        
        private decimal pIOBenField;

        
        public decimal Bruto {



            get {
                return this.brutoField;
            }


            set {
                this.brutoField = value;
            }
        }

        
        public decimal OsnovicaPorez {



            get {
                return this.osnovicaPorezField;
            }


            set {
                this.osnovicaPorezField = value;
            }
        }

        
        public decimal Porez {



            get {
                return this.porezField;
            }


            set {
                this.porezField = value;
            }
        }

        
        public decimal OsnovicaDoprinosi {



            get {
                return this.osnovicaDoprinosiField;
            }


            set {
                this.osnovicaDoprinosiField = value;
            }
        }

        
        public decimal PIO {



            get {
                return this.pIOField;
            }


            set {
                this.pIOField = value;
            }
        }

        
        public decimal ZDR {



            get {
                return this.zDRField;
            }


            set {
                this.zDRField = value;
            }
        }

        
        public decimal NEZ {



            get {
                return this.nEZField;
            }


            set {
                this.nEZField = value;
            }
        }

        
        public decimal PIOBen {



            get {
                return this.pIOBenField;
            }


            set {
                this.pIOBenField = value;
            }
        }
    }

    
    public partial class MultifunkcionalnoPolje {


        
        private MultifunkcionalnoPoljeOznaka oznakaField;

        
        private string vrednostField;

        
        public MultifunkcionalnoPoljeOznaka Oznaka {



            get {
                return this.oznakaField;
            }


            set {
                this.oznakaField = value;
            }
        }

        
        public string Vrednost {



            get {
                return this.vrednostField;
            }


            set {
                this.vrednostField = value;
            }
        }
    }

    
    public enum MultifunkcionalnoPoljeOznaka {


        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("MFP.1")]
        MFP1,

        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("MFP.2")]
        MFP2,

        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("MFP.3")]
        MFP3,

        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("MFP.4")]
        MFP4,

        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("MFP.5")]
        MFP5,

        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("MFP.6")]
        MFP6,

        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("MFP.7")]
        MFP7,

        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("MFP.8")]
        MFP8,

        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("MFP.9")]
        MFP9,

        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("MFP.10")]
        MFP10,

        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("MFP.11")]
        MFP11,

        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("MFP.12")]
        MFP12,
    }
    
    public partial class PodaciOPrihodimaTip {


        
        private string redniBrojField;

        
        private int vrstaIdentifikatoraPrimaocaField;

        
        private string identifikatorPrimaocaField;

        
        private string prezimeField;

        
        private string imeField;

        
        private string oznakaPrebivalistaField;

        
        private int sVPField;

        
        private string brojKalendarskihDanaField;



        
        private decimal brojEfektivnihSatiField;

        
        private bool brojEfektivnihSatiFieldSpecified;

        
        private decimal mesecniFondSatiField;

        
        private bool mesecniFondSatiFieldSpecified;

        
        private decimal brutoField;

        
        private decimal osnovicaPorezField;

        
        private decimal porezField;

        
        private decimal osnovicaDoprinosiField;

        
        private decimal pIOField;

        
        private decimal zDRField;

        
        private decimal nEZField;

        
        private decimal pIOBenField;

        
        private PodaciOPrihodimaTipDeklarisaniMFP deklarisaniMFPField;

        
        public PodaciOPrihodimaTip() {

            this.deklarisaniMFPField = new PodaciOPrihodimaTipDeklarisaniMFP();
        }
		[System.Xml.Serialization.XmlElement("RedniBroj")]
        
        public string RedniBroj {



            get {
                return this.redniBrojField;
            }


            set {
                this.redniBrojField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("VrstaIdentifikatoraPrimaoca")]
        
        public int VrstaIdentifikatoraPrimaoca {



            get {
                return this.vrstaIdentifikatoraPrimaocaField;
            }


            set {
                this.vrstaIdentifikatoraPrimaocaField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("IdentifikatorPrimaoca")]
        
        public string IdentifikatorPrimaoca {



            get {
                return this.identifikatorPrimaocaField;
            }


            set {
                this.identifikatorPrimaocaField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("Prezime")]	
        
        public string Prezime {



            get {
                return this.prezimeField;
            }


            set {
                this.prezimeField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("Ime")]
        
        public string Ime {



            get {
                return this.imeField;
            }


            set {
                this.imeField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("OznakaPrebivalista")]
        
        public string OznakaPrebivalista {



            get {
                return this.oznakaPrebivalistaField;
            }


            set {
                this.oznakaPrebivalistaField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("SVP")]
        
        public int SVP {



            get {
                return this.sVPField;
            }


            set {
                this.sVPField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("BrojKalendarskihDana")]
        
        public string BrojKalendarskihDana {



            get {
                return this.brojKalendarskihDanaField;
            }


            set {
                this.brojKalendarskihDanaField = value;
            }













        }
		[System.Xml.Serialization.XmlElement("BrojEfektivnihSati")]
        
        public decimal BrojEfektivnihSati {



            get {
                return this.brojEfektivnihSatiField;
            }


            set {
                this.brojEfektivnihSatiField = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BrojEfektivnihSatiSpecified {



            get {
                return this.brojEfektivnihSatiFieldSpecified;
            }


            set {
                this.brojEfektivnihSatiFieldSpecified = value;
            }
        }
		[System.Xml.Serialization.XmlElement("MesecniFondSati")]
        
        public decimal MesecniFondSati {



            get {
                return this.mesecniFondSatiField;
            }


            set {
                this.mesecniFondSatiField = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MesecniFondSatiSpecified {



            get {
                return this.mesecniFondSatiFieldSpecified;
            }


            set {
                this.mesecniFondSatiFieldSpecified = value;
            }
        }
		[System.Xml.Serialization.XmlElement("Bruto")]
        
        public decimal Bruto {



            get {
                return this.brutoField;
            }


            set {
                this.brutoField = value;
            }
        }

        
        public decimal OsnovicaPorez {



            get {
                return this.osnovicaPorezField;
            }


            set {
                this.osnovicaPorezField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("Porez")]
        
        public decimal Porez {



            get {
                return this.porezField;
            }


            set {
                this.porezField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("OsnovicaDoprinosi")]
        
        public decimal OsnovicaDoprinosi {



            get {
                return this.osnovicaDoprinosiField;
            }


            set {
                this.osnovicaDoprinosiField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("PIO")]
        
        public decimal PIO {



            get {
                return this.pIOField;
            }


            set {
                this.pIOField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("ZDR")]
        
        public decimal ZDR {



            get {
                return this.zDRField;
            }


            set {
                this.zDRField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("NEZ")]
        
        public decimal NEZ {



            get {
                return this.nEZField;
            }


            set {
                this.nEZField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("PIOBen")]
        
        public decimal PIOBen {



            get {
                return this.pIOBenField;
            }


            set {
                this.pIOBenField = value;
            }
        }
		[System.Xml.Serialization.XmlIgnoreAttribute()]
        
        public PodaciOPrihodimaTipDeklarisaniMFP DeklarisaniMFP {



            get {
                return this.deklarisaniMFPField;

            }


            set {
                this.deklarisaniMFPField = value;
            }
        }

    }

    
    public partial class PodaciOPrihodimaTipDeklarisaniMFP {


        
        private List<MultifunkcionalnoPolje> mFPField;

        
        public PodaciOPrihodimaTipDeklarisaniMFP() {

            this.mFPField = new List<MultifunkcionalnoPolje>();
        }

        
        public List<MultifunkcionalnoPolje> MFP {



            get {
                return this.mFPField;
            }


            set {
                this.mFPField = value;
            }
        }
    }
    
    public partial class PodaciOIsplatiocuTip {


        
        private int tipIsplatiocaField;



        
        private string poreskiIdentifikacioniBrojField;

        
        private string brojZaposlenihField;

        
        private string maticniBrojisplatiocaField;

        
        private string nazivPrezimeImeField;

        
        private string sedistePrebivalisteField;

        
        private string telefonField;

        
        private string ulicaIBrojField;

        
        private string eMailField;
		[System.Xml.Serialization.XmlElement("TipIsplatioca")]
        
        public int TipIsplatioca {



            get {
                return this.tipIsplatiocaField;
            }


            set {
                this.tipIsplatiocaField = value;
            }
        }












		[System.Xml.Serialization.XmlElement("PoreskiIdentifikacioniBroj")]
        
        public string PoreskiIdentifikacioniBroj {



            get {
                return this.poreskiIdentifikacioniBrojField;
            }


            set {
                this.poreskiIdentifikacioniBrojField = value;
            }
        }
		 [System.Xml.Serialization.XmlElement("BrojZaposlenih")]	
        
        public string BrojZaposlenih {



            get {
                return this.brojZaposlenihField;
            }


            set {
                this.brojZaposlenihField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("MaticniBrojIsplatioca")]
        
        public string MaticniBrojisplatioca {



            get {
                return this.maticniBrojisplatiocaField;
            }


            set {
                this.maticniBrojisplatiocaField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("NazivPrezimeIme")]
        
        public string NazivPrezimeIme {



            get {
                return this.nazivPrezimeImeField;
            }


            set {
                this.nazivPrezimeImeField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("SedistePrebivaliste")]
        
        public string SedistePrebivaliste {



            get {
                return this.sedistePrebivalisteField;
            }


            set {
                this.sedistePrebivalisteField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("Telefon")]
        
        public string Telefon {



            get {
                return this.telefonField;
            }


            set {
                this.telefonField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("UlicaIBroj")]
        
        public string UlicaIBroj {



            get {
                return this.ulicaIBrojField;
            }


            set {
                this.ulicaIBrojField = value;
            }
        }
		[System.Xml.Serialization.XmlElement("eMail")]
        
        public string eMail {



            get {
                return this.eMailField;
            }


            set {
                this.eMailField = value;
            }
        }
    }

    
    public partial class PodaciPoreskeDeklaracijeTipDeklarisaniPrihodi {


        
        private List<PodaciOPrihodimaTip> podaciOPrihodimaField;

        
        public PodaciPoreskeDeklaracijeTipDeklarisaniPrihodi() {

            this.podaciOPrihodimaField = new List<PodaciOPrihodimaTip>();
        }
		[System.Xml.Serialization.XmlElement("PodaciOPrihodima")]
        
        public List<PodaciOPrihodimaTip> PodaciOPrihodima {



            get {
                return this.podaciOPrihodimaField;
            }


            set {
                this.podaciOPrihodimaField = value;
            }
        }
    }
	[DelimitedRecord("\t")] 
    public class Popuna
    {
        private string redniBroj;
        private int vrstaIdentifikatoraPrimaoca;
        private string identifikatorPrimaoca;
        private string prezime;
        private string ime;
        private string oznakaPrebivalista;
        private int sVP;
        private string brojKalendarskihDana;
        private decimal mesecniFondSati;
        private decimal brojEfektivnihSati;
        private decimal bruto;
        private decimal osnovicaPorez;
        private decimal porez;
        private decimal osnovicaDoprinosi;
        private decimal pIO;
        private decimal zDR;
        private decimal nEZ;
        private decimal pIOBen;
        private PodaciOPrihodimaTipDeklarisaniMFP deklarisaniMFPField;
        public PodaciOPrihodimaTipDeklarisaniMFP DeklarisaniMFP
        {



            get
            {
                return this.deklarisaniMFPField;

            }


            set
            {
                this.deklarisaniMFPField = value;
            }
        }
       
        
        public string RedniBroj
        {
            get
            {
                return this.redniBroj;
            }
            set
            {
                this.redniBroj = value;
            }
        }
        public int VrstaIdentifikatoraPrimaoca
        {
            get
            {
                return this.vrstaIdentifikatoraPrimaoca;
            }
            set
            {
                this.vrstaIdentifikatoraPrimaoca = value;
            }
        }

        public string IdentifikatorPrimaoca
        {
            get
            {
                return this.identifikatorPrimaoca;
            }
            set
            {
                this.identifikatorPrimaoca = value;
            }
        }

        public string Prezime
        {
            get
            {
                return this.prezime;
            }
            set
            {
                this.prezime = value;
            }
        }

        public string Ime
        {
            get
            {
                return this.ime;
            }
            set
            {
                this.ime = value;
            }
        }

        public string OznakaPrebivalista
        {
            get
            {
                return this.oznakaPrebivalista;
            }
            set
            {
                this.oznakaPrebivalista = value;
            }
        }

        public int SVP
        {
            get
            {
                return this.sVP;
            }
            set
            {
                this.sVP = value;
            }
        }

        public string BrojKalendarskihDana
        {
            get
            {
                return this.brojKalendarskihDana;
            }
            set
            {
                this.brojKalendarskihDana = value;
            }
        }
        public decimal BrojEfektivnihSati
        {
            get
            {
                return this.brojEfektivnihSati;
            }
            set
            {
                this.brojEfektivnihSati = value;
            }
        }
        public decimal MesecniFondSati
        {
            get
            {
                return this.mesecniFondSati;
            }
            set
            {
                this.mesecniFondSati = value;
            }
        }
        public decimal Bruto
        {
            get
            {
                return this.bruto;
            }
            set
            {
                this.bruto = value;
            }
        }

        public decimal OsnovicaPorez
        {
            get
            {
                return this.osnovicaPorez;
            }
            set
            {
                this.osnovicaPorez = value;
            }
        }

        public decimal Porez
        {
            get
            {
                return this.porez;
            }
            set
            {
                this.porez = value;
            }
        }

        public decimal OsnovicaDoprinosi
        {
            get
            {
                return this.osnovicaDoprinosi;
            }
            set
            {
                this.osnovicaDoprinosi = value;
            }
        }

        public decimal PIO
        {
            get
            {
                return this.pIO;
            }
            set
            {
                this.pIO = value;
            }
        }

        public decimal ZDR
        {
            get
            {
                return this.zDR;
            }
            set
            {
                this.zDR = value;
            }
        }

        public decimal NEZ
        {
            get
            {
                return this.nEZ;
            }
            set
            {
                this.nEZ = value;
            }
        }

        public decimal PIOBen
        {
            get
            {
                return this.pIOBen;
            }
            set
            {
                this.pIOBen = value;

            }

        }
    }
}












































































































































































































































