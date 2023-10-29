using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProfTestium.Models.ViewModels
{
    public class TestViewModel
    {
        public Test Test { get; set; } = new Test();
        public List<Quest> Questions { get; set; } = new();
    }

    public class TestViewModelToCreate
    {
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Название")]
        public string Title { get; set; } = "";

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Описание")]
        public string Description { get; set; } = "";

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Учебный материал")]
        public int Course_id { get; set; }

        [Display(Name = "Учебный материал")]
        public virtual Course Course { get; set; } = new Course();

        public List<QuestViewModel> Questions { get; set; } 
            = new List<QuestViewModel> {new QuestViewModel(), new QuestViewModel(), new QuestViewModel(),
            new QuestViewModel(),new QuestViewModel(),new QuestViewModel(),new QuestViewModel(),new QuestViewModel(),
            new QuestViewModel(),new QuestViewModel(),new QuestViewModel(),};
    }

    public class QuestViewModel
    {
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Вопрос")]
        public string Title { get; set; } = "";

        public int? Test_id { get; set; }
        public virtual Test Test { get; set; } = new Test();

        public List<AnswerViewModel> Answers { get; set; } 
            = new List<AnswerViewModel> { new AnswerViewModel(), new AnswerViewModel(), new AnswerViewModel(), new AnswerViewModel()};
    }

    public class AnswerViewModel
    {
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Ответ")]
        public string Title { get; set; } = "";

        [Display(Name = "Правильный ответ?")]
        public bool Correct { get; set; } = false;

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Вопрос")]
        public int Query_id { get; set; }
        public virtual Quest Quest { get; set; } = new Quest();
    }
}
