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
    public partial class CardVideo : Form
    {
        bool edit; //bandera que indica si la forma se utilizará para editar o para visualizar
        Content content; //tiene la referencia del content de la tarjeta, solo reverso
        public CardVideo(bool _edit, ref Content _content)
        {
            InitializeComponent();
            edit = _edit;           //obtener el modo de presentación
            content = _content;     //obtener la referencia del reverso
        }

        private void axWindowsMediaPlayer1_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            if (!edit)
                return; //siempre y cuando no esté en modo representación

            contextMenuStripOpenVideo.Show(this.axWindowsMediaPlayer1, new Point(e.fX, e.fY)); //abrir contextmenustrip
        }

        private void contextMenuStripOpenVideo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Content|*.mp3;*.mp4;";

            contextMenuStripOpenVideo.Hide(); //ocultar el contextmenustrip para que no estorbe

            if (ofd.ShowDialog() != DialogResult.OK) //obtener el video seleccionado
                return;

            content.content = ofd.FileName;     //content contiene la ruta del video/audio seleccionado
            try{
                axWindowsMediaPlayer1.URL = content.content; //intentar reproducirlo
            }catch (Exception){
                return;
            }
        }

        private void CardVideo_Load(object sender, EventArgs e)
        {
            if(Regex.IsMatch(content.content, "^*\\.(mp4|mp3)$")) //siempre y cuando sea video, o mp3....
            {
                try{
                    axWindowsMediaPlayer1.URL = content.content; //cargar el url a la ruta de content. se reproducirá automáticamente
                }catch (Exception){
                    return;
                }
            }
            
        }

        private void axWindowsMediaPlayer1_Leave(object sender, EventArgs e)
        {
            try{
                axWindowsMediaPlayer1.Ctlcontrols.stop(); //detener el audio-video cuando se deje de interactuar en la form
            }catch (Exception){
                return;
            }
        }
    }
}
