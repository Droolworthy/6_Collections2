using System;
using System.Collections.Generic;

namespace _6_Collections2
{
//У вас есть множество целых чисел.Каждое целое число - это сумма покупки.
//Вам нужно обслуживать клиентов до тех пор, пока очередь не станет пуста.
//После каждого обслуженного клиента деньги нужно добавлять на наш счёт и выводить его в консоль.
//После обслуживания каждого клиента программа ожидает нажатия любой клавиши, после чего затирает консоль 
//и по новой выводит всю информацию, только уже со следующим клиентом
    internal class Program
    {
        static void Main(string[] args)
        {          
            bool canExitApp = true;
            int MyMoneyAccount = 0; //денежный счёт
            int purchaseAmount1 = 1255; //сумма покупки
            int purchaseAmount2 = 5000;
            int purchaseAmount3 = 1234;
            int purchaseAmount4 = 432;
            int purchaseAmount5 = 666;
            string userInput;
            string name1 = "Николай";
            string name2 = "Владимир";
            string name3 = "Сергей";
            string name4 = "Илья";
            string name5 = "Иван";
            Queue<string> customers = new Queue<string>();//клиенты
            Queue<int> cashAccount = new Queue<int>(); //денежный счёт

            customers.Enqueue(name1);
            customers.Enqueue(name2);
            customers.Enqueue(name3);
            customers.Enqueue(name4);
            customers.Enqueue(name5);
            cashAccount.Enqueue(purchaseAmount1);
            cashAccount.Enqueue(purchaseAmount2);
            cashAccount.Enqueue(purchaseAmount3);
            cashAccount.Enqueue(purchaseAmount4);
            cashAccount.Enqueue(purchaseAmount5);

            Console.WriteLine($"У вас на счёте - " + MyMoneyAccount + " рублей"); 
            Console.WriteLine("\nСейчас в очереди стоят: ");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("\nСейчас идёт - " + customers.Peek());
            Console.WriteLine("К вам подошёл - " + customers.Dequeue());
            Console.WriteLine("Он хочет купить товар на сумму - " + cashAccount.Peek());
            Console.WriteLine("Он купил товар на сумму - " + cashAccount.Dequeue());
            Console.WriteLine($"\nУ вас на счёте - " + MyMoneyAccount + " рублей");
            Console.WriteLine("\nСейчас в очереди стоят: ");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("\nСейчас идёт - " + customers.Peek());
            Console.WriteLine("К вам подошёл - " + customers.Dequeue());
            Console.WriteLine("Он купил товаров на сумму - " + cashAccount.Dequeue());
            Console.WriteLine($"\nУ вас на счёте - " + MyMoneyAccount + " рублей");
            Console.WriteLine("\nСейчас в очереди стоят: ");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
    }
}