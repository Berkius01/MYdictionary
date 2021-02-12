using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //dizi tanımlama c ve c++ ile aynı
            //string[] isimler = new string[] {"engin","murat","kerem","halil"};
            // isimler[0]=engin

            
            List<string> isimler2 = new List<string>();
            isimler2.Add("sucuk");
            
            List<string> isimler2 = new List<string> {"sucuk","salam","sosig"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);

            isimler2.Add("pastırma");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);
            */ 
            //neden böyle yaptık çünkü çalışacağı veri tipini belirledik
            MyDict<string> isimler = new MyDict<string>();
            isimler.Add("ankara");
            isimler.Add("adana");
            isimler.Add("istanbul");
            isimler.Add("izmir");

           //foreach (var isim in isimler.Items)
           // {
           //     Console.WriteLine(isim);
           // }


        }
    }
}
