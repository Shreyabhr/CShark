using InheritanceExtension.Model;

namespace InheritanceExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInfo(new Employee());
            PrintInfo(new Robot());
        }

        private static void PrintInfo(IWorkEat person)
        {
            person.StartEat();
            person.StopEat();
            person.StartWork();
            person.StopWork();
        }

        private static void PrintInfo(IWork person)
        {
            person.StartWork();
            person.StopWork();
        }
    }
}
