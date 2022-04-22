using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Task.Models
{
    public class VMEmployee
    {
        public Employee VMEmp { get; set; }
        public List<Employee> VMListEmp { get; set; }
        public List<City> VMCi { get; set; }
        public List<Country> VMCO { get; set; }

    }
}