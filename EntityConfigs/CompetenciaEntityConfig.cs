using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebAppBloom.Models;
namespace WebAppBloom.EntityConfigs;

public class CompetenciaEntityConfig : IEntityTypeConfiguration<Competencia>
{

    // FLUENT API.
    // Interface é o mais alto nível de abstração.
    // Na orientação a objetos ela é a ponta do iceberg.
    // Funciona como um contrato com as classes.
    // Obriga geralmente a implementação.
    // Vamos implementar um método da interface?
    // É isso o que a interface faz.

    // Chave primária: identificador.
    // único- universal e imutável

    public void Configure(EntityTypeBuilder<Competencia> builder)
    {
        builder.ToTable("Competencia");
        builder.HasKey(c=>c.ID);
        builder.Property(c=>c.ID)
        .HasColumnName("ID");


        builder.Property(c=>c.ColunaBloom)
        .HasColumnName("ColubaBloom")
        .HasColumnType("varchar(60)");




    }


}