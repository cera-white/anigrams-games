using AnigramsProductionsV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using AnigramsProductionsV2.EF;

namespace AnigramsProductionsV2.Controllers
{
    public class HomeController : Controller
    {
        private AnigramsEntities db = new AnigramsEntities();

        public ActionResult Index()
        {
            ViewBag.Projects = db.AnigramsProjects.ToList();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        //GET: Support
        public ActionResult Support()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Support(string name, string email, string subject, string message)
        {
            if (ModelState.IsValid)
            {
                //Instantiate the ViewModel and populate it with data
                ContactViewModel contact = new ContactViewModel()
                {
                    Name = name,
                    Email = email,
                    Subject = subject,
                    Message = message
                };

                //Add a using statement for System.Net.Mail

                //Create the body for the confirmation email
                string body = string.Format("{0} ({1}) sent you a message from the Support page. This is their message: <br /><br />{2}",
                    contact.Name,
                    contact.Email,
                    contact.Message);

                //Create the MailMessage object
                MailMessage msg = new MailMessage(
                    "noreply@anigrams.org", //from website email (set up at centriqhosting.com)
                    "white.ca12@gmail.com", //to personal email
                    contact.Subject, //subject
                    body);

                msg.IsBodyHtml = true;
                msg.ReplyToList.Add(contact.Email);

                SmtpClient client = new SmtpClient("relay-hosting.secureserver.net");

                client.Send(msg);

                return RedirectToAction("Confirmation", contact);
            }
            else
            {
                return View();
            }
        }

        public ActionResult Confirmation(ContactViewModel contact)
        {
            ViewBag.Message = string.Format("<h2>Thank you, {0}!</h2><br /><br /><h3>The following message has been sent:</h3> <br />\"{1}\"",
                contact.Name,
                contact.Message);

            return View(contact);
        }

        public ActionResult SiteMap()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}