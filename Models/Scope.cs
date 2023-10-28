using System.ComponentModel.DataAnnotations;

namespace ProfTestium.Models
{
    /// <summary>
    /// Основной сайт: возможности
    /// </summary>
    public class Scope : BaseId
    {
        /// <summary>
        /// Заголовок
        /// </summary>
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Название возможности")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Текст
        /// </summary>
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Текст")]
        public string Text { get; set; } = string.Empty;
    }
}
