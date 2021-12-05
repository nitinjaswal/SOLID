using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Manager : Employee
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.75M;
            Salary = baseAmount + (rank * 4);
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Reviewing a direct report's performance");
        }
    }
}
