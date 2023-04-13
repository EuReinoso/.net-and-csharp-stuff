using Microsoft.EntityFrameworkCore;
using mvc2.Models;

namespace mvc2.Data
{
    public class BancoContext : DbContext
    {

        public BancoContext()
        {

        }
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\PDVNET;DataBase=MVC2TESTE;User Id=sa;Password=inter#system;TrustServerCertificate=True;");
        }
        
        public DbSet<ClienteModel> Cliente {get; set;}
    }
}