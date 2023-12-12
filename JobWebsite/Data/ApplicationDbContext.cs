using Microsoft.EntityFrameworkCore;
using JobWebsite.Models;

namespace JobWebsite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<JobApplication> JobApplications { get; set; }
    }
}
