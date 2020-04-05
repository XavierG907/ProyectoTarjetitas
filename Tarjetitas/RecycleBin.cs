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
    public partial class RecycleBin : Form
    {
        //para los temas
        int idTheme;
        Color colorButtons;
        Color colorPanels;
        Color colorBackground;
        //para seleccionar barajas...
        SelectedDeck deckSelected;


        //Librerias para movilizar la interfaz (libreria system.runtime.interopservices)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public RecycleBin(int _idTheme, Color _colorButtons, Color _colorPanels, Color _colorBackground, string user)
        {
            InitializeComponent();
            idTheme = _idTheme;
            colorButtons = _colorButtons;
            colorPanels = _colorPanels;
            colorBackground = _colorBackground;
            labelUser.Text = user;
            deckSelected = new SelectedDeck();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RecycleBin_Load(object sender, EventArgs e)
        {
            panelContainer.Visible = false; //ocultar panel sobrepuesto para mostrar la interfaz inicial.
            ChangeItemsColor();
            RemoveDecksFromFlowLayotPanelDecks();
            ObtainDecksFromUser();
        }

        private void ChangeItemsColor()
        {
            if(idTheme == 1)
            {
                labelRecycleBin.ForeColor = buttonLooseCards.ForeColor = buttonCheckDeck.ForeColor = buttonDeleteDeck.ForeColor
                    = buttonRecoverDeck.ForeColor = labelDeckTitle.ForeColor = labelDeckAuthor.ForeColor
                    = labelPresentation2.ForeColor = labelPresentation3.ForeColor
                    = Color.Black;
            }
            panelRecycleBin.BackColor = colorPanels;
            this.BackColor = colorBackground;
            buttonLooseCards.BackColor = buttonCheckDeck.BackColor = buttonDeleteDeck.BackColor = buttonRecoverDeck.BackColor = colorButtons;
        }

        private void RemoveDecksFromFlowLayotPanelDecks()
        {
            flowLayoutPanelDecks.Controls.Clear();
        }

        private void ObtainDecksFromUser()
        {
            TarjetitasDB bd = new TarjetitasDB();

            string query = "SELECT * FROM baraja WHERE usuario = '"+ labelUser.Text +"' AND elimLogica = 1;";

            DataTable result = bd.consulta(query);

            if (result.Rows.Count == 0)
            {
                return;
            }

            for (int i = 0; i < result.Rows.Count; i++)
            {
                query = "SELECT COUNT(numTarjeta) FROM tarjetas WHERE idBaraja = " + result.Rows[i]["id"] + " AND elimLogica = 1;";
                DataTable cards = bd.consulta(query);
                AddDeckToFlowLayout(result.Rows[i]["titulo"].ToString(), result.Rows[i]["usuario"].ToString(), int.Parse(cards.Rows[0]["COUNT(numTarjeta)"].ToString()), int.Parse(result.Rows[i]["id"].ToString()), bool.Parse(result.Rows[i]["privacidad"].ToString()));
            }
        }

        private void AddDeckToFlowLayout(string title, string author, int numCards, int idBD, bool privacy)
        {
            DeckButton deckButton = new DeckButton(idTheme, ref deckSelected);
            deckButton.Title = title;
            deckButton.Author = author;
            deckButton.Cards = numCards;
            deckButton.Privacy = privacy;
            deckButton.Color = colorButtons;
            deckButton.Id = idBD;
            deckButton.CurrentUser = labelUser.Text;

            flowLayoutPanelDecks.Controls.Add(deckButton);
        }

        private void timerSelection_Tick(object sender, EventArgs e)
        {
            if (deckSelected.Id != 0)
            {
                labelDeckTitle.Text = deckSelected.Title;
                labelDeckAuthor.Text = deckSelected.Author;
            }
            else
            {
                labelDeckTitle.Text = labelDeckAuthor.Text = "";
            }
        }

        private void buttonLooseCards_Click(object sender, EventArgs e)
        {
            OpenSubForm(new RecycleCards(idTheme, colorButtons, colorPanels, colorBackground, labelUser.Text));
        }

        private void buttonCheckDeck_Click(object sender, EventArgs e)
        {
            if (labelDeckTitle.Text == "" && labelDeckAuthor.Text == "")
                return;

            OpenSubForm(new RecycleCards(idTheme, colorButtons, colorPanels, colorBackground, labelUser.Text, deckSelected.Id));
        }

        private void buttonRecoverDeck_Click(object sender, EventArgs e)
        {
            if (labelDeckTitle.Text == "" && labelDeckAuthor.Text == "")
                return;

            TarjetitasDB db = new TarjetitasDB();
            string command = "UPDATE baraja SET elimLogica = 0 WHERE id = " + deckSelected.Id + ";";
            db.ejecutarComando(command);

            //recuperar lógicamente las tarjetas de dicha baraja.... si, no?
            command = "UPDATE tarjetas SET elimLogica = 0 WHERE idBaraja = " + deckSelected.Id + ";";
            db.ejecutarComando(command);

            labelDeckTitle.Text = labelDeckAuthor.Text = ""; //vacíar objeto seleccionado
            deckSelected.Clear();

            RemoveDecksFromFlowLayotPanelDecks(); //actualizar data
            ObtainDecksFromUser();
        }

        private void buttonDeleteDeck_Click(object sender, EventArgs e)
        {
            if (labelDeckTitle.Text == "" && labelDeckAuthor.Text == "")
                return;

            TarjetitasDB db = new TarjetitasDB();
            string command = "DELETE FROM tarjetas WHERE idBaraja = " + deckSelected.Id + ";"; //eliminar todas las cartas asociadas a la baraja
            db.ejecutarComando(command);

            //eliminar la baraja seleccionada
            command = "DELETE FROM baraja WHERE id = " + deckSelected.Id + ";";
            db.ejecutarComando(command);

            labelDeckTitle.Text = labelDeckAuthor.Text = ""; //vacíar objeto seleccionado
            deckSelected.Clear();

            RemoveDecksFromFlowLayotPanelDecks(); //actualizar data
            ObtainDecksFromUser();
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
            sf.FormClosing += RecycleBin_Load;
            sf.Show();
        }
    }
}
