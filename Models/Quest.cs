using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProfTestium.Models
{
    public class Quest
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int? Test_id { get; set; }
        [ForeignKey("Test_id")]
        public virtual Test Test { get; set; }
    }
}
