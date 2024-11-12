using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1 : ");
            float number1 = float.Parse(Console.ReadLine());
            Console.Write("Enter number 2 : ");
            float number2 = float.Parse(Console.ReadLine());
            Console.Write("Enter number 3 : ");
            float number3 = float.Parse(Console.ReadLine());

            float max, mid, mini;

            if (number1 >= number2 && number1 >= number3)
            {
                max = number1;
                if (number2 >= number3)
                {
                    mid = number2;
                    mini = number3;
                }
                else
                {
                    mid = number3;
                    mini = number2;
                }
            }
            else if (number2 >= number1 && number2 >= number3)
            {
                max = number2;
                if (number1 >= number3)
                {
                    mid = number1;
                    mini= number3;
                }
                else
                {
                    mid = number3;
                    mini = number1;
                }

            }
            else
            {
                max = number3;
                if (number1 >= number2)
                {
                    mid = number1;
                    mini= number2;
                }
                else
                {
                    mid = number2;
                    mini = number1;
                }
            }
            Console.WriteLine("\n");
            Console.Write("number max ... min :");
            Console.Write(" , " + max);
            Console.Write(" , " + mid);
            Console.Write(" , " + mini);
            Console.ReadKey();


        }
    }
}
