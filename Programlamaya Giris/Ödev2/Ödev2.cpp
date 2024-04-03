/****************************************************************************
**                   SAKARYA ÜNİVERSİTESİ
**         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**              BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**               PROGRAMLAMAYA GİRİŞİ DERSİ
**
**				ÖDEV NUMARASI: 2. Ödev
**				ÖĞRENCİ ADI: Ali Kutay KILINÇ
**				ÖĞRENCİ NUMARASI: b201210071
**				DERS GRUBU: B grubu 1. Öğretim
****************************************************************************/
#include<iostream>
#include <locale.h> //Türkçe karakterlerin kullanımı için
using namespace std;

class Cati
{
public:
    //Genişliği ve yüksekliği verilen çatıyı oluşturur.
    void cati(int n,int catiGenislik,int catiYukseklik)
    {
        n = n / 2 + 1;
        int a, b, c, genislik;
        //Çatıyı girilen çatı yüksekliğine göre oluşturuyor.Çatının maksimum yüksekliğinden fazla bir değer verilirse yapabileceği en uzun çatıyı oluşturuyor.
        for ((a = ((catiGenislik+3)/2)-catiYukseklik); a <= n; a++)
        {
            for (c = n; c > a; c--)
            {
                cout << " ";
            }
            for (b = 1; b <= 2 * a - 1; b++)
            {
                cout << "*";
            }
            cout << endl;
        }
    }
};
class Kat{
public:
    //Evin kat kısmını, girilen boy ve genişliğe göre oluşturur.
    void kat(int genislik, int boy)
    {
        int i, j;
        for (i = 0; i < boy + 1; i++)
        {
            for (j = 0; j < genislik; j++)
            {
                if (i == boy) 
                {
                    cout << "-";
                }
                else
                {
                    //Evin dikey çizgilerini çizer
                    if (j == 0 or j == genislik - 1) 
                        cout << "|";
                    else //Evin iç kısmındaki boşlukları yapar
                        cout << " ";
                }

            }
            cout << endl;
        }
    }
};

int main(int argc, char const* argv[])
{
    setlocale(LC_ALL, "Turkish");
    Cati c1;
    Kat k1;
    int boy, genislik, catiYukseklik,x;
    cout << " Yükseklik: ";
    cin >> boy;
    cout << " Genişlik(2'den büyük  tek sayı girin): ";
    cin >> genislik;

    cout << " Çatı Yükseklik: ";
    cin >> catiYukseklik;

    cout << " x: ";//çizilicek evin dikey eksendeki konumunu belirler.
    cin >> x;

    for (int m = 0; m <= x; m++)
        cout << endl;
    if (genislik % 2 != 0 && genislik > 2)   //2'den büyük tek sayıysa çizer
    {
        int catiGenislik = genislik; //Evin genişliği ve çatının geniliği aynı
        c1.cati(genislik, catiGenislik, catiYukseklik);           
        k1.kat(genislik, boy);       
    }
    else //Genişlik değeri yanlışsa onu bildirir.Program biter
        cout << "Üzgünüm :("<<endl<<"Girdiğiniz " << genislik << "genişlik değeri yanlış!"<<endl<<"Evin genişliği için  2'den büyük bir tek sayı girmeliydiniz.\n\n";
    return 0;
}
