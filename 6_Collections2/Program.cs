using System;
using System.Collections.Generic;

namespace _6_Collections2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moneyAccount = 0;
            string name = "Николай";
            string nextName = "Владимир";
            string middleName = "Сергей";
            string penultimateName = "Илья";
            string lastName = "Иван";
            int purchaseAmount = 700; 
            int nextPurchaseAmount = 300;
            int middlePurchaseAmount = 500;
            int penultimatePurchaseAmount = 500;
            int lastPurchaseAmount = 1000;
            Queue<string> listBuyers = new Queue<string>();
            Queue<int> cashAccount = new Queue<int>();
            listBuyers.Enqueue(name);
            listBuyers.Enqueue(nextName);
            listBuyers.Enqueue(middleName);
            listBuyers.Enqueue(penultimateName);
            listBuyers.Enqueue(lastName);
            cashAccount.Enqueue(purchaseAmount);
            cashAccount.Enqueue(nextPurchaseAmount);
            cashAccount.Enqueue(middlePurchaseAmount);
            cashAccount.Enqueue(penultimatePurchaseAmount);
            cashAccount.Enqueue(lastPurchaseAmount);

            while (cashAccount.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("\nСейчас в очереди стоят: ");

                foreach (var customer in listBuyers)
                {
                    Console.WriteLine(customer);
                }

                Console.WriteLine("\nК вам подошёл - " + listBuyers.Dequeue());
                Console.WriteLine("Он купил товаров на сумму " + cashAccount.Peek() + " рублей.");

                moneyAccount += cashAccount.Dequeue();

                Console.WriteLine($"У вас на счёте - " + moneyAccount + " рублей.");
                Console.WriteLine("Для продолжения нажмите любую кнопку.");
                Console.ReadKey();
            }
        }
    }
}
