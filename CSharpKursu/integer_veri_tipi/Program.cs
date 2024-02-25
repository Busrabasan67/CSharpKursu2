using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integer_veri_tipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            int number1 = 10;
            long number2 = 2147483647;
            short number3 = -32768;
            byte number4 = 255; //0-255 arası veri tutar.
            bool condition = false;
            char character = 'A';
            double number5 = 10.4;
            decimal number6 = 10.4m; //ondalıklı sayı yazdıgımızda sonuna m veya M yazmalıyız.
            var number7 = 10;
            number7 = 'A';
            //number7="A";
            Console.WriteLine("Number1 is {0}",number1); // buradaki {0} virgülden ilk değeri yazdırır. 1 oldugunda ikinci değeri yazdırır.
            Console.WriteLine("Number2 is {0}",number2);//int aralıgının 2 katı değer alabilir.
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Character is {0}",(int)character);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();

        }
    }
    enum Days
    {
        Monday=1,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday //enum sabitleri 0'dan baslar ancak biz bunları değiştirebiliriz.
    }
}
