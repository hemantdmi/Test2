using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDemo.Manager
{
    public interface IEmployeeManager
    {
        decimal GetBonus();
        decimal GetPay();
    }
}
