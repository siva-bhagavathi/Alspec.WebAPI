using Alspec.WebAPI.Models;

namespace Alspec.WebAPI.Repository.Interface
{
    public interface IJobRepository
    {
        Task<IEnumerable<Job>> GetJobs();
        Task<Job> GetJob(string id);
        Task<Job> CreateJob(Job job);
        Task<Job> UpdateJob(string id, Job job);
        Task<Job> DeleteJob(string id);
        
    }
}
