namespace BrailleTestApp.Models
{
    public class FAQViewModel
    {
        public List<FAQItem> Questions { get; set; }

    }
    public class FAQItem
    {
        public string Title { get; set; }
        public string Answer { get; set; }
    }

}
