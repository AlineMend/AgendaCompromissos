using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Web;
using API.Models;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        public DbSet<Compromissos> Compromissos {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Compromissos>()
                    .HasData(new List<Compromissos>() {
                        new Compromissos() {Id = 1, Tarefa = "Reunião", Local = "Escritorio", Dia = new DateTime (02/08/2021), Hora = new TimeSpan (08,30,0)},
                        new Compromissos() {Id = 2, Tarefa = "Aniversario da Julia", Local = "Casa da Julia", Dia = new DateTime (07/08/2021), Hora = new TimeSpan (19,00,0)},
                        new Compromissos() {Id = 3, Tarefa = "Consulta Medica", Local = "Clinica", Dia = new DateTime (09/08/2021), Hora = new TimeSpan (11,30,0)},
                        new Compromissos() {Id = 4, Tarefa = "Cinema", Local = "Cinema", Dia = new DateTime (09/08/2021), Hora = new TimeSpan (18,30,0)},
                        new Compromissos() {Id = 5, Tarefa = "Compras do Mês", Local = "Supermercado", Dia = new DateTime (14/08/2021), Hora = new TimeSpan (07,15,0)},
                    });
        }
    }
}
