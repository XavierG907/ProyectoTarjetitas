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
    public partial class MyDecks : Form
    {
        //para los temas
        private int idTheme;
        private Color colorButtons;
        private Color colorPanels;
        private Color colorBackground;
        //para seleccionar barajas...
        SelectedDeck selectedDeck;



        //Librerias para movilizar la interfaz (libreria system.runtime.interopservices)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        public MyDecks(int _idTheme, Color _colorButtons, Color _colorPanels, Color _colorBackground, string user)
        {
            InitializeComponent();
            idTheme = _idTheme;
            colorButtons = _colorButtons;
            colorPanels = _colorPanels;
            colorBackground = _colorBackground;
            labelUser.Text = user;

            selectedDeck = new SelectedDeck(); //crearlo para ver el deck seleccionado.
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxDeckTitle_Enter(object sender, EventArgs e)
        {
            if(textBoxDeckTitle.Text == "Baraja sin Titulo")
            {
                textBoxDeckTitle.Clear();
            }
        }

        private void textBoxDeckTitle_Leave(object sender, EventArgs e)
        {
            if(textBoxDeckTitle.Text == "")
            {
                textBoxDeckTitle.Text = "Baraja sin Titulo";
            }
        }

        private void buttonAddDeck_Click(object sender, EventArgs e)
        {
            TarjetitasDB db = new TarjetitasDB();
            string command = "INSERT INTO baraja VALUES(0, '"+ textBoxDeckTitle.Text +"', "+ (!checkBoxDeckPrivacy.Checked).ToString() +", 0, '"+ labelUser.Text +"');";
            db.ejecutarComando(command);

            RemoveAllDecksFromFlowLayotPanel();
            ObtainDecksFromUser();
        }

        private void MyDecks_Load(object sender, EventArgs e)
        {
            panelContainer.Visible = false;
            ChangeItemsColor();
            RemoveAllDecksFromFlowLayotPanel();
            ObtainDecksFromUser();
        }

        private void ChangeItemsColor()
        {
            if(idTheme == 1){ //cambiar color de fuentes en caso de temas claros.
                labelMyDecks.ForeColor = labelTitleAddDeck.ForeColor =  labelAddTitle.ForeColor =  checkBoxDeckPrivacy.ForeColor = labelPresentation2.ForeColor = labelPresentation3.ForeColor = labelDeckTitle.ForeColor = labelDeckAuthor.ForeColor = Color.Black;
            }

            buttonPlayDeck.BackColor = buttonEditDeck.BackColor = buttonDeleteDeck.BackColor = colorButtons;

            panelMyDecks.BackColor = colorPanels;
            this.BackColor = colorBackground;
        }

        private void ObtainDecksFromUser()
        {
            TarjetitasDB bd = new TarjetitasDB();
            string query = "SELECT * FROM baraja WHERE usuario = '"+ labelUser.Text +"' AND elimLogica = 0;";

            DataTable result = bd.consulta(query);

            if(result.Rows.Count == 0){
                return;
            }

            for(int i = 0; i < result.Rows.Count; i++){
                query = "SELECT COUNT(numTarjeta) FROM tarjetas WHERE idBaraja = "+ result.Rows[i]["id"] +" AND elimLogica = 0;";
                DataTable cards = bd.consulta(query);
                AddDeckToFlowLayout(result.Rows[i]["titulo"].ToString(), int.Parse(cards.Rows[0]["COUNT(numTarjeta)"].ToString()), int.Parse(result.Rows[i]["id"].ToString()), bool.Parse(result.Rows[i]["privacidad"].ToString()));
            }
        }

        private void AddDeckToFlowLayout(string title, int numCards, int idBD, bool privacy)
        {
            DeckButton deckButton = new DeckButton(idTheme, ref selectedDeck);
            deckButton.Title = title;
            deckButton.Author = labelUser.Text;
            deckButton.Cards = numCards;
            deckButton.Privacy = privacy;
            deckButton.Color = colorButtons;
            deckButton.Id = idBD;
            deckButton.CurrentUser = labelUser.Text;

            flowLayoutPanelDecks.Controls.Add(deckButton);
        }

        private void RemoveAllDecksFromFlowLayotPanel()
        {
            flowLayoutPanelDecks.Controls.Clear();
        }

        private void buttonEditDeck_Click(object sender, EventArgs e)
        {
            if (labelDeckTitle.Text == "" && labelDeckAuthor.Text == "")
                return;
            OpenSubForm(new EditDeck(idTheme, colorButtons, colorPanels, colorBackground, labelUser.Text, selectedDeck.Id));
        }

        private void buttonDeleteDeck_Click(object sender, EventArgs e)
        {
            if (labelDeckTitle.Text == "" && labelDeckAuthor.Text == "")
                return;

            TarjetitasDB db = new TarjetitasDB();
            string command = "UPDATE baraja SET elimLogica = 1 WHERE id = "+ selectedDeck.Id +";";
            db.ejecutarComando(command);

            //eliminar lógicamente las tarjetas de dicha baraja.... si, no?
            command = "UPDATE tarjetas SET elimLogica = 1 WHERE idBaraja = "+ selectedDeck.Id +";";
            db.ejecutarComando(command);

            labelDeckTitle.Text = labelDeckAuthor.Text = ""; //vacíar objeto seleccionado
            selectedDeck.Clear();

            RemoveAllDecksFromFlowLayotPanel(); //actualizar data
            ObtainDecksFromUser();
        }

        private void timerSelection_Tick(object sender, EventArgs e)
        {
            if(selectedDeck.Id != 0){
                labelDeckTitle.Text = selectedDeck.Title;
                labelDeckAuthor.Text = selectedDeck.Author;
            }
            else{
                labelDeckTitle.Text = labelDeckAuthor.Text = "";
            }
        }

        private void OpenSubForm(object subform)
        {
            panelContainer.Visible = true;  //hacer visible el panel sobrepuesto para mostrar los submenus...

            if (this.panelContainer.Controls.Count > 0)
            { //liberar control ocupado en caso de tenerlo.
                this.panelContainer.Controls.RemoveAt(0);
            }
            //crear subform
            var sf = subform as Form;
            sf.TopLevel = false;
            sf.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(sf);
            this.panelContainer.Tag = sf;
            sf.FormClosing += MyDecks_Load;
            sf.Show();
        }

        private void contextMenuStripGames_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Estudiar Baraja") {
                OpenSubForm(new StudyDeck(idTheme, colorButtons, colorPanels, colorBackground, selectedDeck.Id));
            }
            else if (e.ClickedItem.Text == "Jugar Memorama")
            {
                OpenSubForm(new Memorama(idTheme, colorButtons, colorPanels, colorBackground, selectedDeck.Id));
            }
        }

        private void buttonPlayDeck_MouseClick(object sender, MouseEventArgs e)
        {
            if (labelDeckTitle.Text == "" && labelDeckAuthor.Text == "")
                return;

            contextMenuStripGames.Show(buttonPlayDeck, new Point(e.X, e.Y));
        }
    }
}
