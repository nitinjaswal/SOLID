using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class CEO : Employee
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150m;
            Salary = baseAmount * rank;
        }

        public override void AssignManager(Employee manager)
        {
            throw new InvalidOperationException("The CEO has no manager");
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
