using Microsoft.AspNetCore.Mvc;
using PrefinalExamApp.Models;

namespace PrefinalExamApp.Controllers
{
    public class HomeController : Controller
    {
        public static readonly List<ExamQuestions> Questions = new();

        public IActionResult Index()
        {
            return View(Questions);
        }
    }
}