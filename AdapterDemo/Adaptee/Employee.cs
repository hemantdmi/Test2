using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace AdapterDemo
{
    [Serializable]
    public class Employee
    {
        Employee() { }
        public Employee(int id, string name)
        {
            ID = id;
            Name = name;
        }
        [XmlAttribute]
        public int ID { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
    }
}
