using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MetotOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //NoReturn();




            /*
            int sonuç = RastGele(); // 
            Console.WriteLine("Rastgele sayinin 2 ile kalanı :{0}",sonuç);
            */




            /*
            decimal sayi1 = 20; //parametre alarak iki sayının değerini dönme
            decimal sayi2 = 4;

            decimal sonuç = ParametreAlan(sayi1, sayi2);//Metodun alacagı parametreleri giriyoruz ve gelen değeri sonuç değişkeninde tutuyoruz.

            Console.WriteLine("Çarpma işleminin sonucu :{0}",sonuç);
            */



           

            Console.WriteLine("İsminizi giriniz :");
            string isim=Console.ReadLine();

            Console.WriteLine("Soyisminizi giriniz :");
            string soyİsim=Console.ReadLine();

            AdSoyad(isim,soyİsim);//AdSoyad metoduna parametreleri gonderiyoruz.

           


            Console.ReadLine();
        }





        /*
        public static void NoReturn()//geriye  herhangi bir değer donmeyeceğimiz için parantez içini boş bırakıyoruz.
        {
            Console.WriteLine("Geriye değer donmeyen metot");
        }
        */


        /*
        public static int RastGele()//rastgele sayinin 2 ile kalanı
        {
            Random rastgele = new Random(); //metoduyla rastgele sayimizi alıyoruz
            int sayi = rastgele.Next(1, 101);//Gelen Rastgele sayiyi,sayi değişkenine atıyoruz

            int kalan = sayi % 2;  // Ardından 2 ile kalanını , kalan değişkenine atıyoruz

            Console.WriteLine("Rastgelen sayi :{0}",sayi);
            return kalan;//kalanı return ederek main metoduna gonderiyoruz.
        }
        */



        /*
        public static decimal ParametreAlan(decimal s1 , decimal s2)//Main metodundan gelecek olan değerleri tutması için iki tane parametre gitiyoruz
        {
            return s1*s2;//Gelen iki parametrenin değerinin çarpımını return ediyoruz.
        }

        */


        
        public static void AdSoyad(string ad,string soyad)//Main metodundan gelecek olan parametreleri string değişkeninde alıyoruz
        {
            Console.WriteLine("Hoş geldiniz {0} {1}",ad,soyad);//Gelen değerleri ekrana bastırma.
        }
           


    }
}
