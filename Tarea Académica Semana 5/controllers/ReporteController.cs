    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_Académica_Semana_5.entities;

namespace Tarea_Académica_Semana_5.controllers
{
    internal class ReporteController
    {
       //Busqueda por dni de Videojuegos donde esta presente el jugador
       public List<Videojuego> VideojuegosJugadorParticipante(string DNI)
        {
            List<Videojuego> videojuegos = VideojuegoController.MostrarVideojuegos();
            return videojuegos.Where(v=> v.Jugadores.Any(j=>j.DNI.Equals(DNI))).ToList();
        }
        public List<Videojuego> Videojuegosmasjugados()
        {
            List<Videojuego> Videojuegos = VideojuegoController.MostrarVideojuegos();
            int maximo = 
                Videojuegos.Count == 0?
                0
                :
                Videojuegos.Max(v => v.Jugadores.Count);
            return Videojuegos.Where(v => v.Jugadores.Count == maximo).ToList();
        }
        public List<Videojuego> Videojuegosmenosjugados()
        {
            List<Videojuego> Videojuegos = VideojuegoController.MostrarVideojuegos();
            int minimo =
                Videojuegos.Count == 0 ?
                0
                :
                Videojuegos.Min(v => v.Jugadores.Count);
            return Videojuegos.Where(v => v.Jugadores.Count == minimo).ToList();
        }

    }
}
