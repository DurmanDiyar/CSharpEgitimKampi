using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            ////double number;
            ////number = 4.85;
            ////Console.WriteLine(number);
            //Console.WriteLine("***** Fiyat Listesi ****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 35.09;
            //strawberryPrice=11.23;
            //patatoPrice = 4.4;
            //tomatoPrice = 9.5;

            //Console.WriteLine("-----Elma Birim Fiyatı :"+applePrice+" TL");
            //Console.WriteLine("-----Portakal Birim Fiyatı :"+orangePrice+" TL");
            //Console.WriteLine("-----Çilek Birim Fiyatı :"+strawberryPrice+" TL");
            //Console.WriteLine("-----Patates Birim Fiyatı :"+patatoPrice+" TL");
            //Console.WriteLine("-----Domates Birim Fiyatı :"+tomatoPrice+" TL");

            //double appleGram, orangeGram, strawGram, patatoGram, tomatoGram;
            //appleGram = 1.234;
            //orangeGram = 2.456;
            //strawGram = 5.345;
            //patatoGram = 3.587;
            //tomatoGram = 0.500;

            //double totalApplePrice=applePrice*appleGram;
            //double totalOrangePrice=orangePrice*orangeGram;
            //double totalStrawPrice=strawGram*strawberryPrice;
            //double totalTomatoPrice=tomatoPrice*tomatoGram;
            //double totalPotatoPrice=patatoPrice*patatoGram;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alınan ürün : Elma - "+"Birim Fiyatı: "+applePrice+" -Gramaj: "+appleGram+" -Toplam Tutar :"+totalApplePrice);
            //Console.WriteLine("Alınan ürün : Çilek - "+"Birim Fiyatı: "+strawberryPrice+" -Gramaj: "+strawGram+" -Toplam Tutar :"+totalStrawPrice);
            //Console.WriteLine("Alınan ürün : Portakal - "+"Birim Fiyatı: "+orangePrice+" -Gramaj: "+orangeGram+" -Toplam Tutar :"+totalOrangePrice);
            //Console.WriteLine("Alınan ürün : Patates - "+"Birim Fiyatı: "+patatoPrice+" -Gramaj: "+patatoGram+" -Toplam Tutar :"+totalPotatoPrice);
            //Console.WriteLine("Alınan ürün : Patates - "+"Birim Fiyatı: "+tomatoPrice+" -Gramaj: "+tomatoGram+" -Toplam Tutar :"+totalTomatoPrice);

            //double shoppingTotalPrice = totalTomatoPrice + totalApplePrice + totalOrangePrice + totalStrawPrice + totalPotatoPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Toplam Alışveriş Ücreti :" + shoppingTotalPrice + " Tl");
            #endregion
            #region Char Değişkenler
            // Karekter değişkenlerinin tutmamıza olanak sağlar
            //char symbol;
            //symbol = 'a';
            #endregion
            #region klavyeden veri Girişleri
            //Console.WriteLine("*****CSharp Hava Yolları Yolcu Bilgisi****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,
            //    passengerIdentitiyNumber;

            //Console.Write("Yolcu Adı :"); passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı :"); passengerSurname = Console.ReadLine();
            //Console.Write("Yolcu İlçe Bilgisi :"); passengerDistrict = Console.ReadLine();
            //Console.Write("Yolcu Şehir Bilgisi :"); passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaş Bilgisi :"); passengerAge = Console.ReadLine();
            //Console.Write("Yolcu Tc Kimlik No Bilgisi :"); passengerIdentitiyNumber = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //Console.Write("Yolcu Tc kimlik Numarası: "+passengerIdentitiyNumber+" Yolcu:" + passengerName + " " + passengerSurname+" "
            //    +passengerDistrict+"/"+passengerCity+" "+passengerAge);


            #endregion
            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler 
            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 4000;
            //chairPrice = 6000;
            //tvPrice = 1500;

            //int shoeCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen Aldığınız Ayakkabı Adetini Giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Bilgisayar Adetini Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Sandalye Adetini Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız tv Adetini Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=(shoeCount*shoePrice)+(tvCount*tvPrice)+(computerCount*computerPrice)+(chairCount*chairPrice);
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Miktar => "+totalPrice);

            #endregion
            #region Klavyeden Ondalıklı sayı Girişleri ve Dönüşümleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunuzu Giriniz: "); exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.Sınav Notunuzu Giriniz: "); exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3.Sınav Notunuzu Giriniz: "); exam3 = double.Parse(Console.ReadLine());
            //result = (exam1 + exam3 + exam2) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız : "+result);
            #endregion
            #region Klavyeden Karekter Girişleri
            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender=char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiginiz Cinsiyet :"+gender);
            #endregion


            Console.ReadLine();

        }
    }
}
