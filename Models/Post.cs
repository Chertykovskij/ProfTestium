using System.ComponentModel.DataAnnotations;

namespace ProfTestium.Models
{
    public class Post : BaseId
    {
        [Required]
        public string Title { get; set; }
    }
}
