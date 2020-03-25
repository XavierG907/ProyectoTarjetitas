using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Tarjetitas
{
    public partial class MenuPrincipal : Form
    {

        //Librerias para movilizar la interfaz (libreria system.runtime.interopservices)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void OpenSubForm(object subform)
        {
            panelContainer.Visible = true;

            if (this.panelContainer.Controls.Count > 0){
                this.panelContainer.Controls.RemoveAt(0);
            }

            var sf = subform as Form;
            sf.TopLevel = false;
            sf.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(sf);
            this.panelContainer.Tag = sf;
            sf.FormClosing += MenuPrincipal_Load;
            sf.Show();
        }

        private void buttonMyDecks_Click(object sender, EventArgs e)
        {
            OpenSubForm(new MyDecks());
        }

        private void buttonPublicDecks_Click(object sender, EventArgs e)
        {

        }

        private void buttonFavoriteDecks_Click(object sender, EventArgs e)
        {

        }

        private void buttonRecycleBin_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            panelContainer.Visible = false;
        }
    }
}
