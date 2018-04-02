using System;
using System.Collections.Generic;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Coins = { 1, 2, 5, 10, 20, 50, 100, 200 };
            int target = 200;

            List<int> Num = new List<int>();
            Num.Add(1);
            for (int i = 1; i < 201; i++)
            {
                Num.Add(0);
            }

            foreach (int coin in Coins)
            {
                for (int i = coin; i < target+1; i++)
                {
                    Num[i] += Num[i - coin];
                }
            }
            Console.WriteLine("Кол-во вариантов: {0}",Num[target]);
            Console.ReadKey();
     }
    }
}
