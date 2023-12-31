﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace ProfTestium.Models.Contexts
{

    public class ProfTestiumContext : IdentityDbContext
    {
        public ProfTestiumContext(DbContextOptions<ProfTestiumContext> options) : base(options)
        {
        }
        //Коммент
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Для добавления таблиц пользователей
            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
            });

            modelBuilder.Entity<Course>()
            .HasMany(hs => hs.Employee)
            .WithMany(h => h.Courses)
            .UsingEntity<Dictionary<string, object>>(
                "CourseEmployee",
                j => j.HasOne<Employee>().WithMany().HasForeignKey("EmployeeId").OnDelete(DeleteBehavior.NoAction),
                j => j.HasOne<Course>().WithMany().HasForeignKey("CourseId").OnDelete(DeleteBehavior.NoAction),
                j =>
                {
                    j.Property<int>("Id").UseIdentityColumn();
                    j.HasKey("Id");
                });
            modelBuilder.Entity<Raiting>()
                .HasOne(r => r.Test)
                .WithMany(t => t.Raitings)
                .HasForeignKey(r => r.Test_id)
                .OnDelete(DeleteBehavior.NoAction);


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

