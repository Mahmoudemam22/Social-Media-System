using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Social_Media_System.Model
{
    public class Post
    {
        public Post()
        {
            Time = DateTime.Now.TimeOfDay;
            Date = DateTime.Now.Date;
        }
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan Time { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        public byte[] ImageData { get; set; }
        [ForeignKey("Author")]
        public string AuturUserName  { get; set; }
        public virtual Author Author { get; set; }

        [ForeignKey("Catalog")]
        public int Catalog_ID { get; set; }
        public virtual catalog Catalog {  get; set; }

    }
}
