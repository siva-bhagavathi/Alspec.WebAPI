using Alspec.WebAPI.Models;
using Alspec.WebAPI.Repository.Interface;
using Alspec.WebAPI.DatabaseContext;
using System;
using Microsoft.EntityFrameworkCore;

namespace Alspec.WebAPI.Repository.Services
{
    public class JobRepository:IJobRepository
    {
        private readonly ApplicationDBContext appDbContext;

        public JobRepository(ApplicationDBContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Job>> GetJobs()
        {
            return await appDbContext.Jobs.ToListAsync();
        }

        public async Task<Job> GetJob(string id)
        {
            return await appDbContext.Jobs.FirstOrDefaultAsync(e => e.Id== id);
        }
        public async Task<Job> CreateJob(Job job)
        {
            var result = await appDbContext.Jobs.AddAsync(job);
            await appDbContext.SaveChangesAsync();
            return job;
        }

        public Task<Job> UpdateJob(string id, Job job)
        {
            throw new NotImplementedException();
        }

        public Task<Job> DeleteJob(string id)
        {
            throw new NotImplementedException();
        }
    }
}
