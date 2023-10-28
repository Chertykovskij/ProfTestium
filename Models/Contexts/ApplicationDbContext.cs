using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProfTestium.Models.Contexts
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private readonly DbContextOptions _options;

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
