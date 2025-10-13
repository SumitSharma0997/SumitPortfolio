using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sumit_Portfolio.Models;
using Sumit_Portfolio.Services;

namespace Sumit_Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPortfolioService _portfolioService;

        public HomeController(ILogger<HomeController> logger, IPortfolioService portfolioService)
        {
            _logger = logger;
            _portfolioService = portfolioService;
        }

        public IActionResult Index()
        {
            var personalInfo = _portfolioService.GetPersonalInfo();
            var skills = _portfolioService.GetSkills();
            var projects = _portfolioService.GetFeaturedProjects();
            
            ViewBag.PersonalInfo = personalInfo;
            ViewBag.Skills = skills;
            ViewBag.Projects = projects;
            
            return View();
        }

        public IActionResult About()
        {
            var personalInfo = _portfolioService.GetPersonalInfo();
            var experiences = _portfolioService.GetExperiences();
            var education = _portfolioService.GetEducation();
            
            ViewBag.PersonalInfo = personalInfo;
            ViewBag.Experiences = experiences;
            ViewBag.Education = education;
            
            return View();
        }

        public IActionResult Skills()
        {
            var skills = _portfolioService.GetSkills();
            return View(skills);
        }

        public IActionResult Projects()
        {
            var projects = _portfolioService.GetProjects();
            return View(projects);
        }

        public IActionResult Contact()
        {
            var contactInfo = _portfolioService.GetContactInfo();
            return View(contactInfo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
