using Microsoft.EntityFrameworkCore;

namespace ContactManager.Models
{
    public class ContactContext : DbContext
    {
        //constructor
        public ContactContext(DbContextOptions<ContactContext> options) : base(options) { }


        //create the DbSets
        public DbSet<Contact> Contacts { get; set;}
        public DbSet<Category> Categories { get; set;}

        //add seed Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //category seed
            modelBuilder.Entity<Category>().HasData
             (
                new Category {CategoryID = 1, CategoryName = "Friends" },
                new Category { CategoryID = 2, CategoryName = "Family" },
                new Category { CategoryID = 3, CategoryName = "Work" },
                new Category { CategoryID = 4, CategoryName = "Other" }
            );


            //contact seed
            modelBuilder.Entity<Contact>().HasData(
                new Contact { ContactID = 1,FirstName = "Delores", LastName = "Del Rio", PhoneNo = "555-987-6543", Email = "delores@hotmail.com", CategoryID = 1 , DateAdded = DateTime.Now },
                new Contact { ContactID = 2, FirstName = "Efren", LastName = "Herrera", PhoneNo = "555-456-7890", Email = "efren@aol.com", CategoryID = 3, DateAdded = DateTime.Now },
                new Contact { ContactID = 3, FirstName = "Mary Ellen", LastName = "Walton", PhoneNo = "555-123-4567", Email = "MaryEllen@yahoo.com", CategoryID = 2, DateAdded = DateTime.Now }




                );
        }



    }
}
