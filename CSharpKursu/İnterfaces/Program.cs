using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //IPerson person = new IPerson(); interfaceleri newleyemem yani ondan nesne olusturamam!!!  Ama IPerson person = new Customer(); yapabiliriz.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());


            Console.ReadLine();
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            // manager.Add(new Customer { Id=1,FirstName="Engin",Address="Ankara"}); diyerek de Customer nesnesini tanımlayabilirdik
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Engin",
                Address = "Ankara"
            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "Derin",
                LastName = "Demiroğ",
                Department = "Computer Sciences"

            };
            manager.Add(student);
            manager.Add(customer);
        }

        interface IPerson// soyut nesne 
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }

        }
        class Customer : IPerson// somut nesne 
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Address { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Department { get; set; }
        }
        class Worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Department { get; set; }
        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
