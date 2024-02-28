using Microsoft.EntityFrameworkCore;

namespace ImportandadoDadosExcel.Classes
{
    public class Contexto : DbContext
    {
        public DbSet<EstruturaExcel> Excels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\sqlexpress;Database=ETL_Base;Integrated Security=True;Trusted_Connection=true;");
        }
    }



}
