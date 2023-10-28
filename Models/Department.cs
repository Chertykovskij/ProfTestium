using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProfTestium.Models
{
    /// <summary>
    /// Депаратмент организации
    /// </summary>
    public class Department : BaseId
    {

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Наименование департамента")]
        public string Name { get; set; }

        [Display(Name = "Наименование департамента")]
        public int? GeneralEmployee_id { get; set; }

    
        [Display(Name = "Номре телефона департамента")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Организация к которой отностится департамент")]
        public int Organization_id { get; set; }

        [Display(Name = "Подчинятеся")]
        public int? Depart_id { get; set; }
        public virtual Organization Organization { get; set; } = new();

        /// <summary>
        ///Сотрудники в депортаменте
        /// </summary>
        public List<Employee> Employee { get; set; } = new();
    }
}
