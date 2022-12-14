using CommerceNet.Helpers;
using CompanySite.AppData;
using CompanySite.Helpers;
using CompanySite.Models;
using EmailValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanySite.Controllers {
    public class BackSide : Controller {
        private develops_OPALFAContext _Context;
        private EmailSender _EmailSender;
        public BackSide (develops_OPALFAContext context , EmailSender emailSender)
        {
            _EmailSender = emailSender;
            _Context = context;
        }
        [HttpGet]
        public IActionResult Index ()
        {
            string userName = HttpContext.Session.GetString("AdminUser");
            if (userName != null) {
                var result = _Context.Admins.Where(q => q.AdminUserName == userName).FirstOrDefault();
                if (result != null) {
                    return View();
                }
                else {
                    return RedirectToAction("Login");
                }
            }
            else {
                return RedirectToAction("Login");
            }

        }

        public IActionResult NewCustomer ()
        {
            if (IsAdminUser()) {
                return View();
            }
            else {
                return RedirectToAction("Login");
            }
        }

        #region CRM
        public IActionResult CRM ()
        {
            if (IsAdminUser()) {
                return View();
            }
            else {
                return RedirectToAction("Login");
            }
            
        }


        [HttpPost]
        public JsonResult AddNewCustomer (CustomersProcce newCustomer)
        {
            try {
                if (string.IsNullOrEmpty(newCustomer.CustomerTitle) || string.IsNullOrEmpty(newCustomer.AddressDetail)) {
                    return Json(new { success = false , resText = "İletişim için müşteri ünvanını doldurunuz!" });
                }
                else {
                    newCustomer.CreatedDate = DateTime.Now;
                    newCustomer.CreatedUser = HttpContext.Session.GetString("AdminUser");
                    newCustomer.IsDiscussed = 1;
                    newCustomer.CustomerLevel = 1;
                    _Context.CustomersProcces.Add(newCustomer);
                    _Context.SaveChanges();
                    return Json(new { success = true , resText = "Yeni Müşteri eklendi" });
                }

            }
            catch (Exception error) {
                return Json(new { success = false , resText = error.Message });
            }
        }
        [HttpGet]
        public JsonResult PotantionalCustomer ()
        {
            try {

                List<CustomersProcce> custs = _Context.CustomersProcces.Where(q => q.CustomerLevel == 1).OrderByDescending(q=>q.Id).ToList();
                return Json(new { success = true , count = custs.Count , customerList = custs });

            }
            catch (Exception error) {
                return Json(new { success = false , resText = error.Message });
            }
        }




        #endregion




        [HttpGet]
        public JsonResult GetCustomersNew ()
        {
            try {
                List<Guest> guests = _Context.Guests.ToList();
                return Json(new { success = true , data = guests });
            }
            catch (Exception error) {
                return Json(new { success = false , resText = error.Message });
            }
        }
        [HttpGet]
        public JsonResult GetDataCustomer (int regId)
        {
            try {
                Guest data = _Context.Guests.Where(q => q.Id == regId).FirstOrDefault();
                return Json(new { success = true , data = data });
            }
            catch (Exception error) {
                return Json(new { success = false , resText = error.Message });
            }
        }
        [HttpPost]
        public async Task<JsonResult> SentMail (CompanySite.Helpers.EmailSendModel Email)
        {
            if (!EmailValidator.Validate(Email.MailAddress)) {
                return Json(new { success = false , resText = "Kullanıcının E-Posta adresi geçersiz!" });
            }
            else {
                await _EmailSender.SendEmailAsync(Email.MailAddress , Email.Subject , Email.MailContext);
                Guest guest = _Context.Guests.Where(q => q.Id == Email.RegisterId).FirstOrDefault();
                guest.Answered = 1;
                await _Context.SaveChangesAsync();
                return Json(new { success = true , resText = "Mail Gönderildi" });
            }


        }

        public IActionResult Login ()
        {
            return View();
        }
        [HttpPost]
        public JsonResult LoginProcess (string userName , string password)
        {
            try {
                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) || userName.IndexOf(' ') > -1 || password.IndexOf(' ') > -1) {
                    return Json(new { success = false , resText = "Kullanıcı adı veya şifre yanlış!" });
                }
                else {
                    var result = _Context.Admins.Where(q => q.AdminUserName == userName && q.AdminPassword == password).FirstOrDefault();
                    if (result != null) {
                        HttpContext.Session.SetString("AdminUser" , userName);
                        return Json(new { success = true });
                    }
                    else {
                        return Json(new { success = false , resText = "Kullanıcı bulunamadı!" });
                    }
                }
            }
            catch (Exception) {

                throw;
            }

        }

        [HttpGet]
        public JsonResult GetSessionAdmin ()
        {
            try {
                string userName = HttpContext.Session.GetString("AdminUser");
                if (userName != null) {
                    return Json(new { success = true , adminName = userName });
                }
                else {
                    return Json(new { success = false  });
                }
            }
            catch (Exception) {
                return Json(new { success = false  });
            }
        }

        public IActionResult LogOut ()
        {
            HttpContext.Session.Clear();
            
            return RedirectToAction("Login");
        }

        public bool IsAdminUser ()
        {
            string user = HttpContext.Session.GetString("AdminUser");
            if (user !=null) {
                var result = _Context.Admins.Where(q => q.AdminUserName == user).FirstOrDefault();
                return (result != null ? true : false);
            }
            else {
                return false;
            }
        }


    }
}
