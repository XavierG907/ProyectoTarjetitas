using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarjetitas
{
    public partial class DeckButton : UserControl
    {
        public DeckButton()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
        }

        //variables utilizadas para las propiedades...
        private string _title;
        private string _author;
        private int _cards;
        private int _id;
        private Color _color;
        private bool _privacy;

        [Category("Propiedades Personalizadas")]
        public string Title
        {
            get { return _title; }
            set { _title = value; labelTitle.Text = _title; }
        }

        [Category("Propiedades Personalizadas")]
        public string Author
        {
            get { return _author; }
            set { _author = value; labelAuthor.Text += _author; }
        }

        [Category("Propiedades Personalizadas")]
        public int Cards
        {
            get { return _cards; }
            set { _cards = value; labelNumCards.Text += _cards; }
        }

        [Category("Propiedades Personalizadas")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Category("Propiedades Personalizadas")]
        public Color Color
        {
            get { return _color; }
            set { _color = value; panelContainer.BackColor = _color;}
        }

        [Category("Propiedades Personalizadas")]
        public bool Privacy
        {
            get { return _privacy; }
            set { _privacy = value; }
        }


        private void pictureBoxNotFavourite_Click(object sender, EventArgs e)
        {
            //Agregar a favoritos la baraja seleccionada.
            pictureBoxFavourite.Visible = true;
            pictureBoxNotFavourite.Visible = false;
        }

        private void pictureBoxFavourite_Click(object sender, EventArgs e)
        {
            //Quitar de favoritos la baraja seleccionada.
            pictureBoxFavourite.Visible = false;
            pictureBoxNotFavourite.Visible = true;
        }

        private void panelContainer_MouseEnter(object sender, EventArgs e)
        {
            panelContainer.BackColor = Color.DarkGray;
        }

        private void panelContainer_MouseLeave(object sender, EventArgs e)
        {
            panelContainer.BackColor = this.Color;
        }
    }
}
