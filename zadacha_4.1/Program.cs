using System;

namespace zadacha_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            char[] num = Console.ReadLine().ToCharArray();
            char t = num[num.Length - 1];
            for .(int i = num.Length - 1; i > 0; i--)
            {
                num[i] = num[i - 1];
            }
            num[0] = t;
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
        }
    }
}
