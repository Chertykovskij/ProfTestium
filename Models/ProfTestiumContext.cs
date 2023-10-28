using Microsoft.Extensions.Hosting;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ProfTestium.Models
{

    public class ProfTestiumContext : DbContext
    {
        public ProfTestiumContext(DbContextOptions<ProfTestiumContext> options) : base(options)
        {
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

    public class Answer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public bool Correct { get; set; }
        [Required]
        public int Query_id { get; set; }
        [ForeignKey("Query_id")]
        public virtual Quest Quest { get; set; }
    }

    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public int Organization_Id { get; set; }
        [Required]
        public bool Active { get; set; }
        public string FileCourse { get; set; }
        [ForeignKey("Organization_Id")]
        public virtual Organization Organization { get; set; }
    }

    public class CourseEmployee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Employee_id { get; set; }
        [Required]
        public int Course_id { get; set; }
        [ForeignKey("Employee_id")]
        public virtual Employee Employee { get; set; }
        [ForeignKey("Course_id")]
        public virtual Course Course { get; set; }
    }

    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? GeneralEmployee_id { get; set; }
        public string Phone { get; set; }
        [Required]
        public int Organization_id { get; set; }
        public int? Depart_id { get; set; }
        [ForeignKey("Organization_id")]
        public virtual Organization Organization { get; set; }
    }

    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public bool Avcive { get; set; }
        [Required]
        public int Department_id { get; set; }
        public string User_id { get; set; }
        public string Phone { get; set; }
        [Required]
        public int Post_id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [ForeignKey("Department_id")]
        public virtual Department Department { get; set; }
        [ForeignKey("Post_id")]
        public virtual Post Post { get; set; }
    }

    public class Organization
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Adress { get; set; }
        public string INN { get; set; }
        public string Logo { get; set; }
        public string ColorProfile { get; set; }
        [Required]
        public bool Active { get; set; }
        [Required]
        public string UserAdmin { get; set; }
        public string Phone { get; set; }
    }

    public class Portal
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Logo { get; set; }
        public string Contents { get; set; }
        [Required]
        public string SuperAdmin { get; set; }
    }

    public class Post
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Title { get; set; }
    }

    public class Quest
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int? Test_id { get; set; }
        [ForeignKey("Test_id")]
        public virtual Test Test { get; set; }
    }

    public class Raiting
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Employee_id { get; set; }
        [Required]
        public int Value { get; set; }
        [Required]
        public int Test_id { get; set; }
        [Required]
        public DateTime DatePassage { get; set; }
        [ForeignKey("Employee_id")]
        public virtual Employee Employee { get; set; }
        [ForeignKey("Test_id")]
        public virtual Quest Quest { get; set; }
    }

    public class Test
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Course_id { get; set; }
        [ForeignKey("Course_id")]
        public virtual Course Course { get; set; }
    }


}

