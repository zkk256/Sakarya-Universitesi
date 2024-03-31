/****************************************************************************
**                   SAKARYA ÜNİVERSİTESİ
**         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**              BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**               PROGRAMLAMAYA GİRİŞİ DERSİ
**
**				ÖDEV NUMARASI: Proje
**				ÖĞRENCİ ADI: Ali Kutay KILINÇ
**				ÖĞRENCİ NUMARASI: b201210071
**				DERS GRUBU: B grubu 1. Öğretim
****************************************************************************/
#include <windows.h>
#include <fstream>
#include <iostream>
#include <stdio.h>
#include <string>


using namespace std;

int main(int argc, char* argv[])
{
	int secim1, i = 1;
	int secim2, b = 1;
	string okuyucuAdi;
	string okuyucuSoyadi;
	string uyeNo;
	string telefon;
	string okuyucuDogumTarihi;
	string tc;

	string ISBN;
	string kitapIsmi;
	string yazarAdi;
	string yazarSoyadi;
	string konu;
	string tur;
	string sayfaSayisi;

	string kullaniciAdi;
	string sifre;


	char cevap = 'e';
	do
	{
		cout << "   Ne yapmak istiyorsunuz ? " << endl;
		cout << "   1) Kullanici adimla giris yapmak " << endl;
		cout << "   2) Kayit olmak  " << endl;

		cin >> secim1;
	} while (secim1 != 1 && secim1 != 2);

	if (secim1 == 2)
	{
		ofstream DosyaYaz;
		DosyaYaz.open("Kullanıcılar.txt", ios::app);
		do
		{
			cout << "\n Kullanıci adi:"; cin >> kullaniciAdi;
			cout << "\n Sifre        :"; cin >> sifre;


			DosyaYaz << kullaniciAdi << " " << sifre << "\n";
			cout << "\n baska kayit yapacak misin?(e/h) "; cin >> cevap;
		} while (!(cevap == 'h'));
		DosyaYaz.close();
		cout << "dosyaya yazim tamamlandi. ";
	}

	if (secim1 == 1)
	{
		string KULLANICIADI;
		string SIFRE;
		cout << " Kullanici adi :"; cin >> KULLANICIADI;
		cout << " Sifre :"; cin >> SIFRE;
		ifstream DosyaOku("Kullanıcılar.txt");
		while (!DosyaOku.eof())
		{
			DosyaOku >> kullaniciAdi >> sifre;
			if (KULLANICIADI == kullaniciAdi && SIFRE == sifre)
			{
				do
				{
					cout << "   Ne yapmak istiyorsunuz ? " << endl;
					cout << "   1) Okuyucu kayit ekleme " << endl;
					cout << "   2) Kitap kayit ekleme  " << endl;
					cin >> secim2;
				} while (secim2 != 1 && secim2 != 2);

				if (secim2 == 1)
				{
					ofstream DosyaYaz;
					DosyaYaz.open("Okuyucu.txt", ios::app);
					do
					{
						cout << "\n Okuyucu TC          :"; cin >> tc;
						cout << "\n Okuyucu adi         :"; cin >> okuyucuAdi;
						cout << "\n Okuyucu soyadi      :"; cin >> okuyucuSoyadi;
						cout << "\n Okuyucu uye no      :"; cin >> uyeNo;
						cout << "\n Okuyucu dogum tarihi:"; cin >> okuyucuDogumTarihi;
						cout << "\n Okuyucu telefonu    :"; cin >> telefon;

						DosyaYaz << tc << " " << okuyucuAdi << ' ' << okuyucuSoyadi << ' '
							<< uyeNo << ' ' << okuyucuDogumTarihi << ' ' << telefon << ' '
							<< "\n";
						cout << "\n baska kayit yapacak misin?(e/h) "; cin >> cevap;
					} while (!(cevap == 'h'));
					DosyaYaz.close();
					cout << "dosyaya yazim tamamlandi. ";
				}

				if (secim2 == 2)
				{
					ofstream DosyaYaz;
					DosyaYaz.open("Okuyucu.txt", ios::app);
					do
					{
						cout << "\n ISBN          :"; cin >> ISBN;
						cout << "\n Kitap ismi         :"; cin >> kitapIsmi;
						cout << "\n Yazar adi     :"; cin >> yazarAdi;
						cout << "\n Yazar soyadi      :"; cin >> yazarSoyadi;
						cout << "\n Konu:"; cin >> konu;
						cout << "\n Tur    :"; cin >> tur;
						cout << "\n Sayfa sayisi    :"; cin >> sayfaSayisi;

						DosyaYaz << ISBN << " " << kitapIsmi << ' ' << yazarAdi << ' '
							<< yazarSoyadi << ' ' << konu << ' ' << tur << ' ' << sayfaSayisi
							<< "\n";
						cout << "\n baska kayit yapacak misin?(e/h) "; cin >> cevap;
					} while (!(cevap == 'h'));
					DosyaYaz.close();
					cout << "dosyaya yazim tamamlandi. ";
				}



				system("PAUSE");
				return EXIT_SUCCESS;
			}
		}



	}
}

