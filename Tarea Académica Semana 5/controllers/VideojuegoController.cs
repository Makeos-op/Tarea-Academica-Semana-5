using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_Académica_Semana_5.entities;

namespace Tarea_Académica_Semana_5.controllers
{
    internal class VideojuegoController
    {
        //Lista privada de videojuegos
        private static List<Videojuego> Videojuegos = new List<Videojuego>();

        public bool RegistrarVideojuego(Videojuego videojuego)
        {
           if (ExisteVideojuego(videojuego.Codigo))
            {
                return false;
            }
            Videojuegos.Add(videojuego);
            return true;
        }
        public bool ExisteVideojuego(string codigo)
        {
            return Videojuegos.Any(v => v.Codigo == codigo);
        }
        public static List<Videojuego> MostrarVideojuegos()
        {
            return Videojuegos; 
        }
        public static List<Videojuego> VideojuegosAscendencia() // Como el momo :v
        {
            return Videojuegos.OrderBy(v => v.Jugadores.Count).ToList(); //Explicar
        }
        public static List<Videojuego> VideojuegosDescendencia() // Como cuando no hay buenos juegos en la playstore :(
        {
            return Videojuegos.OrderByDescending(v => v.Jugadores.Count).ToList(); //Explicar
        }
    }
}
