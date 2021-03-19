using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;
            person1.FirstName = "Derin";
            //person1'in adını Derin yaptığımda person2'nin de adı Derin olarak değişir.

            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "1234567890";

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            //eğer customer = employee yazsaydım hata verirdi.
            //Çünkü ikisi farklı tipler olduğu için birbirine atayamam.Ama personı customera atayabilirim 
            //çünkü customer da bir person.

            Person person3 = customer;
            customer.FirstName = "Ahmet";
            Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);
           
            //normalde person3 yazdığımızda CreditCardNumber çıkmaz ama bu şekilde paranteze alarak yazarsak ulaşabiliriz.

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
            
            //buraya employee yerine customer da person da yazabilirdim.
        }
    }

    class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


    }
    //base class : Person 
    class Customer:Person
    {
        //inheritance
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person 
    {
        //inheritance
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            //eğer add parametresine Customer customer yazsaydım sadece customer atayabilirdim 
            //aynı şekilde Employee employee yazsaydım sadece employee ataybilirdim.
            //Ama Person person atarsam hem person hem customer hem de employee atayabilirim.
           
            Console.WriteLine(person.FirstName);
            
            //aynı kodu farklı nesneler için çalıştırmama imkan sundu.
            //person customerın da employeenin de adresini tutabiliyor.
        }
    }
}

