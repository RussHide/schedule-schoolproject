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
    public partial class Login : Form
    {
        List<Usuario> lstUsuarios;
        public Login()
        {
            InitializeComponent();
        }
        #region Eventos
        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
            btnEntrar.Enabled = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lstUsuarios = new List<Usuario>();
            Usuario usuario = new Usuario();
            usuario.Nombre = "Rubén Hernández Díaz";
            usuario.User = "ruben";
            usuario.Password = "123456";
            lstUsuarios.Add(usuario);

            usuario = new Usuario();
            usuario.Nombre = "Isabel Reyes";
            usuario.User = "chavelaaaa";
            usuario.Password = "123chavela";
            lstUsuarios.Add(usuario);



        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!validaCamposLogin())
            {
                return;
            }
            bool bandera = false;
            foreach(Usuario usu in lstUsuarios)
            {
                  if(usu.User.Equals(txtUser.Text) && usu.Password.Equals(txtPassword.Text))
                {
                    bandera = true;
                }
               
            }
            if (bandera)
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
               
                
                //MessageBox.Show("Funciona");

            }
            else
            {
                MessageBox.Show(null, "Usuario o contraseña invalidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region validaciones
        public bool validaCamposLogin()
        {
            bool bandera = true;
            if (txtUser.Text.Equals(""))
            {
                MessageBox.Show(null, "El campo usuario es requerido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return false;
            }
            if (txtPassword.Text.Equals(""))
            {
                MessageBox.Show(null, "El campo password es requerido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            return bandera;
        }
        #endregion
    }
}
