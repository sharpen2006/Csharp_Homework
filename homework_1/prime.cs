

using System;

namespace TestCsharp.firstHomework
{
    public class PrimeJudge
    {
        public static void Execute()
        {
            // 第二题:上下限素数
            Console.Write("请输入下限: ");
            if (!int.TryParse(Console.ReadLine(), out int lower)) return;

            Console.Write("请输入上限: ");
            if (!int.TryParse(Console.ReadLine(), out int upper)) return;

            Console.WriteLine($"{lower} 到 {upper} 之间的素数为：");

            int count = 0;
            for (int i = lower; i <= upper; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + "\t");
                    count++;
                    if (count % 10 == 0) Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        private static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int j = 2; j * j <= number; j++)
            {
                if (number % j == 0) return false;
            }
            return true;
        }
    }
}