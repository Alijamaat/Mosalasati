using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donbale_mosalasati
{
    class Program
    {
        static void Main(string[] args)
        {
           //علی پیر محمد جماعت و حمیدرضا واحدی و مهدی نوروزی  پیشرفته 1
            Console.Write("enter number one: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter number two: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("donbale mosalasi bein {0} and {1}:", firstNumber, secondNumber);

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                if (mosalasi(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }

        static bool mosalasi(int number)
        {
            int sum = 0;
            int n = 1;

            while (sum < number)
            {
                sum += n;
                n++;
            }

            return sum == number;
        }
    }
}
