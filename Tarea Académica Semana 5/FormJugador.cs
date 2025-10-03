using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_Académica_Semana_5.controllers;
using Tarea_Académica_Semana_5.entities;

namespace Tarea_Académica_Semana_5
{
    public partial class FormJugador : Form
    {
        private JugadorController jugadorController = new JugadorController();
        private string codigojuego;
        public FormJugador(string codigojuego)
        {
            InitializeComponent();
            this.codigojuego = codigojuego;
            MostrarJugadores(jugadorController.MostrarJugadores(codigojuego));
        }
        private void MostrarJugadores(List<Jugador> jugadores)
        {
            dgJugadores.DataSource = null; //Limpiamos
            if (jugadores.Count != 0)
            {
                dgJugadores.DataSource = jugadores;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbDNI.Text == "" || tbAlias.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            Jugador jugador = new Jugador()
            {
                DNI = tbDNI.Text.ToString(),
                Alias = tbAlias.Text.ToString()
            };
            bool registrado = jugadorController.RegistrarJugador(codigojuego,jugador);
            if (!registrado)
            {
                MessageBox.Show("Ya esta Registrado");
                return;
            }
            MostrarJugadores(jugadorController.MostrarJugadores(codigojuego));
        }
    }
}
