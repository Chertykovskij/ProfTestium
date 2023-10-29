namespace ProfTestium.Models.ViewModels
{
    public class TestViewModel
    {
        public Test Test { get; set; } = new Test();
        public List<Quest> Questions { get; set; } = new();
    }
}
