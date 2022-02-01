﻿// <auto-generated />
using System;
using Data.DbSqlContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(SqlContext))]
    partial class SqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entity.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdCargo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("dsCArgo");

                    b.HasKey("Id");

                    b.ToTable("Cargo_Sistema");
                });

            modelBuilder.Entity("Domain.Entity.Rotina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idRotina")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CargoId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("dsrotina");

                    b.Property<int>("IdCargo")
                        .HasColumnType("int");

                    b.Property<string>("Sistema")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("sistema");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.ToTable("Rotina_Sistema");
                });

            modelBuilder.Entity("Domain.Entity.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdRegistro")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CargoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nUsuario");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.ToTable("Usuario_Sistema");
                });

            modelBuilder.Entity("Domain.Entity.Rotina", b =>
                {
                    b.HasOne("Domain.Entity.Cargo", "Cargo")
                        .WithMany("Rotinas")
                        .HasForeignKey("CargoId");

                    b.Navigation("Cargo");
                });

            modelBuilder.Entity("Domain.Entity.Usuario", b =>
                {
                    b.HasOne("Domain.Entity.Cargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId");

                    b.Navigation("Cargo");
                });

            modelBuilder.Entity("Domain.Entity.Cargo", b =>
                {
                    b.Navigation("Rotinas");
                });
#pragma warning restore 612, 618
        }
    }
}