using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetNumber();
        }

        static int GetNumber()
        {
            Console.WriteLine("Введите число: ");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Неверное значение!");
            }
        }
    }
}
