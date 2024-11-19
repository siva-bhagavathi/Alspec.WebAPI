using Alspec.WebAPI.Models;

namespace Alspec.WebAPI.Repository.Interface
{
    public interface IJobSubItemRepository
    {
        Task<IEnumerable<SubItem>> GetSubItems(string jobId);
        SubItem GetSubItem(string jobId, string subItemId);

        
      
    }
}
