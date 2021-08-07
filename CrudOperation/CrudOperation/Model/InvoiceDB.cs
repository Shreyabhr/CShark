using System;

namespace CrudOperation.Model
{
    class InvoiceDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("InvoiceDB creates");
        }

        public void Delete()
        {
            Console.WriteLine("InvoiceDB deletes");
        }

        public void Read()
        {
            Console.WriteLine("InvoiceDB reads");
        }

        public void Update()
        {
            Console.WriteLine("InvoiceDB updates");
        }
    }
}
