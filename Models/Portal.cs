using System.ComponentModel.DataAnnotations;

namespace ProfTestium.Models
{
    public class Portal : BaseId
    {

        [Required]
        public string Title { get; set; }
        public string Logo { get; set; }
        public string Contents { get; set; }
        [Required]
        public string SuperAdmin { get; set; }
    }
}
