using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgendaVisual
{
    public partial class Menu : Form
    {
        List<Persona> lstPersonas = new List<Persona>();
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Altas alta = new Altas();
            alta.LstPersonas = lstPersonas;
            alta.Show();
            lstPersonas = alta.LstPersonas;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas();
            consultas.LstPersonas = lstPersonas;
            consultas.Show();
        }
    }
}
