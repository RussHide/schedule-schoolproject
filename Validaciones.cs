using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgendaVisual
{
    class Validaciones
    {
        private void validarCampos()
        {
            if (txtNombre.Text.Equals("") || txtApePaterno.Text.Equals("") || txtApeMaterno.Text.Equals("")
                || cmbSexo.SelectedItem.Equals("") || numEdad.Value.Equals(""))
            {

            }
        }
    }
}
