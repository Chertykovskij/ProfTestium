using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProfTestium.Models
{
    public class Quest : BaseId
    {
        /// <summary>
        /// Вопрос
        /// </summary>
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Вопрос")]
        public string Title { get; set; } = string.Empty;
        public int? Test_id { get; set; }
        public virtual Test Test { get; set; }

        /// <summary>
        /// Ответы
        /// </summary>
        List<Answer> Answers { get; set; } = new List<Answer>();
    }
}
