using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworold
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            string action;

            Console.WriteLine("Введите A");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите B");
            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию '+' '-' '*' '/'");
            action = Console.ReadLine();

            switch (action)
            {
<<<<<<< HEAD
                
                case "-":
                    Console.WriteLine(firstValue - secondValue);
                    break;
                
               
=======
                case "+":
                    Console.WriteLine(firstValue + secondValue);
                    break;
              
                   
                
>>>>>>> plus
                default:
                    Console.WriteLine("ошибка");
                    break;
            }
            Console.ReadLine();
        }
    }
}
