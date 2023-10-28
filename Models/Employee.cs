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
        [Display(Name = "Активный")]
        public bool Avcive { get; set; } = true;

        [Required]
        public int Department_id { get; set; }
        public string User_id { get; set; }


        public string Phone { get; set; }
        [Required]
        public int Post_id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [ForeignKey("Department_id")]
        public virtual Department Department { get; set; }
        [ForeignKey("Post_id")]
        public virtual Post Post { get; set; }
    }
}
