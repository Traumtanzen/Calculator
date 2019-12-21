using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class Help : IHelp
    {
        public async Task ShowHelp()
        {
            Console.WriteLine("This is simple calculator. It can:" +
                "\n'1 + 2' - Sum" +
                "\n'1 - 2' - Subtract" +
                "\n'1 * 2' - Myltiply" +
                "\n'1 / 2' - Divide" +
                "\n'2 sin' - Find sinus" +
                "\n'2 cos' - Find cosinus" +
                "\n'2 tan' - Find tangens" +
                "\n'2 ^ 3' - Exponent numbers");
            IGetQuery newQuery = new GetQuery();
            await newQuery.GettingQuery();
        }
    }
}
