using BookApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options):base (options){

}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Products
            //Beauty Category
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 1,
                Name = "Harry Potter",
                Author = "RR",
               CategoryId=2,
                Price = 100,
               

            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 2,
                Name = "KK",
                Author = "KK",
                CategoryId = 1,

                Price = 100,
               

            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                CategoryName = "Fantacy",
               
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 2,
                CategoryName = "Horror",

            });
           


        }

      
        public DbSet<BookCart> BookCarts { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Book> Books { get; set; }
      
    }
}
