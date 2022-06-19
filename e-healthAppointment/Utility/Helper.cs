using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_healthAppointment.Utility
{
    public static class Helper
    {
        public static String Admin = "Admin";
        public static String Patient = "Patient";
        public static String Doctor = "Doctor";

        public static List<SelectListItem> GetRolesForDropDown()
        {
            return new List<SelectListItem>{

            new SelectListItem{Value = Helper.Admin, Text=Helper.Admin},
            new SelectListItem{Value = Helper.Patient, Text=Helper.Patient},
            new SelectListItem{Value = Helper.Doctor, Text=Helper.Doctor}
            };

    }
    }
}
