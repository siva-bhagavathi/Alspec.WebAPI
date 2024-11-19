using System.ComponentModel.DataAnnotations;

namespace Alspec.WebAPI.Models
{
    public class SubItem
    {
        [Key]
        public int SubItemId { get; set; }
        public string ItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public string Status { get; set; }
    }
}