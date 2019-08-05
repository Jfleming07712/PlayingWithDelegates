using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PlayingWithDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> AddTwoNumbers = (x, y) => Console.WriteLine(x + y);

            var calc = new Calculator();

            calc.Calculate(3, 5, AddTwoNumbers);




        }
    public class Calculator
        {
            public void Calculate(int x, int y, Action<int, int> AddTwoNumbers)
            {
                AddTwoNumbers(x, y);
                Console.WriteLine("math complete");

            }
        }
        
    }


    
}
