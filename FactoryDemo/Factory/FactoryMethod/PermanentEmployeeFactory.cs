using FactoryDemo.Manager;
using FactoryDemo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDemo.Factory.FactoryMethod
{
    class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {

        }
        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager manager = new PermanentEmployeeManager();
            _emp.HRA = manager.GetHRA();
            return manager;
        }
    }
}
