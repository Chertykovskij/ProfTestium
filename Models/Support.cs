using System.ComponentModel.DataAnnotations;

namespace ProfTestium.Models
{
    /// <summary>
    /// Основной сайт: техподдержка
    /// </summary>
    public class Support : BaseId
    {
        /// <summary>
        /// Заголовок
        /// </summary>
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Название")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Номер телефона")]
        public string Phone { get; set; } = string.Empty;


    }
}
