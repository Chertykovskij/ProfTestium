using System.ComponentModel.DataAnnotations;

namespace ProfTestium.Models
{
    public class Organization : BaseId
    {
        /// <summary>
        /// Название организации
        /// </summary>
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Название организации")]
        public string Name { get; set; } = "";

        /// <summary>
        /// Адресс организации
        /// </summary>
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Адресс организации")]
        public string Adress { get; set; } = "";

        /// <summary>
        /// ИНН
        /// </summary>
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "ИНН")]
        public string INN { get; set; } = "";

        /// <summary>
        /// Путь к файлу с логотипом
        /// </summary>
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Логотип")]
        public string Logo { get; set; } = "";

        public string ColorProfile { get; set; } = "";
        /// <summary>
        /// Действует организация или нет
        /// </summary>
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Действует")]
        public bool Active { get; set; } = true;

        /// <summary>
        /// Администратор
        /// </summary>
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Администратор")]
        public string UserAdmin { get; set; } = "";

        /// <summary>
        /// Номер организации организации
        /// </summary>
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Номер телефона организации")]
        public string Phone { get; set; } = "";
    }
}
