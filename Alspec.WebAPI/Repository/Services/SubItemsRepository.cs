using Alspec.WebAPI.DatabaseContext;
using Alspec.WebAPI.Models;
using Alspec.WebAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Alspec.WebAPI.Repository.Services
{
    public class SubItemsRepository:IJobSubItemRepository
    {
        private readonly ApplicationDBContext appDbContext;

        public SubItemsRepository(ApplicationDBContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IEnumerable<SubItem>> GetSubItems()
        {
            return await appDbContext.SubItems.ToListAsync();
        }

        public async Task<SubItem> GetSubItem(string id)
        {
            return await appDbContext.SubItems.FirstOrDefaultAsync(e => e.ItemId == id);
        }
        public async Task<SubItem> CreateSubItem(SubItem subItem)
        {
            var result = await appDbContext.SubItems.AddAsync(subItem);
            await appDbContext.SaveChangesAsync();
            return subItem;
        }

        public Task<IEnumerable<SubItem>> GetSubItems(string jobId)
        {
            throw new NotImplementedException();
        }

        public SubItem GetSubItem(string jobId, string subItemId)
        {
            throw new NotImplementedException();
        }
    }
}
