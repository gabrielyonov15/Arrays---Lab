﻿namespace _02.PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];
            for(int i = 0;i<n;i++)
            {
                number[i]=int.Parse(Console.ReadLine());
            }
            for (int i = n-1; i >= 0; i--)
            {
                Console.Write($"{number[i]} ");
            }
        }
    }
}
