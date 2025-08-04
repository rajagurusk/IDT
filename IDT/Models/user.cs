using System.ComponentModel.DataAnnotations.Schema;

namespace IDT.Models


{ 
[Table("Users")]
public class User
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
