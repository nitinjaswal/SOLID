using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string EmployeeType { get; set; }
        public Employee()
        {

        }
        public Employee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public abstract int CalculateBonus(int salary);
        public virtual void Show()
        {
            Console.WriteLine("Base: SHOW()");
        }
    }

    public class PermanentEmployee : Employee
    {
        public PermanentEmployee(int id, string name) :base(id, name)
        {

        }
        public override int CalculateBonus(int salary)
        {
            return salary * 2;
        }
        public new void Show()
        {
            Console.WriteLine("PermanentEmployee: SHOW()");
        }
    }

    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee(int id, string name) : base(id, name)
        {

        }
        public override int CalculateBonus(int salary)
        {
            return salary * 1;
        }
    }

    public class ContractEmployee : Employee
    {
        public ContractEmployee()
        {

        }
        public ContractEmployee(int id, string name) : base(id, name)
        {

        }

        public override int CalculateBonus(int salary)
        {
            throw new NotImplementedException();    
        }

    }

}

  
