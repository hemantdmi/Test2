using FactoryDemo.Manager;
using FactoryDemo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDemo.Factory.FactoryMethod
{
    class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {

        }
        public override IEmployeeManager Create()
        {
            ContractEmployeeManager manager = new ContractEmployeeManager();
            _emp.MediacalAllowance = manager.GetMediacalAllowance();
            return manager;
        }
    }
}
