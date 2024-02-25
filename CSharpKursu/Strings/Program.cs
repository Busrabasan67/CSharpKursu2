using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Engin Demiroğ";
            var result= sentence.Length;
            var result2= sentence.Clone();// Clone fonk. string değerin referansını klonlar ve yeni bir değişken olusturur.
            sentence = "My name is Derin Demiroğ";

            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My name ");

            var result5 = sentence.IndexOf("name");// girilen karakterin kacıncı indexte oldugunu arar. karakter bulunmazsa -1 döndürür. buldugu ilk karakterin indexini döndürür.
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");// aramaya sondan baslar.
            var result8 = sentence.Insert(0,"Hello, ");// 0. indexten itibaren cumleye ekle.
            var result9 = sentence.Substring(3,4); // stringi ayırmak için kullanılır. 3. indexten itibaren  4 karakter ayır.
            var result10 = sentence.ToLower();
            var result11=sentence.ToUpper();
            var result12 = sentence.Replace(" ","-");// metin içinde belli karakterlerin yerine baska karakterle değiştirme
            var result13 = sentence.Remove(2,4);// 2.indexten itibaren 4 karakter sil
            Console.WriteLine(result13);
            Console.ReadLine();


        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city) // stringler de aslında karakter dizisi old. icin bu sekilde her bir karakterine erisebiliriz.
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            //string result = city + city2; // stringleri toplama(birleştirme)

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
