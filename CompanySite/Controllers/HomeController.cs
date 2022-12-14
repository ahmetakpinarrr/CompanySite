using CompanySite.AppData;
using CompanySite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CompanySite.Helpers;

namespace CompanySite.Controllers {
    public class HomeController : Controller {

        private readonly develops_OPALFAContext _context;

        public HomeController (develops_OPALFAContext context)
        {
            _context = context;
        }

        public IActionResult Index ()
        {
            return View();
        }

        public IActionResult Privacy ()
        {
            return View();
        }

        public IActionResult Packages ()
        {
            return View();
        }

        public IActionResult AboutUs ()
        {
            return View();
        }


        public IActionResult Blog ()
        {
            return View();
        }

        public IActionResult Support ()
        {
            return View();
        }

        public IActionResult Contact ()
        {
            return View();
        }
        [HttpPost]
        public JsonResult SentMessage (Guest newGuest)
        {
            try {
                HelperProccess helper = new HelperProccess(_context);
                var result = helper.SendMessage(newGuest);
                return Json(result.Value);
            }
            catch (Exception error) {
                return Json(new { success = false , resText = "Hata : " + error.Message });
            }
        }
        [HttpPost]
        public JsonResult RegisterNotification (string email)
        {
            try {
                HelperProccess helper = new HelperProccess(_context);
                GuestNotification newNotification = new GuestNotification() { GuestMail = email };
                var result = helper.SaveNewRegister(newNotification);
                return Json(result.Value);
            }
            catch (Exception error) {
                return Json(new { success = false , resText = "Hata : " + error.Message });
            }
        }
        [HttpPost]
        public JsonResult NewCustomerProcess (Guest newCustomer)
        {
            try {
                HelperProccess helper = new HelperProccess(_context);
                var result = helper.SendMessage(newCustomer);
                return Json(result.Value);
            }
            catch (Exception error) {
                return Json(new { success = false , resText = "Hata : " + error.Message });
            }
        }

    }
}
