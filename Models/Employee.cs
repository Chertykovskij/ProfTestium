using ProfTestium.Models.Contexts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProfTestium.Models
{
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
}
