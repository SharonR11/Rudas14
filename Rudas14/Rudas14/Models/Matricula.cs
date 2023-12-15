using System;
using System.Collections.Generic;
using System.Text;

namespace Rudas14.Models
{
    public class Matricula
    {
        public int MatriculaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string Curso { get; set; }
        public string Genero { get; set; }
    }
}
