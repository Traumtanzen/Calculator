﻿using Calculator.Models;
using Calculator.Interfaces;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class SaveResult : ISaveResult
    {
        public async Task SavingResult(CalculationData resultToSave)
        {
            using (var context = new CalculatorContext())
            {
                context.LogFile.Add(resultToSave);
                await context.SaveChangesAsync();
                IGetQuery newQuery = new GetQuery();
                await newQuery.GettingQuery();
            }
        }
    }
}
