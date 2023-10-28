using ProfTestium.Models.Contexts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProfTestium.Models
{
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
}
