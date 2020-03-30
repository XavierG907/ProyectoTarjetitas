using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Tarjetitas
{
    public partial class CardText : Form
    {
        Content content; //objeto que obtiene la referencia de _content, para poder actualizar dicho contenido
        public CardText(bool edit, ref Content _content)
        {
            InitializeComponent();

            content = _content; //igualamos content
            
            if (!Regex.IsMatch(content.content, "^*\\.(mp3|mp4|wav|png|jpg|jpeg)$")) 
                richTextBoxText.Text = content.content; //asignar al richtextbox el contenido de content
            else
                richTextBoxText.Text = "Inserte un texto aquí";//si se tenía una ruta de un archivo, pues reestablecer texto

            richTextBoxText.SelectionAlignment = HorizontalAlignment.Center; //texto horizontal

            if (!edit){
                richTextBoxText.ReadOnly = true; //si no es modo edición, no permitir cambios
            }
        }

        private void richTextBoxText_TextChanged(object sender, EventArgs e)
        {
            content.content = richTextBoxText.Text; //actualizar el contenido a content por cada texto cambiado
        }
    }

    public class Content
    {
        public string content; //el contenido de la tarjeta (ya sea frente o reverso)
        public Content() { content = "Inserte un texto aquí"; } //inicialmente tiene este texto para las textCards
    }
}
