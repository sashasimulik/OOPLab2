﻿using System;

namespace OOPLab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Введiть ваш вiк: ");
            int n = int.Parse(Console.ReadLine());
            int p = 0;
            if (n % 10 == 1 && n != 11)
            {
                p = 1;
            }
            else if ((n % 10 == 2 || n % 10 == 3 || n % 10 == 4) && (n != 12 || n != 13 || n != 14))
            {
                p = 2;
            }
            else if (n <= 100)
            {
                p = 3;
            }
            Console.WriteLine("\n");
            switch (p)
            {
                case 1: Console.WriteLine(n + " Рiк"); break;
                case 2: Console.WriteLine(n + " Роки"); break;
                case 3: Console.WriteLine(n + " Рокiв"); break;

            }
        }
    }
}


