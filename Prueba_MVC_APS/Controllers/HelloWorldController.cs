using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba_MVC_APS.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }


        // GET: /HelloWorld/Welcome/ 
        /*
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
        */


        // GET: /HelloWorld/Welcome?name=Scott&numtimes=4
        /*
        public string Welcome(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        }
        */


        // GET: /HelloWorld/Welcome/1?name=Scott
        /*
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
        */


        // GET: /HelloWorld/Welcome?name=Scott&numtimes=4
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}