using System.ComponentModel.DataAnnotations;

namespace ProfTestium.Models
{
    /// <summary>
    /// Должность
    /// </summary>
    public class Post : BaseId
    {
        /// <summary>
        /// Должность
        /// </summary>
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Должность")]
        public string Title { get; set; } = string.Empty;
    }
}
