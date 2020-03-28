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
    public partial class MyDecks : Form
    {
        private int idTheme;
        private Color colorButtons;
        private Color colorPanels;
        private Color colorBackground;

        public MyDecks(int _idTheme, Color _colorButtons, Color _colorPanels, Color _colorBackground, string user)
        {
            InitializeComponent();
            idTheme = _idTheme;
            colorButtons = _colorButtons;
            colorPanels = _colorPanels;
            colorBackground = _colorBackground;
            labelUser.Text = user;
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
            ChangeItemsColor();
            ObtainDecksFromUser();
        }

        private void ChangeItemsColor()
        {
            if(idTheme == 1){ //cambiar color de fuentes en caso de temas claros.
                labelMyDecks.ForeColor = labelTitleAddDeck.ForeColor =  labelAddTitle.ForeColor =  checkBoxDeckPrivacy.ForeColor = Color.Black;
            }

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
                query = "SELECT COUNT(numTarjeta) FROM tarjetas WHERE idBaraja = "+ result.Rows[i]["id"] +";";
                DataTable cards = bd.consulta(query);
                AddDeckToFlowLayout(result.Rows[i]["titulo"].ToString(), int.Parse(cards.Rows[0]["COUNT(numTarjeta)"].ToString()), int.Parse(result.Rows[i]["id"].ToString()), i + 1, bool.Parse(result.Rows[i]["privacidad"].ToString()));
            }
        }

        private void AddDeckToFlowLayout(string title, int numCards, int idBD, int idOcurrence, bool privacy)
        {
            DeckButton deckButton = new DeckButton(idTheme);
            deckButton.Title = title;
            deckButton.Author = labelUser.Text;
            deckButton.Cards = numCards;
            deckButton.Privacy = privacy;
            deckButton.Color = colorButtons;
            deckButton.Id = idBD;
            deckButton.IdOcurrence = idOcurrence;

            flowLayoutPanelDecks.Controls.Add(deckButton);
        }

        private void RemoveAllDecksFromFlowLayotPanel()
        {
            flowLayoutPanelDecks.Controls.Clear();
        }
    }
}
