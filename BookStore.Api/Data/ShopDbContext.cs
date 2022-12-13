using BookApi.Entities;
using BookStore.Api.Entities;
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
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 1,
                Name = "ULYSSES ",
                Author = "James Joyce",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown p",
                ImageURL = "/Images/Beauty/Beauty1.png",
                Price = 100,
                Qty = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 2,
                Name = "THE GREAT GATSBY",
                Author = "F. Scott Fitzgerald",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown p",
                ImageURL = "/Images/Beauty/Beauty2.png",
                Price = 50,
                Qty = 45,
                CategoryId = 1

            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 3,
                Name = "A PORTRAIT OF THE ARTIST AS A YOUNG MAN",
                Author = "James Joyce",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown p",
                ImageURL = "/Images/Beauty/Beauty3.png",
                Price = 20,
                Qty = 30,
                CategoryId = 1

            });
           

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 18,
                Name = "I Remember You: A Ghost Story.",
                Author = "Agatha Christie",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown p",
                ImageURL = "/Images/Shoes/Shoes1.png",
                Price = 100,
                Qty = 50,
                CategoryId = 4
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 19,
                Name = "The Hunting Party: A Novel",
                Author = "Louise Penny",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown p",
                ImageURL = "/Images/Shoes/Shoes2.png",
                Price = 150,
                Qty = 60,
                CategoryId = 4
            });
          

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Bob"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Sarah"

            });

            //Create Shopping Cart for Users
            modelBuilder.Entity<BookCart>().HasData(new BookCart
            {
                Id = 1,
                UserId = 1

            });
            modelBuilder.Entity<BookCart>().HasData(new BookCart
            {
                Id = 2,
                UserId = 2

            });
            //Add Product Categories
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                Name = "Classics",
                
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 2,
                Name = "Crime",
                
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 3,
                Name = "Fantasy",
              
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 4,
                Name = "Horror",
              
            });



        }


        public DbSet<BookCart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Book> Products { get; set; }
        public DbSet<Category> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
