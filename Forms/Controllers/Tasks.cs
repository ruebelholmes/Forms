using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forms.Controllers
{
    public class TaskController : Controller
    {   
        // GET: Tasks
        public ActionResult Index()
        {
            return View();
        }



    }


}