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
        private SelectedDeck selectedDeck;

        public DeckButton(int idTheme, ref SelectedDeck _selectedDeck)
        {
            InitializeComponent();
            selectedDeck = _selectedDeck;
            this.BackColor = Color.Transparent;

            if(idTheme == 1)
            {
                ChangeButtonsForeColor();
            }
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
            TarjetitasDB db = new TarjetitasDB();
            string command = "INSERT INTO baraja_usuario_favoritiza VALUES(0, "+ this.Id +", '"+ this.Author +"');";
            db.ejecutarComando(command);

            pictureBoxFavourite.Visible = true;
            pictureBoxNotFavourite.Visible = false;
        }

        private void pictureBoxFavourite_Click(object sender, EventArgs e)
        {
            //Quitar de favoritos la baraja seleccionada.
            TarjetitasDB db = new TarjetitasDB();
            string command = "DELETE FROM baraja_usuario_favoritiza WHERE idBaraja = "+ this.Id +" AND usuario = '"+ this.Author +"';";
            db.ejecutarComando(command);

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

        private void ChangeButtonsForeColor()
        {
            labelAuthor.ForeColor = labelTitle.ForeColor = labelNumCards.ForeColor = Color.Black;
        }

        private void DeckButton_Load(object sender, EventArgs e)
        {
            TarjetitasDB db = new TarjetitasDB();
            string query = "SELECT id FROM baraja_usuario_favoritiza WHERE usuario = '"+ this.Author +"' AND idBaraja = "+ this.Id +";";

            DataTable result = db.consulta(query);

            if(result.Rows.Count == 0){
                pictureBoxNotFavourite.Visible = true;
                pictureBoxFavourite.Visible = false;
            }
            else{
                pictureBoxNotFavourite.Visible = false;
                pictureBoxFavourite.Visible = true;
            }
        }

        private void panelContainer_Click(object sender, EventArgs e)
        {
            selectedDeck.Id = this.Id;
            selectedDeck.Title = this.Title;
            selectedDeck.Author = this.Author;
        }
    }


    public class SelectedDeck
    {
        public int Id;
        public string Title;
        public string Author;

        public SelectedDeck()
        {
            Id = 0;
            Title = "";
            Author = "";
        }

        public void Clear()
        {
            Id = 0;
            Title = "";
            Author = "";
        }
    }
}
