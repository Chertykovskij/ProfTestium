using System.ComponentModel.DataAnnotations;

namespace ProfTestium.Models
{
    /// <summary>
    /// Общие настройки (пока не понятно зачем)
    /// </summary>
    public class Portal : BaseId
    {
        public string Title { get; set; } = "";
        public string Logo { get; set; } = "";
        public string Contents { get; set; } = "";
        [Required]
        public string SuperAdmin { get; set; } = "";
    }
}
