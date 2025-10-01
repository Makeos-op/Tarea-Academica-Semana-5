using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Académica_Semana_5.entities
{
    internal class Videojuegos
    {
        // Constructor principal que inicializa la lista de jugadores (junto con los otros datos)
        public Videojuegos()
        {
            Jugadores = new List<Jugador>();
        }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        // Lista de jugadores
        public List<Jugador> Jugadores { get; set; }
    }
}
