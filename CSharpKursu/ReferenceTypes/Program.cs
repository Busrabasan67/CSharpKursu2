using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //// int,decimal,float,enum,boolean value types(değerini kopyalar) Stack'te çalışır.
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;

            //sayi2 = 100;

            //Console.WriteLine("Sayı 1: " + sayi1);


            ////arrays,class,interface.... reference types  new diyince Heap 'te  bu reference type'lerin adresiyle içeriğini tutar.

            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;// sayilar1'in adresi eşittir sayilar2'nin adresini tutar
            //sayilar2[0] = 1000;

            //Console.WriteLine("Sayılar1[0]: " + sayilar1[0]);


            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;// person2'nin adresi eşittir person1'in adresine
            person1.FirstName = "Derin";

            Console.WriteLine(person2.FirstName);




            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "1234567890";

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            //customer = employee; bunu bu sekilde diyemem ikisi farklı tip oldugu için

            Person person3 = customer;// customer bir persondır. employee bir persondır. base class'lara onu inheritence eden sınıfları atayabiliriz!!!Person customer'ın da employee'nin de adresini tutabiliriz.
            customer.FirstName = "Ahmet";
            // person3.CreditCardNumber diyemeyiz
            // Console.WriteLine(person3.FirstName); yazdırınca ekrana ahmet yazdırır customerın adresine gider.

            Console.WriteLine(((Customer)person3).CreditCardNumber);// artık CreditCardNumber 'a ulasabiliyoruz aslında Customer class referanslı yapmıs oluyoruz.Donusum yapmıs oluyoruz. boxing

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);// bu sayede aynı kodu farklı nesneler için calıstırabiliriz.
        }

    }


    class Person // base class Ebeveyn
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }


    class PersonManager
    {
        public void Add(Person person)// hem customer hem employee hem de person olarak parametre gönderebiliriz. Base class'ı parametre verdiğimiz için
        {
            Console.WriteLine(person.FirstName);
        }
    }

}