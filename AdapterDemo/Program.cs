using AdapterDemo.Adapter;
using AdapterDemo.Target;
using System;

namespace AdapterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee emp = new EmployeeAdapter();
            string value = emp.GetAllEmployees();
            Console.ReadLine();
        }
    }
}
