using System.Security.Cryptography.X509Certificates;
using System;
using Blog.Data;
using Blog.Models;
using System.Linq;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new BlogDataContext())
            {   
                //Create
                //  var tag = new Tag {Name = "ASP.NET", Slug = "aspnet"};
                //  context.Tags.Add(tag);
                //  context.SaveChanges();

                //  var tag2 = new Tag {Name = "ASP.NET MVC", Slug = "aspnet mvc"};
                //  context.Tags.Add(tag2);
                //  context.SaveChanges();

                //Update
                // var tag = context.Tags.FirstOrDefault(x=> x.Id == 1);
                // tag.Name = ".NET";
                // tag.Slug = "dotnet";
                // context.Update(tag);
                // context.SaveChanges();

                //Delete
                // var tag = context.Tags.FirstOrDefault(x=> x.Id == 1);
                // context.Remove(tag);
                // context.SaveChanges();

                var tags = context
                .Tags
                .ToList();                

                foreach (var item in tags)
                {
                    Console.WriteLine(item.Name);
                }

            }
        }
    }
}
