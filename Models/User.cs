using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("User")]
    public class User
    {
         [Key] //Cria o Id como chave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Informa que será auto incremental(1,1)
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
        
        
    }
}