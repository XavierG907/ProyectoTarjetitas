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
    public partial class EditDeck : Form
    {
        private int idDeck;
        private int idTheme;
        private Color colorButtons;
        private Color colorPanels;
        private Color colorBackground;
        SelectedCard cardSelected;  //atributo para seleccionar cartas
        TarjetitasDB bd;
        public EditDeck(int _idTheme, Color _colorButtons, Color _colorPanels, Color _colorBackground, string user, int _idDeck)
        {
            InitializeComponent();
            idTheme = _idTheme;
            idDeck = _idDeck;
            colorButtons = _colorButtons;
            colorPanels = _colorPanels;
            colorBackground = _colorBackground;
            labelUser.Text = user;

            cardSelected = new SelectedCard();  //inicializar valores de la carta a seleccionar
            bd = new TarjetitasDB();
        }

        private void buttonAddCard_Click(object sender, EventArgs e)
        {
            string command = "INSERT INTO tarjetas VALUES(0, 'TEXT', 'Inserte el texto aquí', 'Inserte el texto aquí', 0, " + idDeck +", '"+ labelUser.Text +"');"; //insertar nueva tarjeta en tarjetas.
            bd.ejecutarComando(command);

            RemoveAllControlsFromFlowLayoutPanelCards();
            SetCardsToFlowLayoutPanelCards();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close(); //salir de edición de tarjeta
        }

        private void buttonDeleteCard_Click(object sender, EventArgs e)
        {
            if (cardSelected.IdOcurrence == 0) //siempre y cuando haya una tarjeta seleccionada
                return;

            string command = "UPDATE tarjetas SET elimLogica = 1 WHERE numTarjeta = "+ cardSelected.CardNumber +";"; //eliminar la tarjeta seleccionada
            bd.ejecutarComando(command);

            RemoveAllControlsFromFlowLayoutPanelCards();
            SetCardsToFlowLayoutPanelCards();

            cardSelected.Clear(); //limpiar la tarjeta seleccionada
            labelSelectedCard.Text = ""; //limpiar texto del label de la tarjeta seleccionada
        }

        private void timerSelectedCard_Tick(object sender, EventArgs e)
        {
            if (cardSelected.IdOcurrence == 0){ //siemre y cuando haya una tarjeta seleccionada
                labelSelectedCard.Text = "";
                return;
            }

            labelSelectedCard.Text = cardSelected.IdOcurrence.ToString(); //asignarla al label de tarjeta seleccionada
        }

        private void EditCards_Load(object sender, EventArgs e)
        {
            ChangeColorItems();
            ObtainDeckData();
            RemoveAllControlsFromFlowLayoutPanelCards();
            SetCardsToFlowLayoutPanelCards();
        }

        private void ChangeColorItems()
        {
            if(idTheme == 1){ //cambiar color de fuentes en caso de temas claros.
                labelEditCards.ForeColor = labelDeckTitle.ForeColor =  checkBoxDeckPublic.ForeColor =  labelPresentation2.ForeColor = labelSelectedCard.ForeColor = Color.Black;
            }

            buttonAddCard.BackColor = buttonDeleteCard.BackColor = colorButtons;
            panelEditCards.BackColor = colorPanels;
            this.BackColor = colorBackground;
        }

        private void ObtainDeckData()
        {
            string query = "SELECT * FROM baraja WHERE id = " + idDeck + ";"; //obtener la información de la baraja

            DataTable deckInfo = bd.consulta(query);

            if (deckInfo.Rows.Count == 0)
                return;

            textBoxDeckTitle.Text = deckInfo.Rows[0]["titulo"].ToString();
            checkBoxDeckPublic.Checked = !bool.Parse(deckInfo.Rows[0]["privacidad"].ToString());
        }

        private void RemoveAllControlsFromFlowLayoutPanelCards()
        {
            flowLayoutPanelCards.Controls.Clear();
        }

        private void SetCardsToFlowLayoutPanelCards()
        {
            string query = "SELECT * FROM tarjetas WHERE idBaraja = "+ idDeck +" AND elimLogica = 0;"; //obtener todas las cartas pertenecientes a dicha baraja

            DataTable cards = bd.consulta(query);

            for (int i = 0; i < cards.Rows.Count; i++)
            {
                Card card = new Card(i + 1, true, ref cardSelected, cards.Rows[i]["frente"].ToString(), cards.Rows[i]["reverso"].ToString());
                card.CardType = cards.Rows[i]["tipoDeTarjeta"].ToString();
                card.CardNumber = int.Parse(cards.Rows[i]["numTarjeta"].ToString());

                flowLayoutPanelCards.Controls.Add(card);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string command = "UPDATE baraja SET titulo = '"+ textBoxDeckTitle.Text +"', privacidad = "+ !checkBoxDeckPublic.Checked +" WHERE id = "+ idDeck +";"; //guardar el titulo y la privacidad establecida en la baraja.
            bd.ejecutarComando(command);
        }
    }
}
