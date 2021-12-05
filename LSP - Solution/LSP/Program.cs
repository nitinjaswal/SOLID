using Entities;
using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            //LSP: If S is subtype of T, then object of T may be replacable by object of type S, wihtout breaking the program.
            IManager manager = new CEO();
            manager.FirstName = "Nitin";
            manager.LastName = "Jaswal";
            manager.CalculatePerHourRate(4);

            // Employee emp = new Employee();//This is the base type
            //Now LSP states that we should be able to replace Employee(base type) with Manager(Derived type)
            //IT WORKS FINE
            //Employee emp = new Manager();
            //emp.FirstName = "Tim";
            //emp.LastName = "Corey";
            //emp.AssignManager(manager);
            //emp.CalculatePerHourRate(2);

            IManaged emp = new Manager();
            emp.FirstName = "Tim";
            emp.LastName = "Corey";
            emp.AssignManager(manager);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour");
            Console.Read();
            
        }
    }
}
