﻿using System;
using System.Globalization;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Random rnd = new Random();
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 11);
            }

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            int min = numbers[0];
            int max = numbers[0];

            for(int i = 0; i < numbers.Length; i++)
            {
                if (min > numbers [i])
                {
                    min = numbers[i];
                }

                if(max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
        }
    }
}
