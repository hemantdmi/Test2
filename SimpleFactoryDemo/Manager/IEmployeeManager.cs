using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryDemo.Manager
{
    public interface IEmployeeManager
    {
        decimal GetBonus();
        decimal GetPay();
    }
}
