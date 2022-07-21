using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Tag")]
    public class Tag
    {
        [Key]
        public int Id { get; set; }            
        public string Nome { get; set; }
        public string Slug { get; set; }
    }
}