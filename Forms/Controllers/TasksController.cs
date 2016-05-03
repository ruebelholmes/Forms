using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using FormsMVC.Models;

namespace FormsMVC.Controllers
{
    public class TasksController : Controller
    {
        public List<Task> tasks { get; set; } = new List<Task>();

        // GET: Task
        [HttpGet]
        public ActionResult Index(string task)
        {
            List<Task> currentTasks;
            currentTasks = (List<Task>)Session["tasks"] ?? new List<Task>();
            return View(currentTasks);
        }

        //Create new task
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tasks/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, Tasks newTask)
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
