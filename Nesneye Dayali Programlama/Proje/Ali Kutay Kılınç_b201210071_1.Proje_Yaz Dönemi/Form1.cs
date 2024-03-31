/****************************************************************************************
**					     SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				     BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				    NESNEYE DAYALI PROGRAMLAMA DERSİ
**					     2020-2021 YAZ DÖNEMİ
**	
**				ÖDEV NUMARASI..........:1. Proje
**				ÖĞRENCİ ADI............:Ali Kutay KILINÇ
**				ÖĞRENCİ NUMARASI.......:b201210071
**              DERSİN ALINDIĞI GRUP...:1. Öğretim A
*****************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ali_Kutay_Kılınç_b201210071_1.Proje_Yaz_Dönemi
{


    public partial class Form1 : Form
    {
        interface IBuz
        {
            int IcHacim { get; set; }
            string EnerjiSinifi { get; set; }
        }
        interface IEkran
        {
            int EkranBoyutu { get; set; }
            int EkranCozunurlugu { get; set; }
        }
        interface IOzellikler
        {
            int DahiliHafiza { get; set; }
            int RamKapasitesi { get; set; }
            int PilGucu { get; set; }
        }

        class Urun
        {
            string _ad;
            string _marka;
            string _model;
            string _ozellik;
            int _stokAdedi;
            double _hamFiyat;
            double _kdvFiyat;
            int _secilenAdet;

            public string Ad
            {
                get { return _ad; }
                set { _ad = value; }
            }
            public string Marka
            {
                get { return _marka; }
                set { _marka = value; }
            }
            public string Model
            {
                get { return _model; }
                set { _model = value; }
            }
            public string Ozellik
            {
                get { return _ozellik; }
                set { _ozellik = value; }
            }
            public int StokAdedi
            {
                get { return _stokAdedi; }
                set { _stokAdedi = value; }
            }
            public double HamFiyat
            {
                get { return _hamFiyat; }
                set { _hamFiyat = value; }
            }
            public int SecilenAdet
            {
                get { return _secilenAdet; }
                set { _secilenAdet = value; }
            }
            public double KdvFiyat
            {
                get { return _kdvFiyat; }
                set { _kdvFiyat = value; }
            }

            public Urun()
            {
                Random rnd = new Random();
                StokAdedi= rnd.Next(1, 100);
            }
        }
        class Buzdolabı : Urun,IBuz
        {
            public Buzdolabı()
            {
                Ad = "Buzdolabı";
                Marka = "Buzz";
                Model = "Buz-2021";
                Ozellik = "İlk günkü gibi taze tutar";
                HamFiyat = 4000;
                KdvFiyat = HamFiyat * 1.05;

            }

            public int IcHacim { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string EnerjiSinifi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }
        class LedTv : Urun,IEkran   
        {
            public LedTv() 
            {
                Ad = "LedTV";
                Marka = "Lestel";
                Model = "Led-2021";
                Ozellik = "Gerçekçi görüntü";
                HamFiyat = 6000;
                KdvFiyat = HamFiyat * 1.18;

            }

            public int EkranBoyutu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int EkranCozunurlugu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }
        class CepTel : Urun,IOzellikler
        {
            public CepTel() 
            {
                Ad = "CepTel";
                Marka = "Cell";
                Model = "Tel-2021";
                Ozellik = "Uzaktaki insanlarla konuş";
                HamFiyat = 3000;
                KdvFiyat = HamFiyat * 1.20;

            }

            public int DahiliHafiza { get; set; }
            public int RamKapasitesi { get; set; }
            public int PilGucu { get; set; }
        }
        class Laptop : Urun,IOzellikler,IEkran
        {
            public Laptop()
            {
                Ad = "Laptop";
                Marka = "Lap";
                Model = "LP-2021";
                Ozellik = "Bilgisayar";
                HamFiyat = 8000;
                KdvFiyat = HamFiyat * 1.15;

            }

            public int DahiliHafiza { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int RamKapasitesi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int PilGucu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int EkranBoyutu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int EkranCozunurlugu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }

        public Form1()
        {
            InitializeComponent();
        }
        int basildi = 0;

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            //Yeni değer girildiği zaman önce sepet temizlenir.Sonra girilen değer gösterilir.
            basildi++;
            if (basildi >= 2)
            {
                listBoxUrun.Items.Clear();
                listBoxAdet.Items.Clear();
                listBoxKDVFiyat.Items.Clear();
            }


            Buzdolabı b1 = new Buzdolabı();
            LedTv le1 = new LedTv();
            CepTel c1 = new CepTel();
            Laptop la1 = new Laptop();

            //Fiyat ve stok değerleri gösterilir

            b1.SecilenAdet = int.Parse(cmbBuzdolabiAdet.Text);
            lblBuzdolabiFiyat.Text = Convert.ToString(b1.HamFiyat);
            lblBuzdolabiStok.Text = Convert.ToString(b1.StokAdedi);

            le1.SecilenAdet = int.Parse(cmbTelevizyonAdet.Text);
            lblTelevizyonFiyat.Text = Convert.ToString(le1.HamFiyat);
            lblTelevizyonStok.Text = Convert.ToString(le1.StokAdedi);

            la1.SecilenAdet = int.Parse(cmbLaptopAdet.Text);
            lblLaptopFiyat.Text = Convert.ToString(la1.HamFiyat);
            lblLaptopStok.Text = Convert.ToString(la1.StokAdedi);

            c1.SecilenAdet = int.Parse(cmbCepTelAdet.Text);
            lblCepTelFiyat.Text = Convert.ToString(c1.HamFiyat );
            lblCepTelStok.Text = Convert.ToString(c1.StokAdedi);


            listBoxAdet.Items.Add(cmbTelevizyonAdet.Text);
            listBoxAdet.Items.Add(cmbBuzdolabiAdet.Text);
            listBoxAdet.Items.Add(cmbLaptopAdet.Text);
            listBoxAdet.Items.Add(cmbCepTelAdet.Text);

            listBoxUrun.Items.Add("Televizyon");
            listBoxUrun.Items.Add("Buzdolabı");
            listBoxUrun.Items.Add("Laptop");
            listBoxUrun.Items.Add("Cep Telefonu");

            listBoxKDVFiyat.Items.Add(b1.KdvFiyat * b1.SecilenAdet);
            listBoxKDVFiyat.Items.Add(le1.KdvFiyat * le1.SecilenAdet);
            listBoxKDVFiyat.Items.Add(la1.KdvFiyat * la1.SecilenAdet);
            listBoxKDVFiyat.Items.Add(c1.KdvFiyat * c1.SecilenAdet);

            lblToplamFiyat.Text = Convert.ToString(b1.KdvFiyat * b1.SecilenAdet + le1.KdvFiyat * le1.SecilenAdet + la1.KdvFiyat * la1.SecilenAdet + c1.KdvFiyat * c1.SecilenAdet);
        }

        private void btnSepetTemizle_Click(object sender, EventArgs e)
        {
            //Sepeti Temizler
            listBoxUrun.Items.Clear();
            listBoxAdet.Items.Clear();
            listBoxKDVFiyat.Items.Clear();
            lblToplamFiyat.Text = " ";
        }
    }
    
}
