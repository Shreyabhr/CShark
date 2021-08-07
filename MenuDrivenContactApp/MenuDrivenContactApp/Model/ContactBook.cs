using System;
using System.IO;

namespace MenuDrivenContactApp.Model
{
    class ContactBook
    {
        string path = "contacts.txt";

        public void CreateContact(long contact)
        {
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }
            AddContact(contact);
        }

        public void AddContact(long contact)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(contact);
                sw.Close();
            }
        }

        public string[] GetContact()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string[] lines = File.ReadAllLines(path);
                return lines;
            }
        }


    }
}
