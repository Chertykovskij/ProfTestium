using ProfTestium.Models.Contexts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProfTestium.Models
{
    /// <summary>
    /// Назначенные курсы сотруднику
    /// </summary>
    public class CourseEmployee : BaseId
    {
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Сотрудник")]
        public int Employee_id { get; set; }
        public virtual Employee Employee { get; set; } = new();

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Курс")]
        public int Course_id { get; set; }
        public virtual Course Course { get; set; } = new();

        [Display(Name = "Дествующее назначение?")]
        public bool Active { get; set; } = true;
    }
}
