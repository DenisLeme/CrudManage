using CrudManage.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudManage.Data.Map
{
    public class RendaMap : IEntityTypeConfiguration<RendaModel>
    {
        public void Configure(EntityTypeBuilder<RendaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ValorRenda).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(128);
        }
    }
}
