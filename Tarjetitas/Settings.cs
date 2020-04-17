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
    public partial class Settings : Form
    {
        Color BotonColor;
        Color PanelColor;
        Color FondoColor;
        string User;
        Size tempP;
        Size tempF;
        Panel origenP;
        Form origenF;
        public Settings(Color _colorButtons, Color _colorPanels, Color _colorBackground, string _User, Form _origenF, Panel _origenP)
        {
            InitializeComponent();

            origenP = _origenP;
            origenF = _origenF;

            tempP = _origenP.Size;
            _origenP.Size = new Size(_origenP.Size.Width, _origenP.Size.Height + 100);

            tempF = _origenF.Size;
            _origenF.Size = new Size(_origenF.Size.Width, _origenF.Size.Height + 100);

            PanelColor = _colorPanels;
            this.BackColor = FondoColor = _colorBackground;
            BotonColor = _colorButtons;
            User = _User;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            origenF.Size = tempF;
            origenP.Size = tempP;
            this.Close();
        }
    }
}
