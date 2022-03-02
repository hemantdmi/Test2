using FactoryDemo.Manager;
using FactoryDemo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDemo.Factory.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;
        public BaseEmployeeFactory(Employee employee)
        {
            _emp = employee;
        }
        public Employee ApplySalary()
        {
            IEmployeeManager manager = Create();
            _emp.Bonus = manager.GetBonus();
            _emp.HourlyPay = manager.GetPay();
            return _emp;
        }
        public abstract IEmployeeManager Create();
    }
}
