using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baitap2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetInfo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetInfo(string HoTenSv, string Tuoi, string Lop)
        {
            ViewBag.ten = HoTenSv;
            ViewBag.Tuoi = Tuoi;
            ViewBag.Lop = Lop;
            return View();
        }

    }
}