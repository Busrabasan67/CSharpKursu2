using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {//DON'T REPEAT YOURSELF Principle
            //Add();
            //Add();
            //Add();
            //var result = Add2(4);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(out number1, number2);

            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!!!");
        }
        static int Add2(int x, int number1 = 20, int number2 = 30)// default değerler en sonda olur!!!
        {
            var result = number1 + number2;
            return result;
        }


        static int Add3(out int number1, int number2)//ref (referansını) kullandık.
        {
            number1 = 30;// out'un ile ref'ten farkı number1'ı daha önce tanımlamamız gerekmemektedir ve mutlaka fonk. içinde yeniden bir değer atamalıyız.ref te ise mutlaka number1 daha önceden tanımlanmalıdır.
            return number1 + number2;

        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3) // method overloading
        {
            return number1 * number2 * number3;
        }

        static int Add4(int number,params int[] numbers) // params keyword'u ile istedigin kadar parametre kullanabilirsin.Params keywordunu en sona yazarız.
        {
            return numbers.Sum();
        }
    }
}
