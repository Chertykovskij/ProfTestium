using System.ComponentModel.DataAnnotations;

namespace ProfTestium.Models
{
    public class Post
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
