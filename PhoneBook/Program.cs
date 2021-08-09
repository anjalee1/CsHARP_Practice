using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine();
            Console.WriteLine("                                      MY PHONEBOOK");
            Console.WriteLine();

            Console.WriteLine("                       SELECT OPERATION:");
            Console.WriteLine("                           1.ADD CONTACT");
            Console.WriteLine("                           2.DISPLAY CONTACT BY NUMBER");
            Console.WriteLine("                           3.VIEW ALL CONTACTS");
            Console.WriteLine("                           4.SEARCH FOR CONTACTS FOR A GIVEN NAME");
            Console.WriteLine("                           PRESS E TO EXIT");
            var UserInput = Console.ReadLine();
            var ContactOperations = new ContactOperations();

            while (true)
            {
                switch (UserInput)
                {
                    case "1":
                        Console.WriteLine("Contact Name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact Number:");
                        var number = Console.ReadLine();

                        var newContact = new ContactDetails(name, number);
                        ContactOperations.AddContact(newContact);
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "E":
                        return;
                    default:
                        Console.WriteLine("Select Valid Operation");
                        break;


                        
                }
                Console.WriteLine();
                UserInput = Console.ReadLine();
                Console.Write("SELECT OPERATION:");
                UserInput = Console.ReadLine();
            }
        }
    }
}
