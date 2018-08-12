﻿using System;

namespace SieveOfEratosten
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            bool[] primeArr = new bool[n+1];

            for (int i = 0; i < primeArr.Length; i++)
            {
                primeArr[i] = true;
            }
            if (primeArr.Length == 1)
            {
                primeArr[0] = false;
            }
            else
            {
                primeArr[0] = false;
                primeArr[1] = false;
            }
            
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (primeArr[i])
                {
                    for (int j = i * i; j < n+1; j += i)
                    {
                        primeArr[j] = false;
                    }
                }
            }
            for (int i = 2; i <= n; i++)
            {
                if (primeArr[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
