using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace HR_Task.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Employee> EmpListCO { get; set; }
        [ForeignKey("CityID")]
        public int City_ID { get; set; }
        public City CityID { get; set; }
    }
}