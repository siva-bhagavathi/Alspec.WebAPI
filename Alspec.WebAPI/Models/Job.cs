namespace Alspec.WebAPI.Models
{
    public class Job
    {
        public int JobId { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<SubItem> SubItems { get; set; }


    }
}
