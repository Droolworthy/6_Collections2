//У вас есть множество целых чисел. Каждое целое число - это сумма покупки.
//Вам нужно обслуживать клиентов до тех пор, пока очередь не станет пуста.
//После каждого обслуженного клиента деньги нужно добавлять на наш счёт и выводить его в консоль.
//После обслуживания каждого клиента программа ожидает нажатия любой клавиши, 
//после чего затирает консоль и по новой выводит всю информацию, только уже со следующим клиентом.
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
