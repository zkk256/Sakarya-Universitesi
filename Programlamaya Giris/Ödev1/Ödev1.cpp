/****************************************************************************
**                   SAKARYA ÜNİVERSİTESİ
**         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**              BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**               PROGRAMLAMAYA GİRİŞİ DERSİ
**
**				ÖDEV NUMARASI: 1. Ödev
**				ÖĞRENCİ ADI: Ali Kutay KILINÇ
**				ÖĞRENCİ NUMARASI: b201210071
**				DERS GRUBU: B grubu 1. Öğretim
****************************************************************************/

#include <iostream>
#include <locale.h>// Türkçe karakter kullanımı için

using namespace std;

//Girilen zaman değerindeki ":"yı zaman değerinden ayırmak için
char ikiNokta = ':';

struct Zaman
{
    int saat;
    int dakika;
    int saniye;
    long toplam_saniye;
};

int main()
{
    setlocale(LC_ALL, "Turkish");

    cout << "Saat:Dakika:Saniye şeklinde zamanı giriniz:";

    Zaman girilen;
    cin >> girilen.saat >> ikiNokta >> girilen.dakika >> ikiNokta >> girilen.saniye;

    //Girilen "saat:dakika:saniye"nin doğru aralıkta olup olmadığını kontrol edip daha sonra içerde de hangilerinde hata olduğunu bulup bildiriyor. Hem de"PROGRAM sonu."nu yazdırmak için else ifadesinden ayırıyor.
    if (!(0 <= girilen.saat && girilen.saat < 24 && 0 <= girilen.dakika && girilen.dakika < 60 && 0 <= girilen.saniye && girilen.saniye < 60))
    {
        if (!(0 <= girilen.saat && girilen.saat < 24))
        {
            cout << "Girilen saat değeri " << girilen.saat << " yanlış girilmiştir." << endl;
        }


        if (!(0 <= girilen.dakika && girilen.dakika < 60))
        {
            cout << "Girilen dakika değeri " << girilen.dakika << " yanlış girilmiştir." << endl;
        }


        if (!(0 <= girilen.saniye && girilen.saniye < 60))
        {
            cout << "Girilen saniye değeri " << girilen.saniye << " yanlış girilmiştir." << endl;
        }
        cout << "PROGRAM sonu." << endl;
    }
    else //Girilen değerlerde yanlışlık yoksa buradan devam ediyor. Girilen değeri ve toplam saniyeyi ekran çıktısı olarak veriyor. Hem de örneğin 1:1:1 olarak girilen değeri 01:01:01 olarak düzelterek ekran çıktısı veriyor.
    {
        girilen.toplam_saniye = girilen.saat * 3600 + girilen.dakika * 60 + girilen.saniye;

        string saatDüzeltici;
        string dakikaDüzeltici;
        string saniyeDüzeltici;

        //Tek basamak girilen değerlerin çıktısında yanınna '0' koyarak düzeltiyor. Sayı üst satırlardan bu satıra negatif olarak  gelemeyeceği için negatifliği tekrar kontrol edilmiyor.
        //Önce saat dakika saniye fark etmeksizin  tek basamaklı olup olmadığına bakılıyor. Daha sonra içerdeki kontroller sonrasında hangisinin tek basamaklı olup yanına "0" konarak düzeltilmesi gerektiğini belirleniyor.
        if ((girilen.saat < 10) || (girilen.dakika < 10) || (girilen.saniye < 10))
        {
            if (girilen.saat < 10)
            {
                saatDüzeltici = "0";
            }
            if (girilen.dakika < 10)
            {
                dakikaDüzeltici = "0";
            }
            if (girilen.saniye < 10)
            {
                saniyeDüzeltici = "0";
            }
            cout << saatDüzeltici << girilen.saat << ":" << dakikaDüzeltici << girilen.dakika << ":" << saniyeDüzeltici << girilen.saniye << '\n' << "Saniye olarak hesaplana değerler:" << girilen.toplam_saniye << endl;
        }
        //Tek basamak girilen değer yoksa düzelteme yapılmadan çıktı veriliyor. 
        else
            cout << girilen.saat << ":" << girilen.dakika << ":" << girilen.saniye << '\n' << "Saniye olarak hesaplana değerler:" << girilen.toplam_saniye << endl;
    }
    system("pause");
    return 0;
}