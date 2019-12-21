using System;
using Calculator.Interfaces;

namespace Calculator.Services
{
    public class ShowResult : IShowResult
    {
        public async void ShowingResult(double calculatedResult)
        {
            Console.WriteLine($"The result is: {calculatedResult.ToString()}");
        }

    }
}
