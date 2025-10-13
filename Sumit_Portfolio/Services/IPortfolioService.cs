using Sumit_Portfolio.Models;

namespace Sumit_Portfolio.Services
{
    public interface IPortfolioService
    {
        PersonalInfo GetPersonalInfo();
        List<Experience> GetExperiences();
        List<Education> GetEducation();
        List<Skill> GetSkills();
        List<Project> GetFeaturedProjects();
        List<Project> GetProjects();
        ContactInfo GetContactInfo();
    }
}
