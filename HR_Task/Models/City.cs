using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Task.Models
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Employee> EmpListCI { get; set; }
        public List<Country> LICO { get; set; }
    }
}