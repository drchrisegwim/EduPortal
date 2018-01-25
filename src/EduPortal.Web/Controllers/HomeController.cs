using EduPortal.Core;
using EduPortal.Core.Entities;
using System;
using System.Web.Mvc;

namespace EduPortal.Web.Controllers
{
    public class HomeController : Controller
    {
        public readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }


        public ActionResult Index()
        {
            var courses = _unitOfWork.Courses.GetAll();
            return View(courses);
        }

        public ActionResult AddCourse()
        {
            _unitOfWork.Courses.Add(new Course
            {
                Name = "New Course at" + DateTime.Now.ToShortDateString(),
                Description = "Description",
                AuthorId = 1,
                FullPrice = 49,
                Level = 1
            });
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}