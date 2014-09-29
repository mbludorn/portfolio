using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
        {
            return View(new Models.PortContactForm());
        }

        [HttpPost]
        public ActionResult Index(Models.PortContactForm portcontactForm)
        {
            //create a connection to the database
            Models.PortContactFormsEntities db = new Models.PortContactFormsEntities();
            //add our contact into the database
            db.PortContactForms.Add(portcontactForm);
            //save the changes
            db.SaveChanges();
            //kick the user to the thank you page
            return RedirectToAction("ThankYou", "Contact");
        }

        public ActionResult ThankYou()
        {
            return View();
        }

    }
}

