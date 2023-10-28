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
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Описание курса")]
        public string Description { get; set; } = string.Empty;


        [Required]
        [Display(Name = "Организация-владлец курса")]
        public int Organization_Id { get; set; }
        public virtual Organization Organization { get; set; } = new();

        [Display(Name = "Курс действует?")]
        public bool Active { get; set; } = true;

        [Display(Name = "Файл с методическими материалами для курса")]
        public string FileCourse { get; set; }= string.Empty;
        
        /// <summary>
        /// Тесты в курсе
        /// </summary>
        public List<Test> Test { get; set; } = new();

        public List<Employee> Employee { get; set; } = new List<Employee> { };
    }
}
