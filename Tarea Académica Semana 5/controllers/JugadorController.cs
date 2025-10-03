using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Tarea_Académica_Semana_5.entities;

namespace Tarea_Académica_Semana_5.controllers
{
    internal class JugadorController
    {
        public bool RegistrarJugador(string codigojuego,Jugador jugador)
        {
            if (ExisteJugador(codigojuego,jugador.DNI))
            {
                return false;
            }
            List<Videojuego> Videojuegos = VideojuegoController.MostrarVideojuegos(); //consigues todos los videojuegos
            Videojuego videojuego = Videojuegos.Find(v => v.Codigo.Equals(codigojuego)); //obtienes los datos del videojuego seleccionado
            videojuego.Jugadores.Add(jugador); //Añade al jugador yei 
            return true;
            //Todos los comentarios parecen ia xd
        }
        public bool ExisteJugador(string codigojuego,string DNI)
        {
            List<Videojuego> Videojuegos = VideojuegoController.MostrarVideojuegos();
            Videojuego videojuego = Videojuegos.Find(v => v.Codigo.Equals(codigojuego));
            return videojuego.Jugadores.Exists(j => j.DNI.Equals(DNI));
        }
        public List<Jugador> MostrarJugadores(string codigojuego)
        {
            List<Videojuego> Videojuegos = VideojuegoController.MostrarVideojuegos();
            Videojuego videojuego = Videojuegos.Find(v => v.Codigo.Equals(codigojuego));
            return videojuego.Jugadores;
        }
    }
}
