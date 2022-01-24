using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance8523
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Id = 1,
                FirstName = "Çağıl",
                LastName="Alsaç",
                Department="Yazılım"
            };
            //Person studentPerson1 = new Person();
            Person studentPerson2 = new Student();
            studentPerson2.Id = 2;
            studentPerson2.FirstName = "Leo";
            studentPerson2.LastName = "Alsaç";

            Person p = new Person();
            p = new Student();
            ((Student)p).Department = "Test";
            (p as Student).Department = "Test";

            // Polymorphism
            Person customerPerson1 = new Customer() 
            { 
                Id=3,
                FirstName="Ali",
                LastName="Veli",
                Address="Ankara"
            };
            Person studentPerson3 = new Student()
            {
                Id = 4,
                FirstName="Can",
                LastName="Kan",
                Department="Doktor"
            };

            Person[] people = new Person[3]
            {
                new Person() // 0
                {
                    Id=1,
                    FirstName="Çağıl",
                    LastName="Alsaç"
                },
                new Student() //1
                {
                    Id=2,
                    FirstName="X",
                    LastName="Y",
                    Department="Yazılım"
                },
                new Customer() // 2
                {
                    Id=3,
                    FirstName="X",
                    LastName="Y",
                    Address="Eryaman Ankara"
                }
            };
            foreach(Person person in people) 
            {
                Console.WriteLine("ID: " + person.Id + ", Adı: " + person.FirstName + ", Soyadı: " + person.LastName);
            }
            Customer customerInPeople = people[2] as Customer;
            Console.WriteLine("ID: " + customerInPeople.Id + ", Adı: " + customerInPeople.FirstName + ", Soyadı: " + customerInPeople.LastName + ", Adres: " + customerInPeople.Address);

            Ogrenci ogrenci = new Ogrenci() 
            { 
                Adi="Çağıl",
                Soyadi="Alsaç",
                Ulke=new Ulke() 
                { 
                    Id=1,
                    Adi="Türkiye"
                },
                Sehri=new Sehir() 
                { 
                    Id=1,
                    Adi="Ankara",
                    UlkeId=1
                }
            };
            Console.WriteLine($"Adı: {ogrenci.Adi}, Soyadı: {ogrenci.Soyadi}, Ülkesi: {ogrenci.Ulke.Adi}, Şehri: {ogrenci.Sehri.Adi}");

            Console.ReadLine();
        }
    }
    class Person // (Base , Parent Class , Concrete)
    { 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Student : Person // (Sub , Child Class , Concrete)
    { 
        public string Department { get; set; }
    }
    class Customer : Person // C#'da sadece tek bir class üzerinden miras alınabilir.
    { 
        public string Address { get; set; }
    }
    class CustomerPayment : Customer // is a relationship
    { 
        public string CardNo { get; set; }
    }
    // Is a relationship:
    // Has a relationship:
    class Ogrenci 
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Ulke Ulke { get; set; }
        public Sehir Sehri { get; set; }
    }
    class Ulke
    {
        public int Id { get; set; }
        public string Adi { get; set; }
    }
    class Sehir 
    { 
        public int Id { get; set; }
        public string Adi { get; set; }
        public int UlkeId { get; set; }
    }
}
