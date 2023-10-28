using ProfTestium.Models.Contexts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProfTestium.Models
{
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
}
