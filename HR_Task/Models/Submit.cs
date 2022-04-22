using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace HR_Task.Models
{
    public class Submit : ActionNameSelectorAttribute
    {
        public string button { get; set; }
        public override bool IsValidName(ControllerContext controllerContext, string actionName, System.Reflection.MethodInfo methodInfo)
        {
            var check = controllerContext.Controller.ValueProvider.GetValue(button);
            if (check!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}