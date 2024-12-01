using Microsoft.AspNetCore.Mvc;

namespace Resume_App.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            var resumeData = new
            {
                Name = "John Doe",
                JobTitle = "Software Engineer",
                ContactInfo = "johndoe@example.com",
                Summary = "A highly motivated software engineer with expertise in web development and cloud computing.",
                Skills = new[] { "C#", ".NET Core", "HTML", "CSS", "JavaScript", "Azure" },
                Experience = new[]
                {
                    new { Company = "TechCorp", Role = "Full Stack Developer", Duration = "2020 - Present" },
                    new { Company = "CodeWorks", Role = "Software Engineer", Duration = "2017 - 2020" }
                },
                Education = new[]
                {
                    new { Degree = "BSc Computer Science", Institution = "XYZ University", Year = "2016" }
                }
            };

            return View(resumeData);
        }
    }
}
