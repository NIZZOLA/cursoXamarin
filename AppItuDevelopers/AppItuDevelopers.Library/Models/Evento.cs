using System;
using System.Collections.Generic;
using System.Text;

namespace AppItuDevelopers.Library.Models
{
    public class Evento
    {
        public string Titulo { get; set; }
        public TipoEvento Tipo { get; set; }

        public DateTime Data { get; set; }

        public string Descricao { get; set; }

        public string Link { get; set; }

        public bool Exibir { get; set; }
    }
}
