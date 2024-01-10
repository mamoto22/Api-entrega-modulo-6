﻿// <auto-generated />
using ApiEntrega6.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiEntrega6.Migrations
{
    [DbContext(typeof(Datacontext))]
    partial class DatacontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApiEntrega6.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Idade")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Idade");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Name");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Telefone");

                    b.HasKey("Id");

                    b.ToTable("cliente");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Idade = "33",
                            Name = "Jonathan",
                            Telefone = "21991320149"
                        },
                        new
                        {
                            Id = 2,
                            Idade = "31",
                            Name = "Jadyson",
                            Telefone = "219999999999"
                        },
                        new
                        {
                            Id = 3,
                            Idade = "30",
                            Name = "Jessika",
                            Telefone = "213526479899"
                        },
                        new
                        {
                            Id = 4,
                            Idade = "28",
                            Name = "Jefferson",
                            Telefone = "2198959699"
                        },
                        new
                        {
                            Id = 5,
                            Idade = "26",
                            Name = "Amanda",
                            Telefone = "21656689741"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
