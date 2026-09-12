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
                },

                // Item 5
                new ExamQuestions
                {
                    Id = 5,
                    Question = "What does the following command primarily do? dotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
                    Options = new()
                    {
                        "A - Deletes the database",
                        "B - Creates a new MVC project",
                        "C - Generates EF Core models and a DbContext from an existing database",
                        "D - Starts the MVC application"
                    },
                    CorrectAnswer = "C",
                    Explanation = "The dotnet ef dbcontext scaffold command performs reverse-engineering on an existing database schema to generate entity classes and a DbContext inside the specified folder."
                },

                 // Item 6
                new ExamQuestions
                {
                    Id = 6,
                    Question = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                    Options = new()
                    {
                        "A - Program.cs only",
                        "B - appsettings.json",
                        "C - Index.cshtml",
                        "D - Student.cs"
                    },
                    CorrectAnswer = "B",
                    Explanation = "application configurations and database connection strings are stored in appsettings.json."
                },

                 // Item 7
                new ExamQuestions
                {
                    Id = 7,
                    Question = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                    Options = new()
                    {
                        "A - One-to-One",
                        "B - One-to-Many",
                        "C - Many-to-Many",
                        "D - Many-to-One only"
                    },
                    CorrectAnswer = "B",
                    Explanation = "Because a single Section has multiple Students, this represents a One to Many relationship."
                },

                // Item 8
                new ExamQuestions
                {
                    Id = 8,
                    Question = "In the following example, what is SectionId? public int SectionId { get; set; } public Section Section { get; set; }",
                    Options = new()
                    {
                        "A - Primary key of Student",
                        "B - Foreign key referencing Section",
                        "C - Navigation property",
                        "D - Database connection string"
                    },
                    CorrectAnswer = "B",
                    Explanation = "SectionId is the Foreign Key property that links the Student entity to the primary key of the Section table"
                },

                // Item 9
                new ExamQuestions
                {
                    Id = 9,
                    Question = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                    Options = new()
                    {
                        "A - It stores the database password",
                        "B - It represents a relationship to another entity",
                        "C - It creates a new database",
                        "D - It validates the student's name"
                    },
                    CorrectAnswer = "B",
                    Explanation = "A navigation property provides a reference representing a relationship to another entity, allowing the core to navigate and load related data."
                },

                // Item 10 - i might start doing these by twos i think i have enough commits
                new ExamQuestions
                {
                    Id = 10,
                    Question = "What does .Include() generally allow EF Core to do?",
                    Options = new()
                    {
                        "A - Delete the Section table",
                        "B - Load related Section data together with Students",
                        "C - Create a new Student",
                        "D - Validate Student input"
                    },
                    CorrectAnswer = "B",
                    Explanation = "The 'include' method enables 'eager loading', directing the core to fetch related data in the same database query."
                }

            };

            return View(questions);
        }
    }
}