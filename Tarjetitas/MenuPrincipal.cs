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
        private bool loggedOut; //bandera utilizada para saber si el usuario cerro sesión o cerró la aplicación.

        //id de tema y temas utilizados según el usuario que logro iniciar sesión.
        private int idTheme;
        private Color colorButtons;
        private Color colorPanels;
        private Color colorBackground;

        //Librerias para movilizar la interfaz (libreria system.runtime.interopservices)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public MenuPrincipal(string user)
        {
            InitializeComponent();
            labelUser.Text = user; //para mantener rastro del usuario que inició sesión por medio de login.
            loggedOut = false;  //en un principio, se da por entendido que el usuario cerrará la aplicación.
        }

        private void OpenSubForm(object subform)
        {
            panelContainer.Visible = true;  //hacer visible el panel sobrepuesto para mostrar los submenus...

            if (this.panelContainer.Controls.Count > 0){ //liberar control ocupado en caso de tenerlo.
                this.panelContainer.Controls.RemoveAt(0);
            }
            //crear subform
            var sf = subform as Form;   
            sf.TopLevel = false;
            sf.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(sf);
            this.panelContainer.Tag = sf;
            sf.FormClosing += MenuPrincipal_Load;
            sf.Show();
        }

        public bool LoggedOut() //utilizado para saber si el usuario cerró sesión o cerró la aplicación
        {
            return loggedOut;
        }

        private void buttonMyDecks_Click(object sender, EventArgs e)
        {
            OpenSubForm(new MyDecks(idTheme, colorButtons, colorPanels, colorBackground, labelUser.Text)); //abrir subMenu MyDecks
        }

        private void buttonPublicDecks_Click(object sender, EventArgs e)
        {
            OpenSubForm(new OtherDecks(idTheme, colorButtons, colorPanels, colorBackground, labelUser.Text, "Barajas Públicas")); //abrir subMenu barajas públicas
        }

        private void buttonFavoriteDecks_Click(object sender, EventArgs e)
        {
            OpenSubForm(new OtherDecks(idTheme, colorButtons, colorPanels, colorBackground, labelUser.Text, "Barajas Favoritas")); //abrir subMenu barajas favoritas
        }

        private void buttonRecycleBin_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            panelContainer.Visible = false; //ocultar panel sobrepuesto para mostrar menu principal.
            ObtainThemeFromUser();          //obtener los temas del usuario.
            ChangeItemsColor();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            loggedOut = true; //en este método el usuario cerró sesión, entonces hay que notificarlo con la bandera
            this.Close();
        }

        private void ObtainThemeFromUser()
        {
            TarjetitasDB bd = new TarjetitasDB(); //declarar conexion a BD

            string query = "SELECT id, rgb_boton, rgb_panel, rgb_fondo FROM tema" +
                " INNER JOIN usuario ON usuario.idTema = tema.id WHERE usuario = '"+ labelUser.Text +"';";

            DataTable result = bd.consulta(query); //obtener la tupla deseada
            
            if(result.Rows.Count == 0){
                MessageBox.Show("Error al cargar temas de usuario.");
                this.Close();
            }

            idTheme = int.Parse(result.Rows[0]["id"].ToString());
            colorButtons = System.Drawing.ColorTranslator.FromHtml(result.Rows[0]["rgb_boton"].ToString());
            colorPanels = System.Drawing.ColorTranslator.FromHtml(result.Rows[0]["rgb_panel"].ToString());
            colorBackground = System.Drawing.ColorTranslator.FromHtml(result.Rows[0]["rgb_fondo"].ToString());
        }

        private void ChangeItemsColor()
        {
            buttonMyDecks.BackColor = buttonPublicDecks.BackColor = buttonFavoriteDecks.BackColor = buttonRecycleBin.BackColor = colorButtons;
            this.BackColor = colorBackground;
            panelMainMenu.BackColor = colorPanels;

            if(idTheme == 1){ //en caso de temas claros, cambiar el titulo a blanco, al igual que los textos.
                labelMain.ForeColor = Color.Black;
                buttonMyDecks.ForeColor = buttonPublicDecks.ForeColor = buttonFavoriteDecks.ForeColor = buttonRecycleBin.ForeColor = Color.Black;
            }
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            
        }
    }
}
