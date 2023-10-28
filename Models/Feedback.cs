using System.ComponentModel.DataAnnotations;

namespace ProfTestium.Models
{
    /// <summary>
    /// Основной сайт: Отзывы
    /// </summary>
    public class Feedback : BaseId
    {

            /// <summary>
            /// Автор
            /// </summary>
            [Required(ErrorMessage = "Поле должно быть заполнено")]
            [Display(Name = "Автор")]
            public string Author { get; set; } = string.Empty;

            /// <summary>
            /// Текст отзыва
            /// </summary>
            [Required(ErrorMessage = "Поле должно быть заполнено")]
            [Display(Name = "Текст отзыва")]
            public string Text { get; set; } = string.Empty;

        /// <summary>
        /// Дата отзыва
        /// </summary>
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Дата отзыва")]
        public DateTime Date { get; set; }


        /// <summary>
        /// Оценка от 1 до 5
        /// </summary>
        [Range(1, 5, ErrorMessage = "Не корректное значение")]
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Оценка")]
        public int Rating { get; set; } = 5;


        [Required]
        [Display(Name = "Действующий")]
        public bool Avcive { get; set; } = true;
    }
}
