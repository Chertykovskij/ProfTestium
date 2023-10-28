using System.ComponentModel.DataAnnotations;

namespace ProfTestium.Models
{
    /// <summary>
    /// Для служебной инфы наследуется всеми классами моделей
    /// </summary>
    public class BaseId
    {
        [Key]
        public int Id { get; set; }
    }
}
