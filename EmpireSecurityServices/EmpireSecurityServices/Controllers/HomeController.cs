using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmpireSecurityServices.Models;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.IO;
namespace EmpireSecurityServices.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "ESS | Home";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "ESS | About Us";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "ESS | Contact Us";
            Contact model = new Contact();
            return View(model);
        }

        [HttpPost]
        public ActionResult Contact(Contact model)
        {
            if (ModelState.IsValid)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(model.EmailAddress);
                mail.From = new MailAddress("pramodbhatt.it@gmail.com");
                mail.Subject = "New Contact Us Query";
                string Body = model.Message;
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Send(mail);

                return View("Index", "Home");
            }
            else
            {
                return View();
            }

        }

        public ActionResult Services()
        {
            ViewBag.Title = "ESS | Services";
            return View();
        }

        public ActionResult Career()
        {
            ViewBag.Title = "ESS | Career";
            return View();
        }

        [HttpPost]
        public ActionResult Career(Resume model, HttpPostedFileBase attachment)
        {
            if (ModelState.IsValid)
            {
                string from = "pramodbhatt.it@gmail.com";
                using (MailMessage mail = new MailMessage(from, model.EmailAddress))
                {
                    mail.Subject = model.CoverLetter;
                    string mailBody = "<p>Dear Admin,</p>" +
                    "<p>A New job application has been submitted by Mr. " + model.Name + "</p>" +
                    "<p>The contact detils of applicants are as follows:</p><br/>" +
                    "<p> Contact No : " + model.ContactNo + "</p>" +
                    "<p> Email-Address : "+model.EmailAddress+"</p><br/>" +
                    "<p>Regards,</p><br/><p>WebMaster</p>";
                    if (attachment != null)
                    {
                        string fileName = Path.GetFileName(attachment.FileName);
                        mail.Attachments.Add(new Attachment(attachment.InputStream, fileName));
                    }
                    mail.IsBodyHtml = false;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Send(mail);
                    ViewBag.Message = "Sent";
                    return View("Index", "Home");
                }
            }
            else
            {
                return View();
            }
        }
    }
}