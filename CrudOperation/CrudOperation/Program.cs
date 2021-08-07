using CrudOperation.Model;

namespace CrudOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            DoDBOperation(new InvoiceDB());
            DoDBOperation(new CustomerDB());
            DoDBOperation(new DepartmentDB());
        }

        private static void DoDBOperation(ICrudable dBMethod)
        {
            dBMethod.Create();
            dBMethod.Delete();
            dBMethod.Read();
            dBMethod.Update();
        }
    }
}
