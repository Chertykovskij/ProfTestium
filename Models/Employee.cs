using Newtonsoft.Json;
using ProfTestium.Models.Contexts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProfTestium.Models
{
    /// <summary>
    /// Сотрудник
    /// </summary>
    public class Employee : BaseId
    {
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Фамилия Имя Отчество")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Действующий")]
        public bool Avcive { get; set; } = true;

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Департамент в котором работает сотрудник")]
        public int Department_id { get; set; }
        public virtual Department Department { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Связанный пользователь")]
        public string User_id { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Номер телефона")]
        public string Phone { get; set; }


        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Должность")]
        public int Post_id { get; set; }
        public virtual Post Post { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Дата приема на работу")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Дата увольнения")]
        public DateTime? EndDate { get; set; }

       

        /// <summary>
        /// Рейтинги сортудника по тестам
        /// </summary>
        public List<Raiting> Raiting { get; set; } = new();

    }
}
