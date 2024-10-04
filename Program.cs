using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;

            //number = 4.87;

            //Console.WriteLine(number);

            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //double applePrice, potatoPrice, tomatoPrice, strawberryPrice, orangePrice;
            //applePrice = 35.56;
            //potatoPrice = 19.54;
            //tomatoPrice = 30.25;
            //strawberryPrice = 65.20;
            //orangePrice = 20.45;

            //Console.WriteLine("---- Elma Fiyatı: " + applePrice);
            //Console.WriteLine("---- Domates Fiyatı: " + tomatoPrice);
            //Console.WriteLine("---- Portakal Fiyatı: " + orangePrice);
            //Console.WriteLine("---- Çilek Fiyatı: " + strawberryPrice);
            //Console.WriteLine("---- Patates Fiyatı: " + potatoPrice);

            //Console.WriteLine();
            //Console.WriteLine();


            //double appleGram, potatoGram, tomatoGram, strawberryGram, orangeGram;
            //appleGram = 1.350;
            //potatoGram = 2.690;
            //tomatoGram = 3.000;
            //strawberryGram = 1.000;
            //orangeGram = 3.500;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;

            //Console.WriteLine("Alınan Ürün: Elma - Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " Toplam Tutar: " + appleTotalPrice + " TL ");
            //Console.WriteLine("Alınan Ürün: Portakal - Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " Toplam Tutar: " + orangeTotalPrice + " TL ");
            //Console.WriteLine("Alınan Ürün: Domates - Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " Toplam Tutar: " + tomatoTotalPrice + " TL ");
            //Console.WriteLine("Alınan Ürün: Patates - Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " Toplam Tutar: " + potatoTotalPrice + " TL ");
            //Console.WriteLine("Alınan Ürün: Çilek - Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " Toplam Tutar: " + strawberryTotalPrice + " TL ");

            //Console.WriteLine();
            //Console.WriteLine();


            //double shoppingTotalPrice = orangeTotalPrice + tomatoTotalPrice + strawberryTotalPrice + appleTotalPrice + potatoTotalPrice;
            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice);



            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF.....
            // '

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);



            #endregion

            #region Klavyede Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistric, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistric = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Tc Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Yolcu Tc Kimlik No: " + passengerIdentityNumber + " Yolcu Adı Soyadı:  " + passengerName + " " + passengerSurname + " " + passengerDistric + " / " + passengerCity + " " + passengerAge);




            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC12R

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 14500;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını girin: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını girin: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını girin: ");
            //tvCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını girin: ");
            //chairCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairPrice * chairCount + tvPrice * tvCount;
            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar: "+ totalPrice);



            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu Girin: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu Girin: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu Girin: ");
            //exam3 = double.Parse(Console.ReadLine());


            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.Write("Sınav Notu Ortalaması: "+result);



            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçin: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);



            #endregion



            Console.Read();




        }
    }
}
