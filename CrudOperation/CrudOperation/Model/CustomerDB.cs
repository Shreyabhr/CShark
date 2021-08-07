using System;

namespace CrudOperation.Model
{
    class CustomerDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("CustomerDB creates");
        }

        public void Delete()
        {
            Console.WriteLine("CustomerDB deletes");
        }

        public void Read()
        {
            Console.WriteLine("CustomerDB reads");
        }

        public void Update()
        {
            Console.WriteLine("CustomerDB updates");
        }
    }
}
