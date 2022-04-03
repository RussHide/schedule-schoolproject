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
    public partial class Altas : Form
    {
        List<Persona> lstPersonas;
        int indexDgvTelefono = -1;

        internal List<Persona> LstPersonas { get => lstPersonas; set => lstPersonas = value; }

        public Altas()
        {
            InitializeComponent();
        }


        private void btnMasNumero_Click(object sender, EventArgs e)
        {
            if (!validaCamposTelefono())
            {
                return;
            }
            dgvTelefonos.Rows.Add(txtLada.Text, txtNumeroTel.Text);
        }

        public bool validaCamposTelefono()
        {
            if (txtLada.Text.Equals("") || txtLada.Text.Equals("LADA"))
            {
                MessageBox.Show(null, "El campo Lada es requerido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLada.Focus();
                return false;
            }
            if (txtNumeroTel.Text.Equals("") || txtNumeroTel.Text.Equals("NÚMERO"))
            {
                MessageBox.Show(null, "El campo Número es requerido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroTel.Focus();
                return false;
            }
            return true;
        }


        //private void txtLada_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        //    {
        //        e.Handled = true;
        //        Console.Beep();
        //    }
        //}sdasdzsda

        //private void txtNumeroTel_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        //    {
        //        e.Handled = true;
        //        Console.Beep();
        //    }
        //}

        private void dgvTelefonos_Click(object sender, EventArgs e)
        {
            indexDgvTelefono = dgvTelefonos.CurrentCell.RowIndex;
            // dgvTelefonos.Rows.RemoveAt(dgvTelefonos.CurrentCell.RowIndex);
            // foreach(DataGridViewRow row in dgvTelefonos.Rows)
            //{
            //  MessageBox.Show("lada: "+row.Cells[0].Value+" Tel: "+ row.Cells[1].Value);
            // }
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = txtNombre.Text;
            persona.ApeMaterno = txtApeMaterno.Text;
            persona.ApePaterno = txtApePaterno.Text;
            persona.Edad = Convert.ToInt32(numEdad.Value);
            persona.Sexo = cmbSexo.SelectedItem.ToString();
            persona.Direccion = new Direccion();
            persona.Direccion.Calle = txtCalle.Text;
            persona.Direccion.Ciudad = txtCiudad.Text;
            persona.Direccion.Colonia = txtColonia.Text;
            persona.Direccion.CodigoPostal = Convert.ToInt32(txtCodigoPostal.Text);
            persona.Direccion.NumCasa = txtNumeroCasa.Text;
            persona.Direccion.Estado = txtEstado.Text;
            persona.LstTelefonos = new List<Telefono>();
            foreach (DataGridViewRow row in dgvTelefonos.Rows)
            {
                MessageBox.Show("lada: " + row.Cells[0].Value + " Tel: " + row.Cells[1].Value);
                Telefono tel = new Telefono();
                tel.Lada = row.Cells[0].Value.ToString();
                tel.NumTelefono = row.Cells[1].Value.ToString();
                persona.LstTelefonos.Add(tel);
            }
            LstPersonas.Add(persona);
        }

        private void btnMenosNum_Click(object sender, EventArgs e)
        {
            if (indexDgvTelefono == -1)
            {
                MessageBox.Show("Seleccione un renglon");
                return;
            }
            dgvTelefonos.Rows.RemoveAt(indexDgvTelefono);
            indexDgvTelefono = -1;
        }
    }
}
