using MyMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVC5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(String id)
        {
            MyModel myobj = new MyModel();
            myobj.NAME = "THU VIEN LAP TRINH";
            myobj.PHONE = "0912366017";

            ViewBag.ThuocTinhA = 1;
            ViewBag.ThuocTinhB = "ABCXXX";
            ViewBag.Message = "Your application description page."+id;
            ViewBag.OB = myobj;

            return View(myobj);
        }

        public ActionResult Contact(string hello)
        {
            ViewBag.Message = "Your contact page."+hello;
            return View();
        }
    }
}