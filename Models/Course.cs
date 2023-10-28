using ProfTestium.Models.Contexts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProfTestium.Models
{
    /// <summary>
    /// Курс содерожащий тест и материал
    /// </summary>
    public class Course: BaseId
    {
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Наименование курса")]
        public string Title { get; set; }

        [Display(Name = "Наименование курса")]
        public string Description { get; set; }
        [Required]
        public int Organization_Id { get; set; }
        [Required]
        public bool Active { get; set; }
        public string FileCourse { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
