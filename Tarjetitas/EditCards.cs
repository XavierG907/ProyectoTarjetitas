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
    public partial class EditCards : Form
    {
        private int idDeck;
        private int idTheme;
        private Color colorButtons;
        private Color colorPanels;
        private Color colorBackground;
        SelectedCard cardSelected;  //atributo para seleccionar cartas
        public EditCards(int _idTheme, Color _colorButtons, Color _colorPanels, Color _colorBackground, string user, int _idDeck)
        {
            InitializeComponent();
            idTheme = _idTheme;
            idDeck = _idDeck;
            colorButtons = _colorButtons;
            colorPanels = _colorPanels;
            colorBackground = _colorBackground;
            labelUser.Text = user;

            cardSelected = new SelectedCard();  //inicializar valores de la carta a seleccionar
        }

        private void buttonAddCard_Click(object sender, EventArgs e)
        {
            Card card = new Card(flowLayoutPanelCards.Controls.Count + 1, true, ref cardSelected); //mostrar nueva carta
            flowLayoutPanelCards.Controls.Add(card);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close(); //salir de edición de tarjeta
        }

        private void buttonDeleteCard_Click(object sender, EventArgs e)
        {
            if (cardSelected.IdOcurrence == 0) //siempre y cuando haya una tarjeta seleccionada
                return;
        }

        private void timerSelectedCard_Tick(object sender, EventArgs e)
        {
            if (cardSelected.IdOcurrence == 0) //siemre y cuando haya una tarjeta seleccionada
                return;

            labelSelectedCard.Text = cardSelected.IdOcurrence.ToString(); //asignarla al label de tarjeta seleccionada
        }

        private void EditCards_Load(object sender, EventArgs e)
        {
            ChangeColorItems();
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
    }
}
