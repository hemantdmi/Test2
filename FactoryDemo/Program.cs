using FactoryDemo.Factory.FactoryMethod;
using FactoryDemo.Manager;
using FactoryDemo.Model;
using System;

namespace FactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseEmployeeFactory employeeManager1 = new EmployeeManagerFactory().CreateFactory(new Employee { EmpId = 1, EmpType = 1 });
            var computePESalary = employeeManager1.ApplySalary();

            BaseEmployeeFactory employeeManager2 = new EmployeeManagerFactory().CreateFactory(new Employee { EmpId = 1, EmpType = 2 });
            var computeCESalary = employeeManager2.ApplySalary();
            Console.WriteLine("Hello World!");
        }
    }
}
