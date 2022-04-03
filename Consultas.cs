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
    public partial class Consultas : Form
    {
        List<Persona> lstPersonas;
        internal List<Persona> LstPersonas { get => lstPersonas; set => lstPersonas = value; }

        public Consultas()
        {
            InitializeComponent();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var filteredList = lstPersonas.Where(persona => persona.Nombre.Equals(txtNombre.Text) || persona.ApePaterno.Equals(txtApaterno.Text) || persona.ApeMaterno.Equals(txtAmaterno.Text));
            if (filteredList)
            {
                foreach (Persona p in filteredList)
                {
                    Console.WriteLine(p.Nombre, p.ApePaterno, p.ApeMaterno);
                    dgvPersonas.Rows.Add(p.Nombre, p.ApePaterno, p.ApeMaterno);
                }
            }
            else
            {
                MessageBox.Show("No se encontro ningun usuario con los datos");
            }
        }

        private void dgvPersonas_Click(object sender, EventArgs e)
        {
            /*  Console.WriteLine(dgvPersonas.CurrentRow.Cells[0].Value.ToString());
             Console.WriteLine(dgvPersonas.CurrentRow.Cells[1].Value.ToString());
             Console.WriteLine(dgvPersonas.CurrentRow.Cells[2].Value.ToString());
             var filteredUsers = lstPersonas.Where(persona => persona.Nombre.Equals(dgvPersonas.CurrentRow.Cells[0].Value.ToString())
                 && persona.ApePaterno.Equals(dgvPersonas.CurrentRow.Cells[1].Value.ToString()) && persona.ApeMaterno.Equals(dgvPersonas.CurrentRow.Cells[2].Value.ToString()));
             foreach (Persona p in filteredUsers)
             {
                 dgvDireccion.Rows.Add(p.Direccion.Calle, p.Direccion.NumCasa, p.Direccion.Colonia, p.Direccion.CodigoPostal, p.Direccion.Ciudad, p.Direccion.Estado);
                 foreach (Telefono t in p.LstTelefonos)
                 {
                     dgvTelefonos.Rows.Add(t.Lada, t.NumTelefono);
                 }
             } */

        }
    }
}
