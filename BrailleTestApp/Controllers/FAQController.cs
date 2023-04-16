using BrailleTestApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BrailleTestApp.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult faqs()
        {
            var FAQViewModel = new FAQViewModel
            {
                Questions = new List<FAQItem>
            {
                new FAQItem
                {
                    Title = "Question 1",
                    Answer = "Answer 1"
                },
                new FAQItem
                {
                    Title = "Question 2",
                    Answer = "Answer 2"
                }
            }
            };

            return View(FAQViewModel);
          
        }
    }
}
