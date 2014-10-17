using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Index(Models.PortContactForm portcontactForm)
        //{
        //    //create a connection to the database
        //    Models.PortContactFormsEntities db = new Models.PortContactFormsEntities();
        //    //add our contact into the database
        //    db.PortContactForms.Add(portcontactForm);
        //    //save the changes
        //    db.SaveChanges();
        //    //kick the user to the thank you page
        //    return RedirectToAction("ThankYou", "Contact");
        //}

        //new contact form post to send me an email with the info
        [HttpPost]
        public ActionResult Index(Models.Contactajax contact)
        {
            //sending an email
            //Step 1: add using system.Net.Mail;
            //Step2: Create a new message
            MailMessage message = new MailMessage("TheRobots@place.com","morganbludorn@gmail.com");
            //Step3: Set the Subject
            message.Subject = "Contact Request from " + contact.Name;
            //Step 4: Construct the Body with a string builder
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("You have a new contact request.");
            sb.AppendLine("Name: " + contact.Name);
            sb.AppendLine("Email: " + contact.Email);
            sb.AppendLine("Message: " + contact.Message);
            sb.AppendLine("I Love You,");
            sb.AppendLine("The Robot");
            //Step 5: add the body to the message
            message.Body = sb.ToString();
            //Step 6: Declare the SMTP Cliet aka the mail server
            SmtpClient smtpClient = new SmtpClient("mail.dustinkraft.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential("postmaster@dustinkraft.com", "techIsFun1");
            //Step 7: Send the message
            smtpClient.Send(message);
            //Done.

            //Kick the user to the Thank You Page
            return PartialView("ThankYou");

           
            



        }

        public ActionResult ThankYou()
        {
            return View();
        }

    }
}

