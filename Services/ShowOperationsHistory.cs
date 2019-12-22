using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Calculator.Interfaces;

namespace Calculator.Services
{
    public class ShowOperationsHistory: IShowOperationsHistory
    {
        public async Task ShowHistory()
        {
            using(var context = new CalculatorContext())
            {
                if (context.LogFile != null)
                {
                    foreach (var entry in context.LogFile)
                    {
                        Console.WriteLine($"{entry.Id.ToString()}) Query: \"{entry.UserQuery.ToString()}\", Result:\"{entry.CalculationResult.ToString()}\"," +
                            $"Calculated on: \"{entry.OperationTime.ToString()}\"");
                    }
                }
                else
                {
                    Console.WriteLine("No entries available.");
                }
            }
            IGetQuery newQuery = new GetQuery();
            await newQuery.GettingQuery();
        }
    }
}
