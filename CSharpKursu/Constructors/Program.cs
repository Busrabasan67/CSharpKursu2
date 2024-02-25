using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor bir class'ı new'ledğimiz zaman sadece 1 kez calısır bir daha calısmaz.
            Customer customer1 = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };// instance defatult constructor'ı kullanmak
            Customer customer3 = new Customer();// default constructorı cagırır.
            customer3.Id = 3;
            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");


            Console.WriteLine(customer2.FirstName);// bu degeri cagırabilmek için gönderdiğimiz parametreleri property'lere set etmemiz gerekmektedir.
            

        }
        
    }

    class Customer
    {
        public Customer()// customer1 burada calıstı.Function overloading
        {
                
        }
        //default constructor
        public Customer(int id,string firstName,string lastName, string city) // customer2 burada calıstı
        {
            Id = id;
            FirstName= firstName;
            LastName= lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}