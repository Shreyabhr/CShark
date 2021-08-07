using CalcConsole.Model;
using CalcLib;

namespace CalcConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            ResultProvider result = new ResultProvider();
            PDFGenerator pdf = new PDFGenerator();
            calc.AddCompletion += result.PrintResult;
            calc.AddCompletion += pdf.GeneratePDF;
            calc.Add(10, 20);
        }
    }
}
