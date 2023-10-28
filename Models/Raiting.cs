using ProfTestium.Models.Contexts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProfTestium.Models
{
    /// <summary>
    /// Оценка сотрудника за тест
    /// </summary>
    public class Raiting : BaseId
    {        
        public int Employee_id { get; set; }

        public virtual Employee Employee { get; set; } = new Employee();   
        
        public int Value { get; set; }
        
        public int Test_id { get; set; }

        public virtual Test Test { get; set; } = new Test();

        /// <summary>
        /// Дата прохождения
        /// </summary>
        public DateTime DatePassage { get; set; } = DateTime.Now;
    }
}
