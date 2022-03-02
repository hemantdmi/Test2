using FactoryDemo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDemo.Factory.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee emp)
        {
            BaseEmployeeFactory returnValue = null;
            if (emp.EmpType == 1)
                returnValue = new PermanentEmployeeFactory(emp);
            if (emp.EmpType == 2)
                returnValue = new ContractEmployeeFactory(emp);
            return returnValue;
        }
    }
}
