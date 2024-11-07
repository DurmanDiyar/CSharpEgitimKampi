using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        // Komutlarımızı Mainin içine yazarız
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            // Mor Renkli Küp bize Metot oldugunu belirtir

            ////Write imleci cümlenin Sonuna ekler 
            //Console.Write("Hello World");
            //// WriteLine imleci alt Satıra Ekler
            //Console.WriteLine("selamm");

            // ctrl+d yaparak satırı alta kopyalar

            //Console.WriteLine("******** Yemek Kategorileri*******");

            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Salatlar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");

            #endregion
            #region String  Degişkenler

            //// String 
            //// Değişken_Türü Değişken_Adı

            ////string name;
            ////name = "Diyar";
            ////Console.WriteLine(name);


            ////camelCase=Birinci kelime küçükm ikinci kelime büyük harf ile başlar

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail,district,city;

            //customerName = "Diyar";
            //customerSurname = "Durman";
            //customerPhone = "05466129274";
            //customerEmail = "diyardurman61@gmail.com";
            //district = "Marmaraereğlisi";
            //city = "Tekirdağ";

            //Console.WriteLine("****** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("Müşteri: "+customerName+" "+customerSurname);
            //Console.WriteLine("İleştişim: "+customerPhone);
            //Console.WriteLine("Email Adresi: "+customerEmail);
            //Console.WriteLine("Adres:" +district+"/"+city);
            #endregion

            #region Integer Değişkenler 
            //int 

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;

            Console.WriteLine("********* Restoran Menü Fiyatı");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: "+hamburgerPrice+" Tl");
            Console.WriteLine("-----Pizza: "+pizzaPrice+" Tl");
            Console.WriteLine("-----Kola: "+cokePrice+" Tl");
            Console.WriteLine("-----Kızartma: "+friesPrice+" Tl");
            Console.WriteLine("-----su: "+waterPrice+" Tl");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 2;
            pizzaCount = 2;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice= pizzaCount * pizzaPrice;
            totalWaterPrice= waterCount * waterPrice;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Hamburger Tutarı: "+totalHamburgerPrice+" Tl" );
            Console.WriteLine("Pizza Tutarı: "+totalPizzaPrice+" Tl" );
            Console.WriteLine("Kola Tutarı: "+totalCokePrice+" Tl" );
            Console.WriteLine("Kızartma Tutarı: "+totalFriesPrice+" Tl" );
            Console.WriteLine("Su Tutarı: "+totalWaterPrice+"  Tl" );
            #endregion



            //Entere tıklanana kadar ekranda beklenmesini sağlar
            Console.Read();
        }
    }
}
