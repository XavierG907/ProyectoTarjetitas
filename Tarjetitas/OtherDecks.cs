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
using System.Diagnostics;
using System.IO;

namespace Tarjetitas
{
    public partial class OtherDecks : Form
    {
        //para los temas
        private int idTheme;
        private Color colorButtons;
        private Color colorPanels;
        private Color colorBackground;
        //para seleccionar barajas...
        SelectedDeck deckSelected;


        //Librerias para movilizar la interfaz (libreria system.runtime.interopservices)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public OtherDecks(int _idTheme, Color _colorButtons, Color _colorPanels, Color _colorBackground, string user, string typeMenu)
        {
            InitializeComponent();
            idTheme = _idTheme;
            colorButtons = _colorButtons;
            colorPanels = _colorPanels;
            colorBackground = _colorBackground;
            labelUser.Text = user;
            labelDecksTitle.Text = typeMenu;
            deckSelected = new SelectedDeck(); //crearlo para ver el deck seleccionado.
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OtherDecks_Load(object sender, EventArgs e)
        {
            panelContainer.Visible = false;
            ChangeItemsColor();
            RemoveAllDecksFromFlowLayotPanel();
            ObtainDecksFromUser();
        }

        private void ChangeItemsColor()
        {
            if (idTheme == 1)
            { //cambiar color de fuentes en caso de temas claros.
                labelDecksTitle.ForeColor = labelPresentation2.ForeColor = labelPresentation3.ForeColor = labelDeckTitle.ForeColor = labelDeckAuthor.ForeColor = Color.Black;
            }

            buttonStudyDeck.BackColor = buttonStudyDeck.BackColor = buttonPlayMemorama.BackColor = buttonExportPDF.BackColor = colorButtons;

            panelOtherDecks.BackColor = colorPanels;
            this.BackColor = colorBackground;
        }

        private void RemoveAllDecksFromFlowLayotPanel()
        {
            flowLayoutPanelDecks.Controls.Clear();
        }

        private void ObtainDecksFromUser()
        {
            TarjetitasDB bd = new TarjetitasDB();

            string query = labelDecksTitle.Text == "Barajas Públicas"
                ? "SELECT * FROM baraja WHERE privacidad = 0 AND elimLogica = 0;"
                : "SELECT B.* FROM baraja_usuario_favoritiza BF INNER JOIN baraja B ON B.id = BF.idBaraja WHERE BF.usuario = '" + labelUser.Text +"' AND B.elimLogica = 0;";

            DataTable result = bd.consulta(query);

            if (result.Rows.Count == 0){
                return;
            }

            for (int i = 0; i < result.Rows.Count; i++){
                query = "SELECT COUNT(numTarjeta) FROM tarjetas WHERE idBaraja = " + result.Rows[i]["id"] + " AND elimLogica = 0;";
                DataTable cards = bd.consulta(query);
                AddDeckToFlowLayout(result.Rows[i]["titulo"].ToString(), result.Rows[i]["usuario"].ToString(), int.Parse(cards.Rows[0]["COUNT(numTarjeta)"].ToString()), int.Parse(result.Rows[i]["id"].ToString()), bool.Parse(result.Rows[i]["privacidad"].ToString()));
            }
        }

        private void AddDeckToFlowLayout(string title, string author, int numCards, int idBD, bool privacy)
        {
            DeckButton deckButton = new DeckButton(idTheme, ref deckSelected);
            deckButton.Title = title;
            deckButton.Author = author;
            deckButton.Cards = numCards;
            deckButton.Privacy = privacy;
            deckButton.Color = colorButtons;
            deckButton.Id = idBD;
            deckButton.CurrentUser = labelUser.Text;

            flowLayoutPanelDecks.Controls.Add(deckButton);
        }

        private void buttonStudyDeck_Click(object sender, EventArgs e)
        {
            if (labelDeckTitle.Text == "" && labelDeckAuthor.Text == "")
                return;

            OpenSubForm(new StudyDeck(idTheme, colorButtons, colorPanels, colorBackground, deckSelected.Id));
        }

        private void buttonPlayMemorama_Click(object sender, EventArgs e)
        {
            if (labelDeckTitle.Text == "" && labelDeckAuthor.Text == "")
                return;
            OpenSubForm(new Memorama(idTheme, colorButtons, colorPanels, colorBackground, deckSelected.Id));
        }

        private void timerSelection_Tick(object sender, EventArgs e)
        {
            if (deckSelected.Id != 0)
            {
                labelDeckTitle.Text = deckSelected.Title;
                labelDeckAuthor.Text = deckSelected.Author;
            }
            else
            {
                labelDeckTitle.Text = labelDeckAuthor.Text = "";
            }
        }

        private void OpenSubForm(object subform)
        {
            panelContainer.Visible = true;  //hacer visible el panel sobrepuesto para mostrar los submenus...

            if (this.panelContainer.Controls.Count > 0)
            { //liberar control ocupado en caso de tenerlo.
                this.panelContainer.Controls.RemoveAt(0);
            }
            //crear subform
            var sf = subform as Form;
            sf.TopLevel = false;
            sf.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(sf);
            this.panelContainer.Tag = sf;
            sf.FormClosing += OtherDecks_Load;
            sf.Show();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string src = Path.Combine(Path.GetTempPath(), "Tarjetitaspro - UserManual.pdf");
            if (!File.Exists(src))
                File.WriteAllBytes(src, Properties.Resources.Tarjetitaspro___UserManual);
            Process.Start(@"" + src + "");
        }

        private void buttonExportPDF_Click(object sender, EventArgs e)
        {
            if (labelDeckTitle.Text == "" && labelDeckAuthor.Text == "")
                return;
            Exporter pdf = new Exporter(deckSelected.Id, deckSelected.Title, deckSelected.Author);
            pdf.ExportToPDF();
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanelDecks.Controls)
            {
                c.Visible = true;
            }

            for (int i=0; i<flowLayoutPanelDecks.Controls.Count; i++)
            {
                DeckButton temp = (DeckButton)Convert.ChangeType(flowLayoutPanelDecks.Controls[i], typeof(DeckButton));
                if (!temp.Title.Contains(txtSearch.Text))
                {
                    flowLayoutPanelDecks.Controls[i].Visible = false;
                }
            }
        }
    }
}
