using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Data;

namespace API.Models
{
    public class Compromissos
    {
    
        public int Id { get; set; }
        public string Tarefa { get; set; }
        public string Local { get; set; }
        public DateTime Dia { get; set; }
        public TimeSpan Hora { get; set; }

    }
}