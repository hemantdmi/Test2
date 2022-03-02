using SimpleFactoryDemo.Factory;
using SimpleFactoryDemo.Manager;
using System;

namespace SimpleFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManagerFactory employeeManager = new EmployeeManagerFactory();
            IEmployeeManager permanentEmployee = employeeManager.GetEmployeeManager(1);
            var permanentEmployeeBonus = permanentEmployee.GetBonus();
            var permanentEmployeePay = permanentEmployee.GetPay();

            IEmployeeManager contractEmployee = employeeManager.GetEmployeeManager(2);
            var contractEmployeeBonus = contractEmployee.GetBonus();
            var contractEmployeePay = contractEmployee.GetPay();

            Console.WriteLine("Hello World!");
        }
    }
}
