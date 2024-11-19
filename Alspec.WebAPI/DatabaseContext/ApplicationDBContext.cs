using Alspec.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Alspec.WebAPI.DatabaseContext
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options) // creating constructor with options of the base class DBContext
        {
        }
        public ApplicationDBContext() { }

        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<SubItem> SubItems { get; set; }

    }
}
