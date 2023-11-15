using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media_System.Model
{
     public class DB_Context : DbContext
    {
      public virtual DbSet<Author> authors { get; set; }
        public virtual DbSet<catalog> Catalogs { get; set; }
        public virtual DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=.;Initial Catalog=SocialMedia;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().Property<TimeSpan>(n => n.Time).HasPrecision(3);
            modelBuilder.Entity<Post>().Property<DateTime>(n => n.Date).HasColumnType("Date");

        }
    }
}
