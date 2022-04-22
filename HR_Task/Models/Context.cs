using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HR_Task.Models
{
    public class Context : DbContext
    {
        public Context():base("name=HR_Now")
        {

        }
        public virtual DbSet<Employee> Emp { get; set; }
        public virtual DbSet<City> Ci { get; set; }
        public virtual DbSet<Country> Co { get; set; }


    }
}