using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TasksApp.Models;

namespace TasksApp.Controllers
{
    public class HomeController : Controller
    {
        // In-memory task list (no DB)
        private static List<TaskItem> _tasks = new();
        private static int _id = 1;

        public IActionResult Index()
        {
            return View(_tasks);
        }

        [HttpPost]
        public IActionResult Add(string title)
        {
            if (!string.IsNullOrWhiteSpace(title))
            {
                _tasks.Add(new TaskItem
                {
                    Id = _id++,
                    Title = title,
                    IsCompleted = false
                });
            }

            return RedirectToAction("Index");
        }

        public IActionResult Complete(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.IsCompleted = true;
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                _tasks.Remove(task);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

namespace TasksApp.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
