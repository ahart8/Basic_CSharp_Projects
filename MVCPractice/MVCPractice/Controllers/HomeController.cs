using MVCPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class HomeController : Controller
    {
        //index is the default route 
        
        public ActionResult Index()
        {

            User user = new User();
            user.Id = 1;
            user.FirstName = "Amy";
            user.LastName = "Hart";
            user.Age = 52;


            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
          
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}