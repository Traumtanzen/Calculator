﻿using Calculator.Interfaces;
using Calculator.Services;
using System;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to Calc.v.0.0.0.0.0.0.0.0.1 beta" +
            "\nUse standard operands or enter 'h' for help");
            IGetQuery newQuery = new GetQuery();
            await newQuery.GettingQuery();
        }
    }
}
