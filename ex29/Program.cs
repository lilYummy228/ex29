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
            Console.WriteLine("Вы ввели число: " + GetNumber());
        }

        static int GetNumber()
        {
            bool isRightInput = true;
            int number = 0;

            while (isRightInput)
            {
                Console.Write("Введите число: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out number) == true)
                {
                    isRightInput = false;
                }
            }

            return number;
        }
    }
}
