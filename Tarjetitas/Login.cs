using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarjetitas
{
    public partial class Login : Form
    {
        TarjetitasDB bd = new TarjetitasDB();
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
            }
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

            MenuPrincipal mp = new MenuPrincipal();
            mp.ShowDialog();
            this.Close();
        }
    }
}
