using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? sayi1=30 sayi2=65 cevap=30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? cevap = 999
            //sayilar1 = 100,200,300
            //sayilar2 = 999,200,300
            //sayilar1 = 999,200,300
            //pointer
            //garbage collector --> çöp toplayıcı


            //NOT: int,double,float,boolean,decimal = değer tiptir
            //array, class, interface = referans tiptir
        }
    }
}
