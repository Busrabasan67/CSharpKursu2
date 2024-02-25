using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            // IPersonManager personManager = new IPersonManager(); BUNU YAZAMAYIZZZZZ  zaten interface içindeki metodun içi bos onu nasıl kullanıcaz 
            //interface new'lenemez.

            //IPersonManager customerManager = new CustomerManager();// interface onu implemente eden sınıfın referansını tutabilir.


            // IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());

        }
    }

    interface IPersonManager// interfaceler bize şablon olusturur.
    {
        //unimplemented operation interface'leri kullanma amacımız içindeki metodun içini değiştirip farklı sınıflar için kullanabiliriz.
        void Add();
        void Update();
    }

    //inherits-class----------------------> implements-interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //musteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");

        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel eklendi");

        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {

            personManager.Add();
        }

    }
}
