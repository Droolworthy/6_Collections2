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
            Queue<int> cashAccount = new Queue<int>();
            cashAccount.Enqueue(purchaseAmount);
            cashAccount.Enqueue(nextPurchaseAmount);
            cashAccount.Enqueue(middlePurchaseAmount);
            cashAccount.Enqueue(penultimatePurchaseAmount);
            cashAccount.Enqueue(lastPurchaseAmount);

            while (cashAccount.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Суммы покупок: ");

                foreach (var customer in cashAccount)
                {
                    Console.WriteLine(customer);
                }

                myMoneyAccount += cashAccount.Dequeue();

                Console.WriteLine($"У вас на счёте - " + myMoneyAccount + " рублей.");
                Console.WriteLine("Для продолжения нажмите любую кнопку.");
                Console.ReadKey();
            }
        }
    }
}
