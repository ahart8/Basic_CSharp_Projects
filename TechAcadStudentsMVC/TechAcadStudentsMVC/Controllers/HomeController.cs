using System.Collections.Generic;
using System.Web.Mvc;
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page - The Tech Academy.";

            return View();
        }

        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;
            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                FirstName = "Amy",
                LastName = "Hart"
            };
            return View(dayTimeInstructor);
        }
        public ActionResult Instructors()
        {

            List<Instructor> instructors = new List<Instructor>
          {
                new Instructor
                {
                Id=1,
                FirstName="Amy",
                LastName="Hart"
            },
            new Instructor
            {
                Id = 2,
                FirstName = "Floyd",
                LastName = "Hart"
            },
             new Instructor
             {
                 Id = 3,
                 FirstName = "River",
                 LastName = "Hart"
             },
              new Instructor
              {
                  Id = 4,
                  FirstName = "Lacy",
                  LastName = "Hart"
              }

            };

            return View(instructors);
        }
    }
}