﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Введите свое имя: ");

            string name = Console.ReadLine();

            Console.WriteLine(name);

            Console.WriteLine();


        }
    }
}
