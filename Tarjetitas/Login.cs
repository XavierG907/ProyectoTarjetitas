using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Tarjetitas
{
    public partial class Login : Form
    {
        private TarjetitasDB bd = new TarjetitasDB();
        public Login()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("Usuario"))
            {
                txtUsuario.Clear();
                txtUsuario.ForeColor = Color.DarkSlateBlue;
            }
            errorLogIn.Visible = false;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(""))
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            } 
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Equals("Contraseña"))
            {
                txtContraseña.Clear();
                txtContraseña.ForeColor = Color.DarkSlateBlue;
                errorLogIn.Visible = false;
            }
            errorLogIn.Visible = false;
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Equals(""))
            {
                txtContraseña.Text =  "Contraseña";
                txtContraseña.ForeColor = Color.DimGray;
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //Buscar Usuario Existente
            string query = "SELECT * FROM usuario WHERE usuario = '" + txtUsuario.Text + "' AND " +
           "contraseña = '" + txtContraseña.Text + "';";

            if (bd.consulta(query).Rows.Count != 0)
            {
                MenuPrincipal mp = new MenuPrincipal();
                mp.ShowDialog();
                this.Close();
            }
            else
                errorLogIn.Visible = true;
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            UserRegister ur = new UserRegister();
            ur.ShowDialog();
        }
    }
}
