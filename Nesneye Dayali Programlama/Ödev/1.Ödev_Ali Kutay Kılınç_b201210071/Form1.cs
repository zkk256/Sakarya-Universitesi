/****************************************************************************************
**					     SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				     BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				    NESNEYE DAYALI PROGRAMLAMA DERSİ
**					     2020-2021 YAZ DÖNEMİ
**	
**				ÖDEV NUMARASI..........:1. Ödev
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

namespace _1.Ödev_Ali_Kutay_Kılınç_b201210071
{
    public partial class Form1 : Form
    {
        //Butona(Arkadas mı?) basılma sayısınıu gösteren değer
        int basildi = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnArkadas_Click(object sender, EventArgs e)
        {
            //Butona(Arkadas mı?) 2. kez basıldığında bir daha basılaması engellenir
            basildi++;
            if (basildi == 2)
            {
                btnArkadas.Enabled = false;
            }
            else
            {
                //Butona basıldıktn sonra form bu boyutlara büyür
                this.Height = 440;
                this.Width = 600;

                //Program ilk başladığında görünenler dışında ekrana yeni eklenecek kontroller tanımlanır
                var Liste1 = new ListBox();
                var Liste2 = new ListBox();
                var lblX = new Label();
                var lblY = new Label();
                var txtXToplam = new TextBox();
                var txtYToplam = new TextBox();

                Liste1.Top = 50;
                Liste2.Top = 50;
                Liste1.Left = 275;
                Liste2.Left = 425;
                Liste1.Height = 250;
                Liste2.Height = 250;

                lblX.Text = "X";
                lblY.Text = "Y";
                lblX.Left = 325;
                lblY.Left = 475;
                lblX.Top = 20;
                lblY.Top = 20;


                //Çarpanların toplam değerleri TextBox'larda kullanıcının değiştirmesine izin verilmeyecek şekilde olacak.
                txtXToplam.ReadOnly = true;
                txtYToplam.ReadOnly = true;

                txtXToplam.AutoSize = false;
                txtYToplam.AutoSize = false;

                txtXToplam.BackColor = Color.White;
                txtYToplam.BackColor = Color.White;
                txtXToplam.Left = 275;
                txtYToplam.Left = 425;
                txtXToplam.Top = 300;
                txtYToplam.Top = 300;

                //Yeni kontroller eklenir
                Controls.Add(lblX);
                Controls.Add(lblY);

                Controls.Add(txtXToplam);
                Controls.Add(txtYToplam);

                Controls.Add(Liste1);
                Controls.Add(Liste2);

                //Girilen iki sayı int olarak alınır
                int x = int.Parse(txtSayi1.Text);
                int y = int.Parse(txtSayi2.Text);
                int xToplam = 0, yToplam = 0;

                //X sayısı çarpanlarına ayrılır
                //X sayısının her bir çarpanı Liste1'e eklenir. 
                for (int i = 1; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        xToplam += i;
                        Liste1.Items.Add(i.ToString());
                    }
                }

                //Y sayısı çarpanlarına ayrılır
                //Y sayısının her bir çarpanı Liste2'ye eklenir. 
                for (int j = 1; j < y; j++)
                {
                    if (y % j == 0)
                    {
                        yToplam += j;
                        Liste2.Items.Add(j.ToString());
                    }
                }
                txtXToplam.Text = xToplam.ToString();
                txtYToplam.Text = yToplam.ToString();

                //Sayıların arkadaş olup olmadığı kontrol edilir. Mesaj olarak ekrana gelir
                if (xToplam == y && yToplam == x)
                    MessageBox.Show("Arkadaş Sayılar");
                else
                    MessageBox.Show("Arkadaş değiller");
            }
        }

        //Bu buton(SON) programı kapatır
        private void btnSon_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
