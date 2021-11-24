using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class CEO : BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150m;
            Salary = baseAmount * rank;
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Reviewing a direct report's performance");
        }

        public void Fire()
        {
            Console.WriteLine("You are fired");
        }
    }
}
