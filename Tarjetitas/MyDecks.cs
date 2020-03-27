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
        public MyDecks()
        {
            InitializeComponent();
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
            DeckButton db = new DeckButton();
            db.Title = textBoxDeckTitle.Text;
            db.Author = labelUser.Text;
            db.Cards = 0;
            db.Privacy = !checkBoxDeckPrivacy.Checked;
            db.Color = Color.Crimson; //obtener de bd
            db.Id = 0; //obtenerlo de la bd

            //agregarlo a la flowLayoutPanel.
            flowLayoutPanelDecks.Controls.Add(db);
        }
    }
}
