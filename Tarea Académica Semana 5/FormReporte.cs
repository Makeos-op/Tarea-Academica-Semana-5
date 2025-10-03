using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tarea_Académica_Semana_5.controllers;
using Tarea_Académica_Semana_5.entities;

namespace Tarea_Académica_Semana_5
{
    public partial class FormReporte : Form
    {
        private ReporteController reporteController = new ReporteController();
        public FormReporte()
        {
            InitializeComponent();
        }
        private void MostrarReporte(List<Videojuego> reportes)
        {
            dgBusqueda.DataSource = null; //Limpiamos
            if (reportes.Count != 0)
            {
                dgBusqueda.DataSource = reportes;
            }
        }
        private void MostrarJuegos(List<Videojuego> reportes)
        {
            dgBusqueda.DataSource = null; //Limpiamos
            if (reportes.Count != 0)
            {
                dgBusqueda.DataSource = reportes;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (tbDNI.Text == "")
            {
                MessageBox.Show("Ingrese DNI");
                return;
            }
            string dni = tbDNI.Text;
            MostrarJuegos(reporteController.VideojuegosJugadorParticipante(dni));
        }

        private void btnMasRemunerados_Click(object sender, EventArgs e)
        {
            MostrarReporte(reporteController.Videojuegosmasjugados());
        }

        private void btnMenosRemunerados_Click(object sender, EventArgs e)
        {
            MostrarReporte(reporteController.Videojuegosmenosjugados());
        }
    }
}
