using System;
using System.Collections.Generic;
using System.Text;

namespace Day23_AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book System");


            while (true)
            {
                Console.WriteLine("=======================================================================");
                Console.WriteLine("1. Add member to Contact list \n2.View Members in Contact List\n3.Exit");
                Console.WriteLine("Enter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        UC1_AddressBookMain.AddMember();
                        break;
                    case 2:
                        UC1_AddressBookMain.ViewContacts();
                        break;

                    case 3:
                        // to exit from main method
                        Console.WriteLine("Exited");
                        return;

                }
            }
        }
    }
}

