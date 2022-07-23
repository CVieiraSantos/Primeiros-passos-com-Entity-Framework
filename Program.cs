using System.Security.Cryptography.X509Certificates;
using System;
using Blog.Data;
using Blog.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            var user = new User
            {
                Name = "Carlos",
                Slug = "carlos",
                Email = "cadu@gmail.com",
                Bio = "10x Microsoft MVP",
                Image = "https://caludtech.io",
                PasswordHash = "2345678"
            };

            var category = new Category
            {
                Name = "Backend",
                Slug = "Bachend"

            };

            var post = new Post
            {
                 Author = user,
                 Category = category,
                 Body = "<p>Hello world</p>",
                 Slug = "comecando-com-ef-core",
                 Summary = "Neste artigo vamos aprender EF core",
                 Title = "Começando com EF Core",
                 CreateDate = DateTime.Now,
                 LastUpdateDate = DateTime.Now,
            };

            context.Posts.Add(post);
            context.SaveChanges();










            // using(var context = new BlogDataContext())
            // {   




            //     //Create
            //     //   var tag = new Tag {Name = "ASP.NET", Slug = "aspnet"};
            //     //   context.Tags.Add(tag);
            //     //   context.SaveChanges();

            //     //   var tag2 = new Tag {Name = "ASP.NET MVC", Slug = "aspnet mvc"};
            //     //   context.Tags.Add(tag2);
            //     //   context.SaveChanges();

            //     // //Update
            //     //  var tag = context.Tags.FirstOrDefault(x=> x.Id == 1);
            //     //  tag.Name = ".NET";
            //     //  tag.Slug = "dotnet";
            //     //  context.Update(tag);
            //     //  context.SaveChanges();

            //     // //Delete
            //     //  var tag = context.Tags.FirstOrDefault(x=> x.Id == 1);
            //     //  context.Remove(tag);
            //     //  context.SaveChanges();

            //     //Read
            //     // var tags = context
            //     // .Tags
            //     // .AsNoTracking()
            //     // .ToList();                

            //     // foreach (var item in tags)
            //     // {
            //     //     Console.WriteLine(item.Name);
            //     // }

            // }
        }
    }
}
