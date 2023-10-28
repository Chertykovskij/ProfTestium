using ProfTestium.Models.Contexts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProfTestium.Models
{
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
}
