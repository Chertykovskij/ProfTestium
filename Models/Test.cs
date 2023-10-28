using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProfTestium.Models
{
    public class Test
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public int Course_id { get; set; }

        public virtual Course Course { get; set; } = new();
    }
}
