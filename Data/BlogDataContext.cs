using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class BlogDataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blog;Integrated Security=true");
        

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        //public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<UserRole> UserRoles { get; set; }
    }
}