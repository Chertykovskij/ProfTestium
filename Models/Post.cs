using System.ComponentModel.DataAnnotations;

namespace ProfTestium.Models
{
    /// <summary>
    /// Должность
    /// </summary>
    public class Post : BaseId
    {
        [Required]
        public string Title { get; set; }

    }
}
