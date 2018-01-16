using NealServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace NealServices.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(EmailMessage model)
        {
             var smtp = new SmtpClient();

            var body = "<p>Email From: {0} (phone: {1} email: {2} )</p><p>Message:</p><p>{3}</p>";
            var mailMessage = new MailMessage();
            mailMessage.To.Add(new MailAddress("nealservicesinc@hotmail.com"));
            mailMessage.Subject = $"You have a message from NealServicesInc.com";
            mailMessage.Body = string.Format(body, model.strFromName, model.strPhone, model.strFromAddress, model.strBody);
            mailMessage.IsBodyHtml = true;

            smtp.Send(mailMessage);

            return RedirectToAction("Index", "Home");
        }

        //public ActionResult Testimony()
        //{



        //}
    }
}