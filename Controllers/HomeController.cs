using Microsoft.AspNetCore.Mvc;
using DenzelPortfolio.Models;

namespace DenzelPortfolio.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var cvModel = new CVModel
        {
            Name = "Denzel Pawandiwa",
            Location = "Johannesburg, South Africa",
            Phone = "071 234 5678",
            Email = "st10457186@myemeris.edu.za",
            
            SkillCategories = new List<SkillCategory>
            {
                new()
                {
                    Title = "Technical Skills",
                    Skills = new List<string>
                    {
                        "C#, Java",
                        "ASP.NET Core MVC",
                        "Entity Framework Core",
                        "SQL Server",
                        "HTML, CSS, JavaScript",
                        "Azure Deployment & Blob Storage",
                        "OOP & MVC Architecture"
                    }
                },
                new()
                {
                    Title = "Cybersecurity & Systems",
                    Skills = new List<string>
                    {
                        "Input Validation & Secure Coding",
                        "Basic NLP & Keyword Recognition",
                        "Sentiment Detection Logic",
                        "Firewall & Network Security Concepts",
                        "UML Diagrams & System Analysis"
                    }
                }
            },
            
            Projects = new List<Project>
            {
                new()
                {
                    Name = "ChatBot",
                    Description = "An intelligent chatbot application featuring natural language processing capabilities, keyword recognition, and sentiment detection logic for interactive user conversations.",
                    GitHubUrl = "https://github.com/Pawandiwa-Denzel/ChatBot.git",
                    Technologies = new List<string> { "C#", "NLP", "Sentiment Analysis", "Console Application" }
                },
                new()
                {
                    Name = "CLDV Part 2",
                    Description = "A comprehensive cloud development project showcasing Azure deployment, blob storage integration, and secure web application architecture with database connectivity.",
                    GitHubUrl = "https://github.com/Pawandiwa-Denzel/CLDV-PART-2.git",
                    Technologies = new List<string> { "ASP.NET Core", "Azure", "Blob Storage", "Entity Framework", "SQL Server" }
                }
            },
            
            Tools = new List<string>
            {
                "Visual Studio",
                "SSMS",
                "Azure Portal",
                "Git (Basic)",
                "Microsoft Office"
            },
            
            Strengths = new List<string>
            {
                "Problem Solver",
                "Fast Learner",
                "Detail-Oriented",
                "Self-Motivated",
                "Strong Analytical Thinking"
            }
        };

        return View(cvModel);
    }
}
