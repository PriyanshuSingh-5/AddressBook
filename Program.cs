using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book");
            ContactDetails person = new ContactDetails("Priyanshu", "Singh", "yercaud", "Salem", "TamilNadu", "636601", "9003530893", "priyanshuSVS2015@gmail.com");

            Console.WriteLine(person.getName());
            Console.WriteLine(person.getlastName());
            Console.WriteLine(person.getaddress());
            Console.WriteLine(person.getcity());
            Console.WriteLine(person.getstate());
            Console.WriteLine(person.getzip());
            Console.WriteLine(person.getphone());
            Console.WriteLine(person.getemail());
            Console.Read();

        }
    }
}
