using AccountApp.Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace SerializeAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(101, "abc", 1000);
            acc.Deposite(1000);
            acc.Deposite(400);
            SerializeAccount(acc);
            Console.WriteLine("After Serialization: " +acc.Balance);
            DeserializeAccount();
            Console.WriteLine("After Deserialization: " +acc.Balance);

        }

        private static void DeserializeAccount()
        {
            FileStream stream = new FileStream("account.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Deserialize(stream);
            stream.Close();
        }

        private static void SerializeAccount(Account acc)
        {
            FileStream stream = new FileStream("account.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, acc);
            stream.Close();
        }
    }
}
