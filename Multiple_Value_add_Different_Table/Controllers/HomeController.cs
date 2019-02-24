using Multiple_Value_add_Different_Table.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Multiple_Value_add_Different_Table.Controllers
{
    public class HomeController : Controller
    {
        MultiPle_Table__data_insertEntities db = new MultiPle_Table__data_insertEntities();
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
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult StudentRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StudentRegistration(Student sTU, string username )
        {
          
            db.Students.Add(sTU);
            StudentPassword stp = new StudentPassword();
            stp.Username = username;
            stp.Password = "123456";
            stp.StudentId = sTU.StudentId;
            db.StudentPasswords.Add(stp);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult StudentShow()
        {
            return View(db.Students.ToList());
        }

        public ActionResult StudentPssword()
        {
            return View(db.StudentPasswords.ToList());
        }



    }
}