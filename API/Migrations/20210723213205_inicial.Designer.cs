﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210723213205_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Models.Compromissos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Dia")
                        .HasColumnType("date");

                    b.Property<TimeSpan>("Hora")
                        .HasColumnType("time");

                    b.Property<string>("Local")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tarefa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Compromissos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Dia = new DateTime(2021, 08, 02),
                            Hora = new TimeSpan(8, 30, 0),
                            Local = "Escritorio",
                            Tarefa = "Reunião"
                        },
                        new
                        {
                            Id = 2,
                            Dia = new DateTime(2021, 08, 07),
                            Hora = new TimeSpan(19, 0, 0),
                            Local = "Casa da Julia",
                            Tarefa = "Aniversario da Julia"
                        },
                        new
                        {
                            Id = 3,
                            Dia = new DateTime(2021, 08, 09),
                            Hora = new TimeSpan(11, 30, 0),
                            Local = "Clinica",
                            Tarefa = "Consulta Medica"
                        },
                        new
                        {
                            Id = 4,
                            Dia = new DateTime(2021, 08, 09),
                            Hora = new TimeSpan(18, 30, 0),
                            Local = "Cinema",
                            Tarefa = "Cinema"
                        },
                        new
                        {
                            Id = 5,
                            Dia = new DateTime(2021, 08, 14),
                            Hora = new TimeSpan(7, 15, 0),
                            Local = "Supermercado",
                            Tarefa = "Compras do Mês"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
