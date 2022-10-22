using System;
using System.Collections.Generic;

namespace _6_Collections2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myMoneyAccount = 0;
            Queue<int> listPrices = new Queue<int>();
            listPrices.Enqueue(700);
            listPrices.Enqueue(300);
            listPrices.Enqueue(500);
            listPrices.Enqueue(500);
            listPrices.Enqueue(1000);

            while (listPrices.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Суммы покупок: ");

                foreach (var customer in listPrices)
                {
                    Console.WriteLine(customer);
                }

                myMoneyAccount += listPrices.Dequeue();

                Console.WriteLine($"У вас на счёте - " + myMoneyAccount + " рублей.");
                Console.WriteLine("Для продолжения нажмите любую кнопку.");
                Console.ReadKey();
            }
        }
    }
}
