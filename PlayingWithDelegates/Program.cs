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
            Func<int, int, int> AddTwoNumbers = (x, y) =>
            {
                Console.WriteLine(x);
                Console.WriteLine("+");
                Console.WriteLine(y);
                int result = (x + y);
                Console.WriteLine(result);
                return result;
            }; 
            Func<int, int, int> MultTwoNumbers = (x, y) =>
            {
                
                Console.WriteLine(x);
                Console.WriteLine("*");
                Console.WriteLine(y);
                var result = (x * y);
                Console.WriteLine(result);
                return result;
            };



            var calc = new Calculator();

            calc.Calculate(3, 5, AddTwoNumbers);
            calc.Calculate(10, 5, MultTwoNumbers);
            Console.WriteLine(result);




        }
    public class Calculator
        {
            public void Calculate(int x, int y, Func<int, int, int> MathOperator)
            {
                MathOperator(x, y);
                Console.WriteLine("math complete");

            }
        }
        
    }


    
}
