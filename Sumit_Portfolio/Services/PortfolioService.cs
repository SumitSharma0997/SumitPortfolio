using Sumit_Portfolio.Models;

namespace Sumit_Portfolio.Services
{
    public class PortfolioService : IPortfolioService
    {
        public PersonalInfo GetPersonalInfo()
        {
            return new PersonalInfo
            {
                Name = "Sumit Kumar",
                Title = "Software Developer",
                Email = "sumit1997sinha25@gmail.com",
                Phone = "+91-9534649594",
                Location = "Bihar Begusari, India",
                Summary = "Experienced professional with expertise in .NET technologies, ASP.NET Core, C#, Core Api and Dynamic web development. Passionate about creating efficient and scalable web applications with strong problem-solving skills and attention to detail.",
                PhotoUrl = "/Photo/Sumit2.jpg"
            };
        }

        public List<Experience> GetExperiences()
        {
            return new List<Experience>
            {
                new Experience
                {
                    JobTitle = "Website Developer",
                    Company = "Swami Vivekanand Subharti University",
                    Duration = "Apr 2024 - Present",
                    Description = "Developed and maintained web-based applications using C#, ASP.NET, ASP.NET Core, Core API, jQuery, and SQL Server. Built the front-end experience of web applications with responsive user interfaces. Developed RESTful APIs and web services. Optimized database queries and managed SQL Server for improved performance."
                },
                new Experience
                {
                    JobTitle = "Application Developer Intern",
                    Company = "Taksh IT Solution",
                    Duration = "6 Months Noida",
                    Description = "Developed and maintained applications using ASP.NET MVC, C#, SQL Server, HTML, CSS, Bootstrap, and jQuery. Worked with front-end technologies (HTML, CSS, Bootstrap) for responsive UI development. Collaborated with cross-functional teams and streamlined entire business workflows. Optimized database queries and managed SQL Server for improved performance."
                }
            };
        }

        public List<Education> GetEducation()
        {
            return new List<Education>
            {
                new Education
                {
                    Degree = "Master of Computer Applications",
                    Institution = "Noida Institute of Engineering & Technology, Greater Noida",
                    Year = "2021-2023",
                    Grade = "First Division (CGPA: 7.36)"
                }
            };
        }

        public List<Skill> GetSkills()
        {
            return new List<Skill>
            {
                new Skill { Name = "C#", Level = 90, Category = "Programming" },
                new Skill { Name = "ASP.NET Core", Level = 85, Category = "Framework" },
                new Skill { Name = "ASP.NET MVC", Level = 80, Category = "Framework" },
                new Skill { Name = "SQL Server", Level = 80, Category = "Database" },
                new Skill { Name = "jQuery", Level = 75, Category = "Frontend" },
                new Skill { Name = "Bootstrap", Level = 85, Category = "Frontend" },
                new Skill { Name = "HTML/CSS", Level = 75, Category = "Frontend" },
                new Skill { Name = "JavaScript", Level = 70, Category = "Programming" },
                new Skill { Name = "Entity Framework", Level = 80, Category = "ORM" },
                new Skill { Name = "Git", Level = 75, Category = "Tools" },
                new Skill { Name = "Visual Studio", Level = 85, Category = "Tools" },
                new Skill { Name = "VS Code", Level = 70, Category = "Tools" },
                new Skill { Name = ".NET SDK", Level = 75, Category = "Tools" },
                new Skill { Name = "SQL Server Management", Level = 85, Category = "Tools" },
                new Skill { Name = "Postman", Level = 95, Category = "Tools" },
                new Skill { Name = "Swagger", Level = 95, Category = "Tools" }
            };
        }

