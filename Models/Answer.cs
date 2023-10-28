using ProfTestium.Models.Contexts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProfTestium.Models
{
    /// <summary>
    ///  Ответы на вопросы теста
    /// </summary>
    public class Answer : BaseId
    {

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Ответ")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Правильный ответ?")]
        public bool Correct { get; set; } = false;


        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Вопрос")]
        public int Query_id { get; set; }
        public virtual Quest Quest { get; set; } = new();


    }
}
