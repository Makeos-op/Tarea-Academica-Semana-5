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
    public partial class FormVideojuego : Form
    {
        private VideojuegoController videojuegoController = new VideojuegoController();
        public FormVideojuego()
        {
            InitializeComponent();
            MostrarVideojuegos(VideojuegoController.MostrarVideojuegos());
        }

        private void MostrarVideojuegos(List<Videojuego> Videojuegos)
        {
            dgVideojuegos.DataSource = null; //Limpiamos
            if (Videojuegos.Count != 0)
            {
                dgVideojuegos.DataSource = Videojuegos;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text == "" || tbNombre.Text == "" )
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            Videojuego videojuego = new Videojuego()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
            };
            bool registrado = videojuegoController.RegistrarVideojuego(videojuego);
            if (!registrado)
            {
                MessageBox.Show("Ya esta Registrado");
                return;
            }
            MostrarVideojuegos(VideojuegoController.MostrarVideojuegos());
        }

        private void btnAñadirJugador_Click(object sender, EventArgs e)
        {
            if (dgVideojuegos.CurrentRow == null)
            {
                MessageBox.Show("Eliga un Videojuego");
            }
            string CodigoVideojuego = dgVideojuegos.CurrentRow.Cells["Codigo"].Value.ToString();
            FormJugador form = new FormJugador(CodigoVideojuego);
            form.Show();
        }
    }
}
