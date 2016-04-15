using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forms.Models;

namespace Forms.Controllers
{
    public class TasksController : Controller
    {
        // GET: Tasks
        [HttpGet]
        public ActionResult Index()
        {
            List<Tasks> currentTasks;
            currentTasks = (List<Tasks>) Session["tasks"];
            new List<Tasks>();
            return View(currentTasks);
        }

        // POST: Tasks/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                var currentTasks = (List<Tasks>) Session["tasks"];
                if (currentTasks == null)
                {
                    currentTasks = new List<Tasks>();
                }
                currentTasks.Add(newTask);

                Session["tasks"] = currentTasks;
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }
    }
}
