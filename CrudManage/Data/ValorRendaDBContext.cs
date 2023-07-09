using CrudManage.Models;
using Microsoft.EntityFrameworkCore;
using CrudManage.Data.Map;

namespace CrudManage.Data
{
    public class ValorRendaDBContext : DbContext
    {
        public ValorRendaDBContext(DbContextOptions<ValorRendaDBContext> options)
            : base(options)        
        {   
        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<RendaModel> Renda { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DescricaoMap());
            modelBuilder.ApplyConfiguration(new RendaMap());

            base.OnModelCreating(modelBuilder);

        }
    }
}
