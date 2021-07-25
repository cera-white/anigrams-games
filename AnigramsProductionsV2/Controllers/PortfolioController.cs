using AnigramsProductionsV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;

namespace AnigramsProductionsV2.Controllers
{
    [AllowCrossSite]
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
            ViewBag.Message = "";

            return View();
        }

        [HttpPost]
        public ActionResult Index(string name, string email, string message)
        {
            if (ModelState.IsValid)
            {
                ContactViewModel contact = new ContactViewModel()
                {
                    Name = name,
                    Email = email,
                    Subject = "Your Portfolio",
                    Message = message
                };

                string body = string.Format("{0} ({1}) sent you a message from the Portfolio page. This is their message: <br /><br />{2}",
                    contact.Name,
                    contact.Email,
                    contact.Message);

                MailMessage msg = new MailMessage(
                    "noreply@anigrams.org", //from website email (set up at centriqhosting.com)
                    "white.ca12@gmail.com", //to personal email
                    contact.Subject, //subject
                    body);

                msg.IsBodyHtml = true;
                msg.ReplyToList.Add(contact.Email);

                SmtpClient client = new SmtpClient("mail.anigrams.org", 26)
                {
                    Credentials = new NetworkCredential("noreply@anigrams.org", "rIc41j6@")
                };

                client.Send(msg);


                contact.Name = "";
                contact.Email = "";
                contact.Message = "";

                return View(contact);
            }
            else
            {
                return View();
            }
        }

        public ActionResult Resume()
        {
            return View();
        }
    }
}