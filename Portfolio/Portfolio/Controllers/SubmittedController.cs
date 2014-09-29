using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class SubmittedController : Controller
    {
        //Step 1: crate a connects to our database
        Models.PortContactFormsEntities db = new Models.PortContactFormsEntities();



        public ActionResult Index()
        {
            //list the contents of our cotact forms
            return View(db.PortContactForms);
        }

        public ActionResult Details(int id)
        {
            return View(db.PortContactForms.Find(id));
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {



            return View(db.PortContactForms.Find(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Models.PortContactForm portcontactForms)
        {
            //tell the db context that the cotact form needs to be updated
            db.Entry(portcontactForms).State = System.Data.EntityState.Modified;
            //save changes
            db.SaveChanges();

            //kick the user back to the list
            return RedirectToAction("Index", "Submitted");
        }

        public ActionResult Delete(int id)
        {
            return View(db.PortContactForms.Find(id));
        }

        public ActionResult DeleteConfirm(int id)
        {
            //get the form to delete from the database
            Models.PortContactForm formToDelete = db.PortContactForms.Find(id);

            db.PortContactForms.Remove(formToDelete);

            //save changes
            db.SaveChanges();

            //kick the user back to the list
            return RedirectToAction("Index", "Submitted");



        }
    }
}
