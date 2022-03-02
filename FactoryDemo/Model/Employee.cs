using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDemo.Model
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int EmpType { get; set; }
        public decimal Bonus { get; set; }
        public decimal HourlyPay { get; set; }
        public decimal HRA { get; set; }
        public decimal MediacalAllowance { get; set; }
    }
}
