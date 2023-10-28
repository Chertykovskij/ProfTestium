using System.ComponentModel.DataAnnotations;

namespace ProfTestium.Models
{   /// <summary>
    /// Основной сайт: тарифы
    /// </summary>
    public class Tariff : BaseId
    { 
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Название тарифного плана")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Описание тарифного плана")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Стоимость в месяц")]
        public double Cost { get; set; } = 0;
    }
}

