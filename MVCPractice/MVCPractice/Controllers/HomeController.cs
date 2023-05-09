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
            //Can write out to a file
            //string text = "hello";
            // System.IO.File.WriteAllText(@"C:\users\amy\DeskTop\samplelog.txt",text);

            // Random rnd = new Random(10);
            // var num = rnd.Next();
            //print number out viewbag is like a dictionary. Throw in any data type can send to the view
            //ViewBag.RandomNumber = num;

            //How to return a differnt view
            // if (num>3)
            // {
            //     return View("About");
            // }
            //return View();
            //Can return content as well - used sometimes when you want to return nothing. 
            //return Content("Hello");
           // return RedirectToAction("Contact");
            return View();
       }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            throw new Exception("Invalid Page");
            return View();
        }

        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}