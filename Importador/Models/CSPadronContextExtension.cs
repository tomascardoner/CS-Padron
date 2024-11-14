using Microsoft.EntityFrameworkCore;

namespace CS_Padron_Importador.Models
{
    public partial class CSPadronContext : DbContext
    {
        public static string ConnectionString { get; set; } = string.Empty;

        public CSPadronContext() : base()
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
