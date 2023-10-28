using Microsoft.Extensions.Hosting;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNet.Identity;

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
        public DbSet<CourseEmployee> CourseEmployees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Portal> Portals { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<Raiting> Raitings { get; set; }
        public DbSet<Test> Tests { get; set; }
    }



}

