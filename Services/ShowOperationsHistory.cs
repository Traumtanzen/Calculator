using System;
using System.Collections.Generic;
using System.Text;
using Calculator.Interfaces;

namespace Calculator.Services
{
    public class ShowOperationsHistory: IShowOperationsHistory
    {
        public async void ShowHistory()
        {
            await using(var context = new CalculatorContext())
            {
                foreach (var entry in context.LogFile)
                {
                    Console.WriteLine($"{entry.Id.ToString()}) Query: \"{entry.UserQuery.ToString()}\", Result:\"{entry.CalculationResult.ToString()}\"," +
                        $"Calculated on: \"{entry.OperationTime.ToString()}\"");
                }
            }
        }
    }
}