        public List<Project> GetFeaturedProjects()
        {
            return new List<Project>
            {
                new Project
                {
                    Title = "Enterprise Resource Planning (ERP) System",
                    Description = "An integrated ASP.NET Core and SQL Server based ERP solution designed to manage business operations like sales, inventory, HR, finance, and reporting. The system supports role-based authentication, modular architecture, and dynamic dashboards. It automates key workflows, enhances data accuracy, and provides real-time analytical reports using Entity Framework Core and RESTful APIs.",
                    Technologies = "ASP.NET Core, C#, SQL Server, Entity Framework Core, RESTful APIs",
                    ImageUrl = "/images/erp-system-project.jpg",
                    DemoUrl = "#",
                    GitHubUrl = "#"
                },
                new Project
                {
                    Title = "Smart Collection & Reporting System",
                    Description = "A web-based application built with ASP.NET Core, C#, SQL Server, and Entity Framework to automate data collection and reporting. It provides dynamic filtering, pagination, and export options (Excel/PDF). The system features role-based access, real-time analytics, and interactive dashboards for better monitoring and decision-making across departments.",
                    Technologies = "ASP.NET Core, C#, SQL Server, Entity Framework",
                    ImageUrl = "/images/smart-collection-project.jpg",
                    DemoUrl = "#",
                    GitHubUrl = "#"
                },
                new Project
                {
                    Title = "Online Medical Inventory & Pharmacy System",
                    Description = "Developed using ASP.NET Core, C#, and SQL Server, this system automates the management of medicine stock, supplier records, purchase/sales tracking, and expiry alerts. It includes real-time inventory monitoring, invoice generation, and report exports (Excel/PDF). The solution ensures efficient pharmacy operations with user authentication and a clean, dashboard-based interface.",
                    Technologies = "ASP.NET Core, C#, SQL Server",
                    ImageUrl = "/images/medical-inventory-project.jpg",
                    DemoUrl = "#",
                    GitHubUrl = "#"
                }
            };
        }

        public List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project
                {
                    Title = "ToothTech",
                    Description = "Developed a comprehensive online patient registration and payment system using ASP.NET, C#, SQL Server, and Entity Framework with a secure payment gateway. Built a doctor interface for managing appointments and patient records efficiently. Automated medical record generation and enhanced documentation accuracy, reducing manual errors.",
                    Technologies = "ASP.NET, C#, SQL Server, Entity Framework",
                    ImageUrl = "/images/toothtech-project.jpg",
                    DemoUrl = "#",
                    GitHubUrl = "#"
                },
                new Project
                {
                    Title = "Peon Book",
                    Description = "Designed and developed a reporting and management platform using ASP.NET Core, C#, SQL Server, Entity Framework. Created custom transactional reports and optimized reporting speed.",
                    Technologies = "ASP.NET Core, C#, SQL Server, Entity Framework",
                    ImageUrl = "/images/peon-book-project.jpg",
                    DemoUrl = "#",
                    GitHubUrl = "#"
                },
                new Project
                {
                    Title = "Cluberra Sports Application",
                    Description = "Designed and developed a sports management web application specifically for Badminton clubs using ASP.NET Core, C#, and SQL Server. Implemented player registration, membership management, and tournament scheduling features. Developed modules for booking courts, tracking match results, and managing club finances. Created reporting dashboards for administrators to analyze player performance and club activities. Optimized database design for handling large-scale event registrations and real-time updates. Enhanced user experience with responsive UI using Bootstrap, jQuery, and AJAX for smooth interactions.",
                    Technologies = "ASP.NET Core, C#, SQL Server, Bootstrap, jQuery, AJAX",
                    ImageUrl = "/images/cluberra-sports-project.jpg",
                    DemoUrl = "#",
                    GitHubUrl = "#"
                },
                new Project
                {
                    Title = "Shlen Power",
                    Description = "Performed bug fixes and delivered customized reports for clients. Enhanced system performance and provided tailored reporting solutions.",
                    Technologies = "ASP.NET, C#, SQL Server",
                    ImageUrl = "/images/shlen-power-project.jpg",
                    DemoUrl = "#",
                    GitHubUrl = "#"
                },
                new Project
                {
                    Title = "Medivault",
                    Description = "Developed a comprehensive medical records management system for maintaining patient records and uploading medical prescriptions. System allows healthcare providers to digitally manage patient data, store medical documents, and track patient history efficiently.",
                    Technologies = "ASP.NET Core, C#, SQL Server, Entity Framework, File Upload Management",
                    ImageUrl = "/images/Medivault-project.jpg",
                    DemoUrl = "#",
                    GitHubUrl = "#"
                }
            };
        }

        public ContactInfo GetContactInfo()
        {
            return new ContactInfo
            {
                Email = "sumit1997sinha25@gmail.com",
                Phone = "+91-9534649594",
                LinkedIn = "https://www.linkedin.com/in/sumitsharma123/",
                GitHub = "https://github.com/sumit-kumar",
                Address = "Bihar Begusarai, India"
            };
        }
    }
}
