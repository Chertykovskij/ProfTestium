using Microsoft.EntityFrameworkCore;

namespace ProfTestium.Models.Contexts
{

    public class ProfTestiumContext : DbContext
    {
        public ProfTestiumContext(DbContextOptions<ProfTestiumContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
           .HasMany(hs => hs.Employee)
           .WithMany(h => h.Courses)
           .UsingEntity<Dictionary<string, object>>(
               "CourseEmployee",
               j => j.HasOne<Employee>().WithMany().HasForeignKey("EmployeeId"),
               j => j.HasOne<Course>().WithMany().HasForeignKey("CourseId"),
               j =>
               {
                   j.Property<int>("Id").UseIdentityColumn();
                   j.HasKey("Id");
               });            
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<Raiting> Raitings { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Scope> Scopes { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Support> Supports { get; set; }
        
    }



}

