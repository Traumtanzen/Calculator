using Calculator.Models;
using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    interface IPrepareResult
    {
        public Task PreparingResult(string query, double calculatedResult);
    }
}
