using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using  HR_Task.Models;
namespace HR_Task.Controllers
{
    public class HRController : Controller
    {
        //
        // GET: /HR/
        public ActionResult Employee()
        {
            VMEmployee vm = new VMEmployee();
            vm.VMCO = FillCountry();
            vm.VMCi = FillCity();
            return View("Employee",vm);
        }
        [Submit (button="Save")]
        public ActionResult Save(VMEmployee vm)
        {
            Context con = new Context();
            if (ModelState.IsValid)
            {
                con.Emp.Add(vm.VMEmp);
                con.SaveChanges();
            }

           // VMEmployee vm = new VMEmployee();
            vm.VMCO = FillCountry();
            vm.VMCi = FillCity();
            return View("Employee", vm);
        }
        [Submit(button="Update")]
        public ActionResult Update()
        {


            VMEmployee vm = new VMEmployee();
            vm.VMCO = FillCountry();
            vm.VMCi = FillCity();
            return View("Employee", vm);
        }
        private List<Country> FillCountry()
        {
            Context con=new Context();
            VMEmployee vm = new VMEmployee();
            List<Country> li = new List<Country>();

            var data = from x in con.Co
                       select new { x.ID, x.Name };
            foreach (var item in con.Co)
            {
                Country Co=new Country();
                Co.ID = item.ID;
                Co.Name = item.Name;
                li.Add(Co);
            }
            return li;

	}

        public List<City> FillCity()
        {
            VMEmployee vm = new VMEmployee();
            Context con = new Context();
            List<City> li = new List<City>();
            var data = from x in con.Ci
                       select new { x.ID, x.Name };
            foreach (var item in con.Ci)
            {
                City ci = new City();
                ci.ID = item.ID;
                ci.Name = item.Name;
                li.Add(ci);
            }
            return li;
        }
    }
}