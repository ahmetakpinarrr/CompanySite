using CompanySite.AppData;
using CompanySite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace CompanySite {
    public class HelperProccess : Controller {

        private readonly develops_OPALFAContext _context;
        public HelperProccess (develops_OPALFAContext context)

        {
            _context = context;
        }

        public JsonResult SendMessage (Guest newGuest)
        {
            try {
                if (string.IsNullOrEmpty(newGuest.GuestEmail)  &&  string.IsNullOrEmpty(newGuest.GuestPhone)) {
                    return Json(new { success= false, resText="E-Posta veya Telefon numaranızı boş geçmeyiniz!" });
                }
                else {
                    newGuest.CreatedDate = DateTime.Now;
                    newGuest.Answered = 0;
                    newGuest.Showed = 0;
                    _context.Guests.Add(newGuest);
                    _context.SaveChanges();
                    return Json(new { success = true, resText= "Mesajınızı Aldık. Teşekkürler." });
                }
            }
            catch (Exception error) {
                return Json(new { success = false , resText = "Hata : " +error.Message });
            }
        }
        public JsonResult SaveNewRegister (GuestNotification newGuest)
        {
            try {
                if (string.IsNullOrEmpty(newGuest.GuestMail)) {
                    return Json(new { success = false , resText = "E-Posta alanını boş geçmeyiniz!" });
                }
                else {
                    newGuest.CreateDate = DateTime.Now;
                    newGuest.IsNoticationActive = 1;
                    _context.GuestNotifications.Add(newGuest);
                    _context.SaveChanges();
                    return Json(new { success = true , resText = "Kayıt başarılı. Teşekkürler." });
                }
            }
            catch (Exception error) {
                return Json(new { success = false , resText = "Hata : " + error.Message });
            }
        }




    }
}
