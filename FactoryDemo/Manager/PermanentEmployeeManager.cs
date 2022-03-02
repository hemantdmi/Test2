using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDemo.Manager
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetPay()
        {
            return 8;
        }

        public decimal GetHRA()
        {
            return 150;
        }
    }
}
