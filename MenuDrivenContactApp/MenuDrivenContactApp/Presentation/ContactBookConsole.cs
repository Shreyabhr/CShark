using MenuDrivenContactApp.Model;
using System;

namespace MenuDrivenContactApp.Presentation
{
    class ContactBookConsole
    {
        public ContactBookConsole()
        {
            ContactBook book = new ContactBook();
            Console.WriteLine("1) Add contact\n2) Display Contact\n3)exit");
            int choice = 0;
            while (choice != 3)
            {
                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter contact no: ");
                        long contact;
                        try
                        {
                            contact = long.Parse(Console.ReadLine());
                            book.CreateContact(contact);
                        }
                        catch
                        {
                            Console.WriteLine("Please enter a number.....");
                            continue;
                        }
                        break;
                    case 2:
                        string[] contacts = book.GetContact();
                        foreach(string item in contacts)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                }
            }
        }
    }
}
