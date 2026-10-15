using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace GolBet.Repositories.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            // Aquí ponemos una cadena de conexión temporal solo para que la terminal pueda compilar la migración
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=GolBetDB_DisenoSoft;Trusted_Connection=True;");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}