using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Blog.Models;

namespace Blog
{
    [Table("Post")]
    public class Post
    {
         [Key] //Cria o Id como chave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Informa que será auto incremental(1,1)
        public int Id { get; set; }
        
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        [ForeignKey("CategoryId")] //Cria a chave estrangeira
        public Category Category { get; set; } //Está referenciando uma categoria por meio da CategoryId e posso dai preencher as categorias
        public int CategoryId { get; set; }

        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
        public User Author { get; set; }
    }
}
