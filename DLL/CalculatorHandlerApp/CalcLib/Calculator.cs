
namespace CalcLib
{
    public delegate void DMathHandler(int result);
    public class Calculator
    {
        private int _result;
        public event DMathHandler AddCompletion;
        public void Add(int a, int b)
        {
            _result =  a + b;
            if(AddCompletion != null)
            {
                AddCompletion(_result);
            }
        }

      
    }
}
