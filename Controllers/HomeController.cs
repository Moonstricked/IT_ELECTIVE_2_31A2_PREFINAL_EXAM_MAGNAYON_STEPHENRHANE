using Microsoft.AspNetCore.Mvc;
using PrefinalExamApp.Models;

namespace PrefinalExamApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var questions = new List<ExamQuestions>
            {
                // these should all be like taken from
                new ExamQuestions
                {
                    Id = 1,
                    Question = "What is the main problem solved by using a database instead of an in-memory collection?",
                    Options = new()
                    {
                        "A. It makes C# code shorter",
                        "B. It prevents the application from restarting",
                        "C. It allows data to persist after the application stops",
                        "D. It removes the need for MVC"
                    },
                    CorrectAnswer = "C.",
                    Explanation = "inmemory collections lose data upon application restart; relational databases provide storage that persists even after restarting."
                }
            };

            return View(questions);
        }
    }
}