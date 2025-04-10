using Almajed_Services_Website.Models;
using Microsoft.EntityFrameworkCore;
namespace Almajed_Services_Website.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }
        public DbSet<JobRequests> JobRequests { get; set; }
        public DbSet<ContactMessage> contactMessages { get; set; }
        public DbSet<RequestForQuotation> requestForQuotations { get; set; }

    }
}
