// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1-Sipariş numarasını girin (1-4 arasında bir sayı):");
        Console.WriteLine("2-Kaç ürün almak istiyorsunuz?");
        Console.WriteLine("3-Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.");
        Console.WriteLine("4-Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.");
        Console.WriteLine("5-String metotlarını araştırınız. Her bir metot için örnek yapınız.");
        Console.WriteLine("6-Bir mağazada alınan ürünün fiyatı 300 TL üzerinde ise 50 TL olan kargo ücreti alınmamaktadır. Ürünün fiyatı girildiğinde toplam ödemesi gereken tutarı gösteren programı yazınız.");
        Console.WriteLine("7-İki ürünün kullanıcı tarafından fiyatı girildiğinde toplam fiyat 500 TL'den fazla ise 2.üründen %40 indirim yaparak ödenecek tutarı gösteren uygulamayı yazınız.");
        Console.WriteLine("8-1-200 arası içinde 3'e veya 5'e tam bölünebilen sayıları listeleyen ve kaç adet olduğunu yazdıran programı yazınız.");

        Console.WriteLine("Seçiminizi yapın:");

        //1-Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.

        int secim = Convert.ToInt32(Console.ReadLine());

        switch (secim)
        {
            case 1:
                SiparisUrunBelirle();
                break;
            case 2:
                UrunFiyatiHesapla();
                break;
            case 3:
                DonguOrnekleri();
                break;
            case 4:
                MukemmelSayiKontrolu();
                break;
            case 5:
                StringMetotOrnekleri();
                break;
            case 6:
                KargoUcretiHesapla();
                break;
            case 7:
                IndirimliOdemeTutari();
                break;
            case 8:
                TamBolunenSayilar();
                break;
            default:
                Console.WriteLine("Geçersiz seçim!");
                break;
        }

        Console.ReadLine();
    }

    static void SiparisUrunBelirle()
    {
        Console.WriteLine("Sipariş numarasını girin (1-4 arasında bir sayı):");
        int siparisNumarasi;
        if (!int.TryParse(Console.ReadLine(), out siparisNumarasi) || siparisNumarasi < 1 || siparisNumarasi > 4)
        {
            Console.WriteLine("Geçersiz sipariş numarası");
            return;
        }

        string urun = "";
        switch (siparisNumarasi)
        {
            case 1:
                urun = "Bilgisayar";
                break;
            case 2:
                urun = "Telefon";
                break;
            case 3:
                urun = "Tablet";
                break;
            case 4:
                urun = "Yazıcı";
                break;
            default:
                Console.WriteLine("Geçersiz sipariş numarası");
                return;
        }

        Console.WriteLine($"Sipariş edilen ürün: {urun}");
    }
    //2-kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.(döngü için for döngüsü kullanınız)
    static void UrunFiyatiHesapla()
    {
        Console.WriteLine("Kaç ürün almak istiyorsunuz?");
        int urunSayisi = Convert.ToInt32(Console.ReadLine());

        double toplamTutar = 0;

        for (int i = 1; i <= urunSayisi; i++)
        {
            Console.WriteLine($"Ürün {i} için fiyatı girin:");
            double urunFiyati = Convert.ToDouble(Console.ReadLine());
            toplamTutar += urunFiyati;
        }

        Console.WriteLine($"Toplam alışveriş tutarı: {toplamTutar:C2}");
    }
    //3- Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.
    static void DonguOrnekleri()
    {
        int sayac = 1;

        // Do-While döngüsü
        do
        {
            Console.WriteLine("Do-While Döngüsü - Sayac: " + sayac);
            sayac++;
        } while (sayac <= 5);
    }
    //4- Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.
    static void MukemmelSayiKontrolu()
    {
        Console.WriteLine("Bir sayı girin:");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int toplam = 0;

        for (int i = 1; i < sayi; i++)
        {
            if (sayi % i == 0)
            {
                toplam += i;
            }
        }

        if (toplam == sayi)
        {
            Console.WriteLine($"{sayi} mükemmel bir sayıdır.");
        }
        else
        {
            Console.WriteLine($"{sayi} mükemmel bir sayı değildir.");
        }
    }
    //5- String metotlarını araştırınız. Her bir metot için örnek yapınız.
    static void StringMetotOrnekleri()
    {
        string metin = "Merhaba";
        int uzunluk = metin.Length; // uzunluk değişkeni 7 değerini alır
        Console.WriteLine("Uzunluk: " + uzunluk);

        string buyukHarfliMetin = metin.ToUpper(); // buyukHarfliMetin değişkeni "MERHABA" değerini alır
        Console.WriteLine("Büyük Harfli Metin: " + buyukHarfliMetin);

        string kucukHarfliMetin = metin.ToLower(); // kucukHarfliMetin değişkeni "merhaba" değerini alır
        Console.WriteLine("Küçük Harfli Metin: " + kucukHarfliMetin);

        string altDize = metin.Substring(3, 5); // altDize değişkeni "haba " değerini alır
        Console.WriteLine("Alt Dize: " + altDize);

        string metin2 = "Merhaba Dünya";

        // "Merhaba" alt dizesini içerip içermediğini kontrol etme
        bool icermiyorMu = !metin2.Contains("Merhaba"); // false olacak, çünkü "Merhaba" metinde bulunuyor
        Console.WriteLine("Metin 'Merhaba' içermiyor mu? " + icermiyorMu);

        // "Selam" alt dizesini içerip içermediğini kontrol etme
        bool icermiyorMu2 = !metin2.Contains("Selam"); // true olacak, çünkü "Selam" metinde bulunmuyor
        Console.WriteLine("Metin 'Selam' içermiyor mu? " + icermiyorMu2);
    }
    //6- Bir mağazada alınan ürünün fiyatı 300 tl üzerinde ise 50 tl olan kargo ücreti alınmamaktadır. ürünün fiyatı girildiğinde toplam ödemesi gereken tutarı gösteren programı yazınız.
    static void KargoUcretiHesapla()
    {
        Console.WriteLine("Ürün fiyatını girin:");
        double urunFiyati = Convert.ToDouble(Console.ReadLine());

        double toplamTutar;

        if (urunFiyati > 300)
        {
            // Ürün fiyatı 300 TL'den büyükse kargo ücreti alınmaz
            toplamTutar = urunFiyati;
        }
        else
        {
            // Ürün fiyatı 300 TL veya daha azsa 50 TL kargo ücreti eklenir
            toplamTutar = urunFiyati + 50;
        }

        Console.WriteLine($"Toplam ödemeniz gereken tutar: {toplamTutar:C2}");
    }
    //7- iki ürünün kullanıcı tarafından fiyatı girildiğinde toplam fiyat 500 tl'den fazla ise 2.üründen %40 indirim yaparak ödenecek tutarı gösteren uygulamayı yazınız.
    static void IndirimliOdemeTutari()
    {
        Console.WriteLine("1. Ürünün fiyatını girin:");
        double urun1Fiyati = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("2. Ürünün fiyatını girin:");
        double urun2Fiyati = Convert.ToDouble(Console.ReadLine());

        double toplamTutar = urun1Fiyati + urun2Fiyati;

        if (toplamTutar > 500)
        {
            // Toplam fiyat 500 TL'den fazlaysa, ikinci ürüne %40 indirim yapılır
            double indirimliUrun2Fiyati = urun2Fiyati * 0.6; // %40 indirim (100% - 40%)
            toplamTutar = urun1Fiyati + indirimliUrun2Fiyati;
            Console.WriteLine($"2. Ürüne %40 indirim uygulandı. Ödemeniz gereken tutar: {toplamTutar:C2}");
        }
        else
        {
            Console.WriteLine($"Ödemeniz gereken toplam tutar: {toplamTutar:C2}");
        }
    }
    //8- 1-200 arası içinde 3'e veya 5'e tam bölünebilen sayıları listeleyen ve kaç adet olduğunu yazdıran programı yazınız.
    static void TamBolunenSayilar()
    {
        int toplamSayac = 0;

        Console.WriteLine("1-200 arasında 3'e veya 5'e tam bölünebilen sayılar:");
        for (int i = 1; i <= 200; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                Console.WriteLine(i);
                toplamSayac++;
            }
        }

        Console.WriteLine($"Toplam {toplamSayac} adet sayı bulunmaktadır.");
    }
}



