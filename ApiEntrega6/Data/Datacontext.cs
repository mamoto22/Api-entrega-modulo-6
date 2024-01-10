

using ApiEntrega6.Models;
using Microsoft.EntityFrameworkCore;


namespace ApiEntrega6.Data
{
    public class Datacontext : DbContext
    {
       
        public Datacontext(DbContextOptions<Datacontext> options) : base(options)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id = 1, Name = "Jonathan", Idade = "33", Telefone = "21991320149" },
                new Cliente { Id = 2, Name = "Jadyson", Idade = "31", Telefone = "219999999999" },
                new Cliente { Id = 3, Name = "Jessika", Idade = "30", Telefone = "213526479899" },
                new Cliente { Id = 4, Name = "Jefferson", Idade = "28", Telefone = "2198959699" },
                new Cliente { Id = 5, Name = "Amanda", Idade = "26", Telefone = "21656689741" }

            );


        }

    }


}


