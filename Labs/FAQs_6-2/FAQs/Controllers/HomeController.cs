using FAQs.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FAQs.Controllers;
using Microsoft.EntityFrameworkCore;

namespace FAQs.Controllers
{
    public class HomeController : Controller
    {

        private FaqsContext faqsContext { get; set; }

        public HomeController(FaqsContext context)
        {
            faqsContext = context;
        }

        [Route("topic/{topic}/category/{category}")]
        [Route("topic/{topic}")]
        [Route("category/{category}")]
        [Route("/")]
        public IActionResult Index(string topic, string category)
        {
            ViewBag.Topics = faqsContext.Topics.OrderBy(topic => topic.TopicName)
                                                .ToList();

            ViewBag.Categories = faqsContext.Categories.OrderBy(category => category.CategoryName)
                                                        .ToList();

            ViewBag.SelectedTopic = topic;


            IQueryable<Faqs> faqs= faqsContext.Faqs.Include(faq => faq.Topic)
                                                    .Include(faq => faq.Category)
                                                    .OrderBy(faq => faq.FaqQuestion);


            if (!string.IsNullOrEmpty(topic))
            {
                faqs = faqs.Where(faq => faq.TopicID == topic);
            }

            if (!string.IsNullOrEmpty(category))
            {
                faqs = faqs.Where(faq => faq.CategoryID == category);
            }


            return View(faqs.ToList());
        }

       
    }
}