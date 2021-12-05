using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new PermanentEmployee(1, "John");
            Employee emp2 = new TemporaryEmployee(2, "Mike");
            emp1.Show();

            PermanentEmployee PE = new PermanentEmployee(3, "nitin");
            PE.Show();
            PE.CalculateBonus(2);

            Console.WriteLine("Bonus of Permanent employee :" + emp1.CalculateBonus(1000));
            Console.WriteLine("Bonus of Temp emplpoyee:" + emp2.CalculateBonus(1000));
            Console.ReadLine();
        }
    }
}
