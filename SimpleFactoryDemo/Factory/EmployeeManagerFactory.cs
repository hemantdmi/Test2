using FactoryDemo.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryDemo.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int employeeId)
        {
            IEmployeeManager employeeManager = null;
            if (employeeId == 1)
                employeeManager = new PermanentEmployeeManager();
            if (employeeId == 2)
                employeeManager = new ContractEmployeeManager();
            return employeeManager;
        }
    }
}
