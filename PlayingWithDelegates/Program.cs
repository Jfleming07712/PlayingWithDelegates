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
            Action<int, int> AddTwoNumbers = (x, y) =>
            {
                Console.WriteLine(x);
                Console.WriteLine("+");
                Console.WriteLine(y);
                Console.WriteLine(x + y);
            }; 
            Action<int, int> MultTwoNumbers = (x, y) =>
            {
                Console.WriteLine(x);
                Console.WriteLine("*");
                Console.WriteLine(y);
                Console.WriteLine(x * y);
            };



            var calc = new Calculator();

            calc.Calculate(3, 5, AddTwoNumbers);
            calc.Calculate(10, 5, MultTwoNumbers);




        }
    public class Calculator
        {
            public void Calculate(int x, int y, Action<int, int> MathOperator)
            {
                MathOperator(x, y);
                Console.WriteLine("math complete");

            }
        }
        
    }


    
}
