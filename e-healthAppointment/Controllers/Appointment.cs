using e_healthAppointment.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_healthAppointment.Controllers
{
    public class Appointment : Controller
    {

        private readonly IAppointmentService _appointmentService;
        public Appointment(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }
        public IActionResult Index()
        {
         ViewBag.DoctorList = _appointmentService.GetDoctorList();
             
            return View();
        }
    }
}
