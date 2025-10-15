using Microsoft.EntityFrameworkCore;

namespace AspNetcoreRazorpages.Models
{
    public class AppDatabase: DbContext  // connections to DB
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
optionsBuilder.UseSqlServer("Data Source=HDC3-L-94S8B54;Initial Catalog=db_WebAppPreJoiners;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<UsersData> UsersData { get; set; } // table ORM

        public DbSet<Books> Books { get; set; } // table
    }
}
