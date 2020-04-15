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
        int remainingClues;
        List<int> id_FrontCards;
        List<int> id_BackCards;
        Card currentFront;
        Card currentBack;
        TableLayoutPanel FrontCards;
        TableLayoutPanel BackCards;
        SelectedCard cardSelected;
        PictureBox pbCurrentBack = new PictureBox();
        PictureBox pbCurrentFront = new PictureBox();
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
            btnClues.Enabled = false;

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
            btnStart.Visible = false;
            btnClues.Enabled = true;
            remainingClues = 3;

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
                tablaPanel.Controls.Add(CartasJuego);
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
                pbCurrentFront = pb;
                ShowCardSelected(ref currentFront, id, panelFront, false);
            }
            else
            {
                btnBack.Visible = true;
                BackCards.Visible = false;
                pbCurrentBack = pb;
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
                    deleteCardPair();
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
        void deleteCardPair()
        {
            pbCurrentFront.Image = null;
            pbCurrentFront.Enabled = false;

            pbCurrentBack.Image = null;
            pbCurrentBack.Enabled = false;

            if (totalAciertos == totalCards)
            {
                IsPlaying = false;
                btnStart.Text = "Volver a jugar";
                btnStart.Visible = true;
            }
        }

        private void btnClues_Click(object sender, EventArgs e) //Funcion para dar una pista
        {
            if (remainingClues == 0)
            {
                return;
            }
            remainingClues--;
            btnClues.Enabled = false;
            string s = "";
            for (int i=0; i < totalCards; i++)
            {
                if (!FrontCards.Controls[i].Enabled)
                {
                    continue;
                }
                for (int j=0; j < totalCards; j++)
                {
                    if (FrontCards.Controls[i].Name.Substring(1) == BackCards.Controls[j].Name.Substring(1))
                    {
                        ShowClue(FrontCards.Controls[i], BackCards.Controls[j]);
                        return;
                    }
                }
            }
            btnClues.Enabled = true;
        }
        void ShowClue(Control pbF, Control pbB)
        {
            Thread DrawClue = new Thread(drawing);
            DrawClue.Start();
            void drawing()
            {
                int i = 6;
                while (i-- != 0)
                {
                    if (pbF.BackColor == Color.Silver)
                    {
                        pbB.BackColor = Color.Transparent;
                        pbF.BackColor = Color.Transparent;
                    }
                    else
                    {
                        pbB.BackColor = Color.Silver;
                        pbF.BackColor = Color.Silver;
                    }
                    Thread.Sleep(300);
                }
                btnClues.Enabled = true;
            }
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            string s = "\n\n1° Para comenzar a jugar necesita presionar el boton de \"COMENZAR\"\n\n" +
                "2° Al jugar se contara con un cronometro para medir el tiempo que requeriste para resolver el memorama\n\n" +
                "3° Cuentas con solamente tres pistas (pares) que indican la posicion de las cartas\n\n" +
                "4° Si aun con esto no te sientes seguro de lo que puedes hacer, pulsa en el boton con el simbolo \"?\" para acceder a la guia de usuario\n\n" +
                "NOTA: El tiempo no se guarda, solo se muestra durante y al final de cada partida\n\n\n" +
                "DIVIERTETE Y ESTUDA!!";
            Form temp = new Form();
            Label l = new Label();
            l.Text = s;
            l.Font = new Font("Arial", 10, FontStyle.Bold);
            l.ForeColor = Color.White;
            l.AutoSize = true;

            Button continuar = new Button();
            continuar.Text = "Continuar";
            continuar.BackColor = Color.Red;
            continuar.Font = new Font("Arial", 12, FontStyle.Bold);
            continuar.ForeColor = Color.White;
            continuar.Location = new Point(850, 220);
            continuar.AutoSize = true;
            continuar.Cursor = Cursors.Hand;
            continuar.FlatStyle = FlatStyle.Popup;
            continuar.Click += (_sender, _EventArgs) => { btnContinuar_Click(_sender, _EventArgs); };

            void btnContinuar_Click(object _sender, EventArgs _e)
            {
                temp.Close();
            }

            temp.Controls.Add(continuar);
            temp.Controls.Add(l);
            temp.AutoSize = true;
            temp.BackColor = ColorTranslator.FromHtml("#253449");
            temp.Text = "INSTRUCCIONES";
            //temp.FormBorderStyle = FormBorderStyle.None;
            temp.MaximizeBox = false;
            temp.MinimizeBox = false;
            temp.StartPosition = FormStartPosition.CenterScreen;

            temp.ShowDialog();
        }
    }
}
