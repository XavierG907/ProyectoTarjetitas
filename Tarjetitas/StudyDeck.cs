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
    public partial class StudyDeck : Form
    {
        private int idDeck;
        private int idTheme;
        private Color colorButtons;
        private Color colorPanels;
        private Color colorBackground;
        //atributos de funcionamiento del formulario
        private int corrects;
        private int wrongs;
        private int cardNum;
        DataTable cards;
        Card currentCard;

        SelectedCard cardSelected;

        //Librerias para movilizar la interfaz (libreria system.runtime.interopservices)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public StudyDeck(int _idTheme, Color _colorButtons, Color _colorPanels, Color _colorBackground, int _idDeck)
        {
            idDeck = _idDeck;
            idTheme = _idTheme;
            colorButtons = _colorButtons;
            colorPanels = _colorPanels;
            colorBackground = _colorBackground;
            InitializeComponent();

            cardNum = 0;
            corrects = 0;
            wrongs = 0;
            cardSelected = new SelectedCard();
        }

        private void StudyDeck_Load(object sender, EventArgs e)
        {
            ChangeItemsColor();
            ObtainCardsFromBD();
            UpdateFormData();
        }

        private void ChangeItemsColor()
        {
            this.BackColor = colorBackground;

            if (idTheme == 1)
                labelCardNum.ForeColor = labelIncorrectCards.ForeColor = buttonOpenCards.ForeColor = Color.Black;

            panelIncorrectCards.BackColor = colorPanels;
            buttonOpenCards.BackColor = colorButtons;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        { 
            labelCardNum.Location = new Point(308, 36);
            panelContainer.Location = new Point(261, 75);
            buttonIncorrect.Location = new Point(341, 376);
            buttonCorrect.Location = new Point(413, 376);
            labelCorrectOnes.Location = new Point(133, 184);
            labelIncorrectOnes.Location = new Point(133, 213);
            panelIncorrectCards.Visible = false;
        }

        private void buttonOpenCards_Click(object sender, EventArgs e)
        {
            labelCardNum.Location = new Point(191, 36);
            panelContainer.Location = new Point(155, 75);
            buttonIncorrect.Location = new Point(241, 376);
            buttonCorrect.Location = new Point(313, 376);
            labelCorrectOnes.Location = new Point(12, 184);
            labelIncorrectOnes.Location = new Point(12, 213);
            panelIncorrectCards.Visible = true;
        }

        private void UpdateFormData()
        {
            labelCorrectOnes.Text = "Correctas: " + corrects;
            labelIncorrectOnes.Text = "Incorrectas: " + wrongs;

            if (cardNum == cards.Rows.Count){
                NotifyResults();
                return;
            }

            currentCard = new Card(cardNum + 1, false, ref cardSelected, cards.Rows[cardNum]["frente"].ToString(), cards.Rows[cardNum]["reverso"].ToString());
            currentCard.CardType = cards.Rows[cardNum]["tipoDeTarjeta"].ToString();
            cardNum++;
            labelCardNum.Text = "Tarjeta numero: " + cardNum;
            OpenSubForm(currentCard);
        }

        private void ObtainCardsFromBD()
        {
            TarjetitasDB bd = new TarjetitasDB();
            string query = "SELECT tipoDeTarjeta, frente, reverso FROM tarjetas WHERE idBaraja = "+ idDeck +" AND elimLogica = 0;"; //obtener todas las cartas de la baraja seleccionada

            cards = bd.consulta(query);
        }

        private void NotifyResults()
        {
            buttonCorrect.Visible = buttonIncorrect.Visible = false;
            panelContainer.Visible = false;

            if (flowLayoutPanelCards.Controls.Count == 0)
                labelCardNum.Text = "Felicidades!, eres un genio!";
            else
                labelCardNum.Text = "Hace falta estudiar...";
        }

        private void OpenSubForm(object subform)
        {
            panelContainer.Visible = true;  //hacer visible el panel sobrepuesto para mostrar los submenus...

            if (this.panelContainer.Controls.Count > 0)
            { //liberar control ocupado en caso de tenerlo.
                this.panelContainer.Controls.RemoveAt(0);
            }
            //crear subform
            var sf = subform as UserControl;
            sf.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(sf);
            this.panelContainer.Tag = sf;
            sf.Show();
        }

        private void buttonIncorrect_Click(object sender, EventArgs e)
        {
            Card card = new Card(currentCard.IdOcurrence, false, ref cardSelected, currentCard.GetFront(), currentCard.GetReverse());
            card.CardType = currentCard.CardType;

            wrongs++;
            flowLayoutPanelCards.Controls.Add(card);
            UpdateFormData();
        }

        private void buttonCorrect_Click(object sender, EventArgs e)
        {
            corrects++;
            UpdateFormData();
        }
    }
}
