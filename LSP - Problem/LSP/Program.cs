using Entities;
using System;

namespace LSP
{
    //This problem occur due to wrong level of abstraction or inheritance.
    //In below class CEO works in a different way and a Employee works in a different way, and this is our problem
    class Program
    {
        static void Main(string[] args)
        {
            //LSP: If S is subtype of T, then object of T may be replacable by object of type S, wihtout breaking the program.
            Manager manager = new Manager();
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

            //Here it violates the LSP principle as, in  AssignManager method of CEO class , we are throwing exception because CEO cannot have manager
            //AS per LSP it should work seamlessly, it shoudnot break the operations
            Employee emp = new CEO();
            emp.FirstName = "Tim";
            emp.LastName = "Corey";
            emp.AssignManager(manager);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour");
            Console.Read();
        }
    }
}
