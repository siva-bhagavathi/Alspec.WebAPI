using Alspec.WebAPI.Models;
using Alspec.WebAPI.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Alspec.WebAPI.Controllers
{
    public class JobController: ControllerBase
    {
        private readonly IJobRepository jobRepository;
        public JobController(IJobRepository jobRepository)
        {
            this.jobRepository = jobRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<Job>> GetJobs()
        {
            return await jobRepository.GetJobs();
        }
        [HttpGet("{id}")]
        public async Task<Job> GetJob(string id)
        {
            return await jobRepository.GetJob(id);
        }
        [HttpPost]
        public async Task<Job> CreateJob(Job job)
        {
            return await jobRepository.CreateJob(job);
        }
        [HttpPut("{id}")]
        public async Task<Job> UpdateJob(string id, Job job)
        {
            return await jobRepository.UpdateJob(id, job);
        }
        [HttpDelete("{id}")]
        public async Task<Job> DeleteJob(string id)
        {
            return await jobRepository.DeleteJob(id);
        }
    }
}
