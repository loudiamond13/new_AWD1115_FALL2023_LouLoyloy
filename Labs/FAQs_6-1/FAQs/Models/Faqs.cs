using System.ComponentModel.DataAnnotations;

namespace FAQs.Models
{
    public class Faqs
    {
        [Key]
        public int FaqID { get; set; } // primary key
        public string FaqQuestion { get; set; } = string.Empty;
        public string FaqAnswer { get; set;} = string.Empty;

        //topic foreign key
        public Topic Topic { get; set; }
        public string TopicID { get; set; }

        //category foreign key
        public Category Category { get; set; }
        public string CategoryID { get; set; }
    }
}
