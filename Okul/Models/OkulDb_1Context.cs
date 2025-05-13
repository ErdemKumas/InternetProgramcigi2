using Microsoft.EntityFrameworkCore;

namespace Okul.Models
{
    public class OkulDb_1Context : DbContext 
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=OkulDbBilisimMVC;Integrated Security=true;TrustServerCertificate=true");
        }
       
    }
}
