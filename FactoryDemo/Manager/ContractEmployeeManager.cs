using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDemo.Manager
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 5;
        }

        public decimal GetPay()
        {
            return 12;
        }

        public decimal GetMediacalAllowance()
        {
            return 100;
        }
    }
}
