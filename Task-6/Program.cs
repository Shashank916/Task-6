using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2,4,6,8,10 };

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
        }
    }
}
