using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProfTestium.Models
{
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
}
