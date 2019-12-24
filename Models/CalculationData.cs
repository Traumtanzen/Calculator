using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Models
{
    public class CalculationData : BaseEntity
    {
        public string UserQuery { get; set; }
        public double CalculationResult { get; set; }
        public string OperationTime { get; set; }
    }
}
