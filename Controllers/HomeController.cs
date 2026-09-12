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
                // this would be so much easier if automated but i will stay strong and drink my 3rd cup of coffee today
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
                },

                // Item 3
                new ExamQuestions
                {
                    Id = 3,
                    Question = "What is the primary purpose of Entity Framework Core?",
                    Options = new()
                    {
                        "A - To create HTML pages automatically",
                        "B - To replace the MVC Controller",
                        "C - To map objects in code to relational database data",
                        "D - To replace the C# compiler"
                    },
                    CorrectAnswer = "C",
                    Explanation = "Entity Framework Core is an Object-Relational Mapper (ORM) designed to bridge and map object-oriented C# models to relational database tables."
                },

                // Item 4
                new ExamQuestions
                {
                    Id = 4,
                    Question = "Which EF Core component is primarily responsible for communicating with the database?",
                    Options = new()
                    {
                        "A - DbContext",
                        "B - DbSetView",
                        "C - ControllerContext",
                        "D - RazorContext"
                    },
                    CorrectAnswer = "A",
                    Explanation = "The DbContext instance manages database connections, executes queries, tracks entity changes, and saves changes back to the database."
                }
            };

            return View(questions);
        }
    }
}