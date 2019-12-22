using System;
using System.Threading.Tasks;
using Calculator.Interfaces;

namespace Calculator.Services
{
    public class ShowResult : IShowResult
    {
        public async Task ShowingResult(double calculatedResult)
        {
            Console.WriteLine($"The result is: {calculatedResult.ToString()}");
            return;
        }

    }
}
