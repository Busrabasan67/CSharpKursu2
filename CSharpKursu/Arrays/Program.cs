using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            //string[] students = new string[3] {"Engin", "Derin", "Salih"}; seklinde de yazılabilir
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            string[] students2 = new[] {"Engin", "Derin", "Salih"};
            //string[] students2 = {"Engin", "Derin", "Salih"}; new siz de yazabilirim


            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            //Cok boyutlu diziler
            string[,] regions = new string[5, 3]// 5 satır 3 sutun satırı sayarken 0'ı saymayız.
            {
                {"İstanbul","İzmit","Balıkesir"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Manisa" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++) // bu GetUpperBound() fonk. ilgili dimensionı alırsın. 0 satırlar ,1 sutunlar için
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("*********************");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
