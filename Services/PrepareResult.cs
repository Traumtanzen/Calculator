using Calculator.Models;
using System;
using Calculator.Interfaces;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class PrepareResult: IPrepareResult
    {
        public async Task PreparingResult(string query, double calculatedResult)
        {
            var showResult = new ShowResult();
            await showResult.ShowingResult(calculatedResult);

            var resultToSave = new CalculationData();
            resultToSave.UserQuery = query;
            resultToSave.CalculationResult = calculatedResult;
            resultToSave.OperationTime = DateTime.Now.ToString();

            var save = new SaveResult();
            await save.SavingResult(resultToSave);
        }
    }
}
