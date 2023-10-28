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

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Описание курса")]
        public string Description { get; set; }


        [Required]
        [Display(Name = "Организация-владлец курса")]
        public int Organization_Id { get; set; }
        public virtual Organization Organization { get; set; }

        [Display(Name = "Курс действует?")]
        public bool Active { get; set; } = true;

        [Display(Name = "Файл с методическими материалами для курса")]
        public string FileCourse { get; set; }
        
        /// <summary>
        /// Тесты в курсе
        /// </summary>
        public List<Test> Test { get; set; } = new();
    }
}
