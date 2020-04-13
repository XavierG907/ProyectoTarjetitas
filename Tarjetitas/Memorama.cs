using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarjetitas
{
    public partial class Memorama : Form
    {
        string usuario;
        Color boton;
        Color panel;
        Color fondo;
        DataTable tarjetas;
        TarjetitasDB db = new TarjetitasDB();
        Thread juego;
        int time = 0;
        int id_baraja;
        int totalCards;
        int limit;
        int totalErrores;
        int totalAciertos;
        List<int> id_FrontCards;
        List<int> id_BackCards;
        Card currentFront;
        Card currentBack;
        TableLayoutPanel FrontCards;
        TableLayoutPanel BackCards;
        SelectedCard cardSelected;
        bool IsPlaying;
        public Memorama(int _idTheme, Color _colorButtons, Color _colorPanels, Color _colorBackground, int _id_baraja)
        {
            InitializeComponent();
            
            this.BackColor = _colorBackground;
            limit = 20;
            id_FrontCards = new List<int>();
            id_BackCards = new List<int>();
            juego = new Thread(Inicio);
            cardSelected = new SelectedCard();

            panel = _colorPanels;
            fondo = _colorBackground;
            boton = _colorButtons;
            id_baraja = _id_baraja;

            CheckForIllegalCrossThreadCalls = false;
            tiempo.Text = time.ToString();
            btnBack.Visible = false;
            btnFront.Visible = false;
            error.Visible = false;
            acierto.Visible = false;
            btnContinue.Visible = false;
            currentBack = null;
            currentFront = null;
            totalAciertos = 0;
            totalErrores = 0;
            IsPlaying = false;

            GetAllCards();
            chooseAtMost20Cards();
            LoadCards(panelFront,id_FrontCards,'F', ref FrontCards);
            LoadCards(panelBack, id_BackCards, 'B', ref BackCards);
            panelFront.Enabled = false;
            panelBack.Enabled = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (juego.IsAlive)
                juego.Abort();
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panelFront.Enabled = true;
            panelBack.Enabled = true;
            btnStart.Enabled = false;
            btnStart.Visible = false;

            IsPlaying = true;
            juego = new Thread(this.Inicio);
            juego.Start();
        }
        void Inicio()
        {
            while (IsPlaying)
            {
                tiempo.Text = time.ToString();
                Thread.Sleep(1000);
                time++;
            }
        }
        void GetAllCards()
        {
            string query = "SELECT * FROM tarjetas WHERE idBaraja="+id_baraja.ToString()+" AND elimLogica=0;";
            tarjetas = db.consulta(query);
        }

        private void Memorama_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (juego.IsAlive)
                juego.Abort();
        }
        bool chooseAtMost20Cards()
        {
            if (tarjetas.Rows.Count < 5)
                return false;
            else if (tarjetas.Rows.Count >= 5 && tarjetas.Rows.Count <= limit)
                totalCards = tarjetas.Rows.Count;
            else
                totalCards = limit;
            //Aqui creo una lista con los id's de las cartas y creo una copia
            List<int> temp = new List<int>();
            for (int i=0; i < totalCards; i++)
            {
                temp.Add(i);
            }
            List<int> copia = new List<int>(temp);

            //Almaceno aleatoriamente estos id's en la lista de la parte de enfrente y la lista para la parte de detras
            var seed = Environment.TickCount;
            var random = new Random(seed);
            int index = totalCards, aleat;
            while (index-- != 0)
            {
                aleat = random.Next(0, index);
                id_FrontCards.Add(temp[aleat]);
                temp.RemoveAt(aleat);
            }
            index = totalCards;
            while (index-- != 0)
            {
                aleat = random.Next(0, index);
                id_BackCards.Add(copia[aleat]);
                copia.RemoveAt(aleat);
            }
            return true;
        }
        void LoadCards(Panel p, List<int> cartas, char type, ref TableLayoutPanel tablaPanel) //F para front y B para back
        {
            //p.Controls.Clear();
            tablaPanel = new TableLayoutPanel();
            if (type == 'F')
                tablaPanel.Name = "tlpFront";
            else
                tablaPanel.Name = "tlpBack";
            tablaPanel.RowCount = 5;
            tablaPanel.ColumnCount = 4;
            for (int i = 0; i < limit; i++)
            {
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30));
            }

            for (var i = 0; i < totalCards; i++)
            {
                var CartasJuego = new PictureBox();
                CartasJuego.Name = type + cartas[i].ToString();
                CartasJuego.Dock = DockStyle.Fill;
                CartasJuego.SizeMode = PictureBoxSizeMode.Zoom;
                CartasJuego.BackColor = Color.Transparent;
                CartasJuego.Image = Properties.Resources.Girada;
                CartasJuego.Cursor = Cursors.Hand;
                CartasJuego.Click += (sender, EventArgs) => { ShowContent(sender, EventArgs, CartasJuego); };
                tablaPanel.Controls.Add(CartasJuego, i%4, i/5);
            }
            tablaPanel.Dock = DockStyle.Fill;
            p.Controls.Add(tablaPanel);
        }
        void ShowContent(object sender, EventArgs e, PictureBox pb)
        {
            //Mostrar carta
            int id = int.Parse(pb.Name.Substring(1));
            if (pb.Name[0] == 'F')
            {
                btnFront.Visible = true;
                FrontCards.Visible = false;
                ShowCardSelected(ref currentFront, id, panelFront, false);
            }
            else
            {
                btnBack.Visible = true;
                BackCards.Visible = false;
                ShowCardSelected(ref currentBack, id, panelBack, true);
            }
        }
        void ShowCardSelected(ref Card currentCard, int id, Panel p, bool voltear)
        {
            Card form = Application.OpenForms.OfType<Card>().FirstOrDefault();
            currentCard = form ?? new Card(id + 1, false, ref cardSelected, tarjetas.Rows[id]["frente"].ToString(), tarjetas.Rows[id]["reverso"].ToString());
            currentCard.CardType = tarjetas.Rows[id]["tipoDeTarjeta"].ToString();
            if (voltear)
                currentCard.voltearCarta();
            currentCard.deshabilitarReverso();
            currentCard.Dock = DockStyle.Fill;
            p.Controls.Add(currentCard);
            p.Tag = currentCard;
            currentCard.Show();

            //Verificar si hay par
            if (currentBack != null && currentFront != null)
            {
                if (currentBack.IdOcurrence == currentFront.IdOcurrence)
                {
                    acierto.Visible = true;
                    totalAciertos++;
                }
                else
                {
                    totalErrores++;
                    error.Visible = true;
                }
                updateForm();
                btnContinue.Visible = true;
                btnBack.Visible = false;
                btnFront.Visible = false;
            }
        }

        private void btnFront_Click(object sender, EventArgs e)
        {
            FrontCards.Visible = true;
            btnFront.Visible = false;
            panelFront.Controls.RemoveAt(4);
            currentFront = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackCards.Visible = true;
            btnBack.Visible = false;
            panelBack.Controls.RemoveAt(3);
            currentBack = null;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            FrontCards.Visible = true;
            panelFront.Controls.RemoveAt(4);
            BackCards.Visible = true;
            panelBack.Controls.RemoveAt(3);
            btnContinue.Visible = false;
            acierto.Visible = false;
            error.Visible = false;
            currentFront = null;
            currentBack = null;
        }
        void updateForm()
        {
            labelAciertos.Text = totalAciertos.ToString();
            labelErrores.Text = totalErrores.ToString();
        }
    }
}
