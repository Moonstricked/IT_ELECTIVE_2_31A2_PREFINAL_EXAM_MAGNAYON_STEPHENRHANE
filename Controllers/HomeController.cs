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
                // Item 1
                new ExamQuestions
                {
                    Id = 1,
                    Question = "What is the main problem solved by using a database instead of an in-memory collection?",
                    Options = new()
                    {
                        "A - It makes C# code shorter",
                        "B - It prevents the application from restarting",
                        "C - It allows data to persist after the application stops",
                        "D - It removes the need for MVC"
                    },
                    CorrectAnswer = "C",
                    Explanation = "In-memory collections lose their stored data once the application stops or restarts, whereas a database provides persistent storage across application lifecycles."
                },

                // Item 2
                new ExamQuestions
                {
                    Id = 2,
                    Question = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                    Options = new()
                    {
                        "A - Code-First",
                        "B - Database-First",
                        "C - Model-First",
                        "D - Controller-First"
                    },
                    CorrectAnswer = "B",
                    Explanation = "The Database-First approach reverse engineers an existing database schema to automatically generate entity classes and a DbContext."
                }
            };

            return View(questions);
        }
    }
}