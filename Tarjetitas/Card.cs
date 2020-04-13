using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Tarjetitas
{
    public partial class Card : UserControl
    {
        //Librerias para movilizar la interfaz (libreria system.runtime.interopservices)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Card(int idOcurrence, bool _edit, ref SelectedCard _cardSelected, string _front = "", string _reverse = "")
        {
            InitializeComponent();

            this.IdOcurrence =  idOcurrence;                        //obtener el id de ocurrencia de la tarjeta
            labelIdOcurrence.Text = this.IdOcurrence.ToString();    //mostrar el id de ocurrencia
            cardSelected = _cardSelected;                           //referencia de editCards para seleccionar tarjeta

            edit = _edit;                               //asignar el modo de presentación (edit = true / visual = false)
            front = new Content();                      //inicializar frente
            reverse = new Content();                    //inicializar reverso
            front.content = ReplaceDoubleSlashToRoute(_front);
            reverse.content = ReplaceDoubleSlashToRoute(_reverse);
            OpenSubForm(new CardText(edit, ref front)); //asignar al panelContainer el frente de la tarjeta (solo texto)
        }

        private SelectedCard cardSelected;  //referencia para detectar tarjeta seleccionada
        private bool edit;                  //bandera para especificar modo de presentación
        private Content front;     //frente y reverso de las tarjetas
        private Content reverse;

        //propiedades
        private int _idOcurrence;
        private int _cardNum;
        private string _cardType;
        

        public int IdOcurrence      //obtiene el identificador de presencia en la interfaz
        {
            get { return _idOcurrence; }
            set { _idOcurrence = value; }
        }

        public int CardNumber       //obtiene el identificador de bd de la tarjeta a manejar
        {
            get { return _cardNum; }
            set { _cardNum = value; }
        }

        public string CardType      //define el tipo de tarjeta:
        {                           //TEXT, TEXT-IMAGE, TEXT-AUDIO, TEXT-VIDEO
            get { return _cardType; }
            set { _cardType = value; }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            cardSelected.IdOcurrence = this.IdOcurrence;    //asignar a la referencia de selección el id de ocurrencia y el identificador en BD
            cardSelected.CardNumber = this.CardNumber;
        }

        private void buttonReverse_Click(object sender, EventArgs e) //voltear tarjeta
        {
            if (edit){  //mantener en falso siempre y cuando el modo sea solo visualizar, si es editar:
                buttonAddMultContent.Visible = !buttonAddMultContent.Visible; //intercalar su visible según frente o reverso
            }

            if (labelSide.Text == "Frente"){   //si se está en el frente de la tarjeta    

                labelSide.Text = "Reverso";                 //cambiar al reverso
                this.panelContainer.Controls.RemoveAt(0);   //eliminar cualquier control que tenía asignado el panel

                if (this.CardType == "TEXT-IMAGE")                      //abrir text-image
                    OpenSubForm(new CardImage(edit, ref reverse));
                else if (this.CardType == "TEXT-AUDIO")                 //abrir text-audio
                    OpenSubForm(new CardAudio(edit, ref reverse));
                else if (this.CardType == "TEXT-VIDEO")                 //abrir text-video
                    OpenSubForm(new CardVideo(edit, ref reverse));
                else
                {
                    this.CardType = "TEXT";
                    OpenSubForm(new CardText(edit, ref reverse));       //abrir TEXT a secas, ya sea que tuviese el valor text o nunca se haya mostrado el reverso
                }
            }
            else{ //de otra forma, se estaba en el reverso
                labelSide.Text = "Frente";                  //cambiar a frente
                OpenSubForm(new CardText(edit, ref front)); //abrir subform text para frente
            }
        }
        public void voltearCarta()
        {
            if (edit)
            {  //mantener en falso siempre y cuando el modo sea solo visualizar, si es editar:
                buttonAddMultContent.Visible = !buttonAddMultContent.Visible; //intercalar su visible según frente o reverso
            }

            if (labelSide.Text == "Frente")
            {   //si se está en el frente de la tarjeta    

                labelSide.Text = "Reverso";                 //cambiar al reverso
                this.panelContainer.Controls.RemoveAt(0);   //eliminar cualquier control que tenía asignado el panel

                if (this.CardType == "TEXT-IMAGE")                      //abrir text-image
                    OpenSubForm(new CardImage(edit, ref reverse));
                else if (this.CardType == "TEXT-AUDIO")                 //abrir text-audio
                    OpenSubForm(new CardAudio(edit, ref reverse));
                else if (this.CardType == "TEXT-VIDEO")                 //abrir text-video
                    OpenSubForm(new CardVideo(edit, ref reverse));
                else
                {
                    this.CardType = "TEXT";
                    OpenSubForm(new CardText(edit, ref reverse));       //abrir TEXT a secas, ya sea que tuviese el valor text o nunca se haya mostrado el reverso
                }
            }
            else
            { //de otra forma, se estaba en el reverso
                labelSide.Text = "Frente";                  //cambiar a frente
                OpenSubForm(new CardText(edit, ref front)); //abrir subform text para frente
            }
        }
        public void deshabilitarReverso()
        {
            buttonReverse.Enabled = buttonReverse.Visible = false;

        }
        private void buttonAddMultContent_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuStripOptions.Show(this.buttonAddMultContent, new Point(e.X, e.Y)); //show menustrip para asignar tipo de tarjeta
        }

        private void contextMenuStripOptions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Text == "Agregar texto"){              //Tipo TEXT
                this.CardType = "TEXT";
                OpenSubForm(new CardText(edit, ref reverse));
            }
            else if(e.ClickedItem.Text == "Agregar imagen"){        //Tipo TEXT-IMAGE
                this.CardType = "TEXT-IMAGE";
                OpenSubForm(new CardImage(edit, ref reverse));
            }
            else if(e.ClickedItem.Text == "Agregar audio (.wav)"){  //Tipo TEXT-AUDIO
                this.CardType = "TEXT-AUDIO";
                OpenSubForm(new CardAudio(edit, ref reverse));
            }
            else{                                                   //Tipo TEXT-VIDEO
                this.CardType = "TEXT-VIDEO";
                OpenSubForm(new CardVideo(edit, ref reverse));
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
            sf.Show();
        }

        private void Card_Leave(object sender, EventArgs e)
        {
            if (!edit)
                return;

            TarjetitasDB bd = new TarjetitasDB();
            string command = "UPDATE tarjetas SET tipoDeTarjeta = '"+ this.CardType +"', frente = '"+ AddSlashToRoute(front.content) +"', reverso = '"+ AddSlashToRoute(reverse.content) +"' WHERE numTarjeta = "+ this.CardNumber +";"; //update tarjeta por todos los cambios realizados.
            bd.ejecutarComando(command);
        }

        private string AddSlashToRoute(string _str) //utilizado para guardar en BD
        {
            string str = "";

            foreach (var ctr in _str)
            {
                str += ctr;
                if (ctr == '\\')
                    str += ctr;
            }

            return str;
        }

        private string ReplaceDoubleSlashToRoute(string str) //utilizado para extraer de BD
        {
            str.Replace("\\\\", "\\");
            return str;
        }

        public string GetFront()
        {
            return front.content;
        }

        public string GetReverse()
        {
            return reverse.content;
        }
    }

    public class SelectedCard   //objeto utilizado para saber que carta se selecciona
    {
        public int IdOcurrence;     //id de ocurrencia
        public int CardNumber;      //identificador en BD
        public SelectedCard()
        {
            CardNumber = 0;
            IdOcurrence = 0;
        }

        public void Clear()
        {
            CardNumber = 0;
            IdOcurrence = 0;
        }
    }
}
