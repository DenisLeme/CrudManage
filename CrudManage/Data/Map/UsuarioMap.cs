using CrudManage.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudManage.Data.Map
{
    public class DescricaoMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ValorRenda).IsRequired().HasMaxLength(128);
            builder.Property(x => x.DataNascimento).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Cpf).IsRequired().HasMaxLength(128);


        }
    }
}
