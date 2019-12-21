using Microsoft.EntityFrameworkCore;
using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CalculatorContext : DbContext
    {
        public DbSet<CalculationData> LogFile { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DELL-SERGEY;Database=CalculatorLogs;Integrated Security=True;");
        }
    }
}
