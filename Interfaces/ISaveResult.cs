using Calculator.Models;
using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    interface ISaveResult
    {
        public Task SavingResult(CalculationData resultToSave);
    }
}
