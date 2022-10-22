using System;
using System.Collections.Generic;

namespace _6_Collections2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myMoneyAccount = 0;
            int purchaseAmount = 700; 
            int nextPurchaseAmount = 300;
            int middlePurchaseAmount = 500;
            int penultimatePurchaseAmount = 500;
            int lastPurchaseAmount = 1000;
            Queue<int> listPrices = new Queue<int>();
            listPrices.Enqueue(purchaseAmount);
            listPrices.Enqueue(nextPurchaseAmount);
            listPrices.Enqueue(middlePurchaseAmount);
            listPrices.Enqueue(penultimatePurchaseAmount);
            listPrices.Enqueue(lastPurchaseAmount);

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
