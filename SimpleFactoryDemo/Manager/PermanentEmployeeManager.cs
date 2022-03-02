using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryDemo.Manager
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
    }
}
