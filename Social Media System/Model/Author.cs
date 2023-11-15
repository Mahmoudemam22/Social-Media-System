using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Social_Media_System.Model
{
    public class Author
    {
 
        [Key]
        [MaxLength(50)]
        public string UserName { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        public int Age { get; set; }
       public virtual List<Post> posts { get; set; } = new List<Post>();



    }
}
