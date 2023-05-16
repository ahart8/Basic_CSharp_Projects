using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                //Map our database objet to a veiw model
                //var signups = db.Signups.Where(x=>x.Removed==null).ToList();//db.Signups represents all the records in the database
                var signups = (from c in db.Signups
                               where c.Removed == null
                               select c).ToList();//linq syntax
                var signupVms = new List<SignupVm>();
                foreach (var signup in signups)
                {
                    //Grabbing the record from the list and passing it to the view model
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;

                    //Add to the list
                    signupVms.Add(signupVm);
                }
                //We are passing the list to the view 
                return View(signupVms);
            }
        }
        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.Signups.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}