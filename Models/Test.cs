using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProfTestium.Models
{
    public class Test : BaseId
    {
        /// <summary>
        /// Заголовок(наименование)
        /// </summary>
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Название")]
        public string Title { get; set; } = "";

        /// <summary>
        /// Описание
        /// </summary>
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Описание")]
        public string Description { get; set; } = "";

        /// <summary>
        /// Учебный материал
        /// </summary>
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Учебный материал")]
        public int Course_id { get; set; }
        [Display(Name = "Учебный материал")]
        public virtual Course Course { get; set; } = new();

        public List<Raiting> Raitings { get; set; } = new();

        public List<Quest> Questions { get; set; } = new();
    }
}
