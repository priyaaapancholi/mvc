using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCdemo.Models;


namespace MVCdemo.Controllers
{
    public class movieController : Controller
    {
        // GET: movie
        public ActionResult movieview()
        {
            var moviemodel = new moviemodel()
            {
                id = 1,
                name = "rustom"
            };
            return View(moviemodel);
        }
    }
}