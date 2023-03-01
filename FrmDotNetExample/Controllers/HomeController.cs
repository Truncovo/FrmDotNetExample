using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace FrmDotNetExample.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Home()
        {
            
            return View("Index");
        }
    }
}