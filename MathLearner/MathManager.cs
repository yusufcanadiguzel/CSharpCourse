using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLearner
{
    public class MathManager
    {
        public void Add(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine("Sonuç : " + result);
        }

        public void Subtract(int number1, int number2)
        {
            int result = number1 - number2;
            Console.WriteLine("Sonuç : " + result);
        }

        public void Divide(int number1, int number2)
        {
            int result = number1 / number2;
            Console.WriteLine("Sonuç : " + result);
        }

        public void Multiply(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine("Sonuç : " + result);
        }
    }
}
