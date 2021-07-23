using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Data;

namespace API.Models
{
    public class Compromissos
    {
        public Compromissos() 
        {}
        public Compromissos(int id, string tarefa, string local, DateTime dia, TimeSpan hora)
        {
            this.Id = id;
            this.Tarefa = tarefa;
            this.Local = local;
            this.Dia = dia;
            this.Hora = hora;

        }
        public int Id { get; set; }
        public string Tarefa { get; set; }
        public string Local { get; set; }
        public DateTime Dia { get; set; }
       public TimeSpan Hora { get; set; }

    }
}