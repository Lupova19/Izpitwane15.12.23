using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи броя на числата: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Въведи число {i}: ");
                int num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sum += num;
                }
            }

            if (sum < 100)
            {
                Console.WriteLine($"Сумата на числата е под 100:" +sum);
            }
            else
            {
                Console.WriteLine($"Сумата на числата е равна на:" +sum);
            }
        }
    }
}
