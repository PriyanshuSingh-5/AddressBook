using System;

namespace AddressBook
{
    class Program
    {
        public static Dictionary<string, AddressBook2> MapAddressBook = new Dictionary<string, AddressBook2>();
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address book using console Apllication");

            int choice;
            string name;
            do
            {
                Console.WriteLine("\nOptions : \n 1.Add New Address Book \n 2.Work On Existing Address Book \n 3.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Name of Address Book");
                        name = Console.ReadLine();
                        MapAddressBook.Add(name, new AddressBook2());
                        break;
                    case 2:
                        Console.WriteLine("Enter the Name of Address Book in which you want to Work On");
                        name = Console.ReadLine();
                        AddressBook2 addressBook = MapAddressBook[name];
                        FillAddressBook(addressBook);
                        break;
                    case 3:
                        Console.WriteLine("====Thankyou!!! Have A Nice Day(*_*)===== ");
                        break;
                    default:
                        Console.WriteLine("sorry worng input");
                        break;
                }
            } while (choice != 3);
        }
            public static void FillAddressBook(AddressBook2 addressBook)
            {
                
             Console.WriteLine("-------------Welcome to Address Book Program------------ ");
            AddressDetails addressBook = new AddressDetails();
            int Choice=Convert.ToInt32(Console.ReadLine());
            do
            {

            Console.WriteLine("Enter First Name :");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name :");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Address :");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City :");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State :");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Email :");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Zip :");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number :");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            addressBook.AddContact(firstName, lastName, address, city, state, email, zip, phoneNumber);
                
                
                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("Enter First Name Of Contact To Edit :");
                        string nameToEdit = Console.ReadLine();
                        addressBook.EditContact(nameToEdit);
                        break;
                    case 2:
                        Console.WriteLine("Enter First Name Of Contact To Delete :");
                        string nameToDelete = Console.ReadLine();
                        addressBook.DeleteContact(nameToDelete);
                        break;
                    case 3:
                        Console.WriteLine("Enter First Name Of Contact To View :");
                        string nameToView = Console.ReadLine();
                        addressBook.ViewContact();
                        break;
                    case 4:
                        addressBook.ViewContact();
                        break;
                    case 5:
                        Console.WriteLine("It is Not Found Any Information.");
                        break;
                }
            } while (Choice != 5);
        }

    }
    }
