using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Académica_Semana_5.entities
{
    internal class Videojuegos
    {
        public Videojuegos()
        {
            Jugadores = new List<Jugador>();
        }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public List<Jugador> Jugadores { get; set; }
    }
}
