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
    public partial class RecycleCards : Form
    {
        //para los temas
        int idTheme;
        Color colorButtons;
        Color colorPanels;
        Color colorBackground;

        //para funcionamiento de la clase
        int idDeck;
        List<int> idAviableDecks;
        SelectedCard cardSelected;
        TarjetitasDB db;

        public RecycleCards(int _idTheme, Color _colorButtons, Color _colorPanels, Color _colorBackground, string user, int _idDeck = 0)
        {
            InitializeComponent();
            idTheme = _idTheme;
            colorButtons = _colorButtons;
            colorPanels = _colorPanels;
            colorBackground = _colorBackground;
            labelUser.Text = user;
            idDeck = _idDeck;

            cardSelected = new SelectedCard();
            idAviableDecks = new List<int>();
            db = new TarjetitasDB();

            labelRecycleCards.Text = idDeck == 0 ? "Tarjetas Eliminadas Sueltas" : "Tarjetas Eliminadas Asociadas a una Baraja";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RecycleCards_Load(object sender, EventArgs e)
        {
            ChangeItemsColor();
            GetAviableDecksFromUser();
            RemoveCardsFromFlowLayoutPanelCards();
            SetCardsToFlowLayotPanelCards();
        }

        private void ChangeItemsColor()
        {
            if(idTheme == 1)
            {
                labelRecycleCards.ForeColor = labelRecoveCard.ForeColor = labelPresentation2.ForeColor
                    = labelSelectedCard.ForeColor
                    = buttonRecoveCard.ForeColor = buttonDeleteCard.ForeColor = Color.Black;
            }
            panelRecycleCards.BackColor = colorPanels;
            this.BackColor = colorBackground;
            buttonRecoveCard.BackColor = buttonDeleteCard.BackColor = colorButtons;
        }

        private void GetAviableDecksFromUser()
        {
            string query = "SELECT id, titulo FROM baraja WHERE usuario = '"+ labelUser.Text +"' AND elimLogica = 0;";

            DataTable result = db.consulta(query);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                idAviableDecks.Add(int.Parse(result.Rows[i]["id"].ToString()));
                comboBoxRecoveCard.Items.Add(result.Rows[i]["titulo"].ToString());
            }

            if (idAviableDecks.Count > 0)
                comboBoxRecoveCard.SelectedIndex = 0;
        }

        private void RemoveCardsFromFlowLayoutPanelCards()
        {
            flowLayoutPanelCards.Controls.Clear();
        }

        private void SetCardsToFlowLayotPanelCards()
        {
            string query = idDeck == 0
                ? "SELECT t1.* FROM tarjetas t1 INNER JOIN baraja t2 ON t1.idBaraja = t2.id WHERE t1.elimLogica = 1 AND t2.elimLogica = 0 AND t1.usuario = '"+ labelUser.Text +"';"
                : "SELECT * FROM tarjetas WHERE idBaraja = "+ idDeck +" AND elimLogica = 1";

            DataTable cards = db.consulta(query);

            for (int i = 0; i < cards.Rows.Count; i++)
            {
                Card card = new Card(i + 1, false, ref cardSelected, cards.Rows[i]["frente"].ToString(), cards.Rows[i]["reverso"].ToString());
                card.CardType = cards.Rows[i]["tipoDeTarjeta"].ToString();
                card.CardNumber = int.Parse(cards.Rows[i]["numTarjeta"].ToString());

                flowLayoutPanelCards.Controls.Add(card);
            }
        }

        private void timerSelection_Tick(object sender, EventArgs e)
        {
            if (cardSelected.IdOcurrence == 0)
            { //siemre y cuando haya una tarjeta seleccionada
                labelSelectedCard.Text = "";
                return;
            }

            labelSelectedCard.Text = cardSelected.IdOcurrence.ToString(); //asignarla al label de tarjeta seleccionada
        }

        private void buttonRecoveCard_Click(object sender, EventArgs e)
        {
            if (cardSelected.IdOcurrence == 0) //siempre y cuando haya una tarjeta seleccionada
                return;

            string command = "UPDATE tarjetas SET elimLogica = 0 WHERE numTarjeta = "+ cardSelected.CardNumber +";";
            db.ejecutarComando(command);

            command = "UPDATE tarjetas SET idBaraja = "+ idAviableDecks[comboBoxRecoveCard.SelectedIndex] +" WHERE numTarjeta = "+ cardSelected.CardNumber +";";
            db.ejecutarComando(command);

            RemoveCardsFromFlowLayoutPanelCards();
            SetCardsToFlowLayotPanelCards();

            cardSelected.Clear(); //limpiar la tarjeta seleccionada
            labelSelectedCard.Text = ""; //limpiar texto del label de la tarjeta seleccionada
        }

        private void buttonDeleteCard_Click(object sender, EventArgs e)
        {
            if (cardSelected.IdOcurrence == 0) //siempre y cuando haya una tarjeta seleccionada
                return;

            string command = "DELETE FROM tarjetas WHERE numTarjeta = "+ cardSelected.CardNumber +";";
            db.ejecutarComando(command);
            
            RemoveCardsFromFlowLayoutPanelCards();
            SetCardsToFlowLayotPanelCards();

            cardSelected.Clear(); //limpiar la tarjeta seleccionada
            labelSelectedCard.Text = ""; //limpiar texto del label de la tarjeta seleccionada
        }
    }
}
