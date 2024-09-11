using JovemProgramadorMvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JovemProgramadorMvc.Data.Mapeamento
{
    public class ProfessorMapeamento : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("Professor");

            builder.HasKey(t => t.Id);
            
            builder.Property(t => t.Nome).HasColumnType("varchar(40)");
            builder.Property(t => t.Disciplina).HasColumnType("varchar(20)");
            builder.Property(t => t.Sala).HasColumnType("varchar(15)");

        }
    }
}
