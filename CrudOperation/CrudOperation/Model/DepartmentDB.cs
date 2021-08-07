using System;

namespace CrudOperation.Model
{
    class DepartmentDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("DepartmentDB creates");
        }

        public void Delete()
        {
            Console.WriteLine("DepartmentDB deletes");
        }

        public void Read()
        {
            Console.WriteLine("DepartmentDB reads");
        }

        public void Update()
        {
            Console.WriteLine("DepartmentDB updates");
        }
    }
}
