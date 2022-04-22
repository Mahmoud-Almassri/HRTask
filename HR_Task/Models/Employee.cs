using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace HR_Task.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        
        
        public string Email { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        public string Gender { get; set; }
        
        [ForeignKey("CityID")]
        public int City_ID { get; set; }
        public City CityID { get; set; }

        [ForeignKey("CountryID")]
        public int Country_ID { get; set; }
        public Country CountryID { get; set; }


    }
}