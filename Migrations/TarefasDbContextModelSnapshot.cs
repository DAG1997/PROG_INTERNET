﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PROJETO_PNET.Data;

namespace PROJETO_PNET.Migrations
{
    [DbContext(typeof(TarefasDbContext))]
    partial class TarefasDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PROJETO_PNET.Models.Cargos", b =>
                {
                    b.Property<int>("CargosId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Funcao")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("NomeCargo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("CargosId");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("PROJETO_PNET.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("FuncionarioId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("PROJETO_PNET.Models.Professores", b =>
                {
                    b.Property<int>("professoresId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aulas");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("Numero");

                    b.HasKey("professoresId");

                    b.ToTable("Professores");
                });
#pragma warning restore 612, 618
        }
    }
}
