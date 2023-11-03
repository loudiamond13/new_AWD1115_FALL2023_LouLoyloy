using Microsoft.EntityFrameworkCore;

namespace FAQs.Models
{
    public class FaqsContext : DbContext
    {
        //constructor
        public FaqsContext(DbContextOptions<FaqsContext> options) : base(options) { }



        public DbSet<Faqs> Faqs { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Faqs>().HasData
                (
                     new Faqs
                     {
                         FaqID = 1,
                         FaqQuestion = "What is C#?",
                         FaqAnswer = "A general purpose object oriented language that uses a concise, Java-like syntax.",
                         TopicID = "cs",
                         CategoryID = "gen"
                     },
                    new Faqs
                    {
                        FaqID = 2,
                        FaqQuestion = "When was C# first released?",
                        FaqAnswer = "In 2002.",
                        TopicID = "cs",
                        CategoryID = "hist"
                    },
                    new Faqs
                    {
                        FaqID = 3,
                        FaqQuestion = "What is JavaScript?",
                        FaqAnswer = "A general purpose scripting language that executes in a web browser.",
                        TopicID = "js",
                        CategoryID = "gen"
                    },
                    new Faqs
                    {
                        FaqID = 4,
                        FaqQuestion = "When was JavaScript first released?",
                        FaqAnswer = "In 1995.",
                        TopicID = "js",
                        CategoryID = "hist"
                    },
                    new Faqs
                    {
                        FaqID = 5,
                        FaqQuestion = "What is Bootstrap?",
                        FaqAnswer = "A CSS framework for creating responsive web apps for multiple screen sizes.",
                        TopicID = "boot",
                        CategoryID = "gen"
                    },
                    new Faqs
                    {
                        FaqID = 6,
                        FaqQuestion = "When was Bootstrap first released?",
                        FaqAnswer = "In 2011.",
                        TopicID = "boot",
                        CategoryID = "hist"
                    }

                    
                );

            modelBuilder.Entity<Topic>().HasData
                (
                    new Topic { TopicID = "cs",     TopicName = "C#" },
                    new Topic { TopicID = "js",     TopicName = "JavaScript" },
                    new Topic { TopicID = "boot",   TopicName = "Bootstrap" }

                );

            modelBuilder.Entity<Category>().HasData
                (
                    new Category { CategoryID = "gen", CategoryName = "General" },
                    new Category { CategoryID = "hist", CategoryName = "History" }
                );
        }

    }
}
