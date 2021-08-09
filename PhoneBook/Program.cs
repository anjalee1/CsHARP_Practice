using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "PHONEBOOK CONSOLE";
           
            Console.ForegroundColor = ConsoleColor.DarkRed;
           
            Console.WriteLine();
            
            Console.WriteLine("                                      MY PHONEBOOK");
            Console.WriteLine();

            Console.WriteLine("                      SELECT OPERATION:");
            Console.WriteLine("                           1.ADD CONTACT");
            Console.WriteLine("                           2.DISPLAY CONTACT BY NUMBER");
            Console.WriteLine("                           3.VIEW ALL CONTACTS");
            Console.WriteLine("                           4.SEARCH FOR CONTACTS FOR A GIVEN NAME");
            Console.WriteLine("                           5.PRESS E TO EXIT");

            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Enter Your Choice:");

            var UserInput = Console.ReadLine();
            var ContactOperations = new ContactOperations();

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                switch (UserInput)
                {
                    case "1":
                        Console.Write("Contact Name:");
                        var name = Console.ReadLine();
                        Console.Write("Contact Number:");
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
                Console.Title = "PHONEBOOK CONSOLE";
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("Enter Your Choice:");
                UserInput = Console.ReadLine();
                Console.Title = "My PHONEBOOK";
            }
        }
    }
}
