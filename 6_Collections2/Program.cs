using System;
using System.Collections.Generic;

namespace _6_Collections2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moneyAccount = 0;
            Queue<int> prices = new Queue<int>();
            prices.Enqueue(700);
            prices.Enqueue(300);
            prices.Enqueue(500);
            prices.Enqueue(500);
            prices.Enqueue(1000);

            while (prices.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Суммы покупок: ");

                foreach (var customer in prices)
                {
                    Console.WriteLine(customer);
                }

                moneyAccount += prices.Dequeue();

                Console.WriteLine($"У вас на счёте - " + moneyAccount + " рублей.");
                Console.WriteLine("Для продолжения нажмите любую кнопку.");
                Console.ReadKey();
            }
        }
    }
}
