using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    interface IShowResult
    {
        public Task ShowingResult(double calculatedResult);
    }
}
