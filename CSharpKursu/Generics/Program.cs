using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);// Count property sadece read only'dir. get var yani sadece 


            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
            
        }
    }
    class MyList<T>// generic class T demek herhangi bir türden yazabiliriz demek Type
    {
        T[] _array;// List'ler de array bazlıdır.
        T[] _tempArray;// veriler kaybolmasın diye olusturdugumuz geçici array 
        public MyList()
        {
            _array = new T[0]; 
        }
        public void Add(T item)
        {
            _tempArray= _array;//  _tempArray _array'ın referansını tutar.
            _array = new T[_array.Length + 1];// dizilerin eleman sayısını arttırmak için new'lemek gerekmektedir ancak new'leyince dizinin bütün elemanları silinir.
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length-1] = item;
        }

        private int _count;

        public int Count
        {
            get { return _array.Length; }
        }
    }
}