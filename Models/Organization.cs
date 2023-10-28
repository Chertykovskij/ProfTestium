using System.ComponentModel.DataAnnotations;

namespace ProfTestium.Models
{
    public class Organization
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Adress { get; set; }
        public string INN { get; set; }
        public string Logo { get; set; }
        public string ColorProfile { get; set; }
        [Required]
        public bool Active { get; set; }
        [Required]
        public string UserAdmin { get; set; }
        public string Phone { get; set; }
    }
}
