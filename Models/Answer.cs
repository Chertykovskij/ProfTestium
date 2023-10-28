using ProfTestium.Models.Contexts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProfTestium.Models
{
    public class Answer: BaseId
    {
    
        [Required]
        public string Title { get; set; }
        [Required]
        public bool Correct { get; set; }
        [Required]
        public int Query_id { get; set; }
        [ForeignKey("Query_id")]
        public virtual Quest Quest { get; set; }
    }
}
