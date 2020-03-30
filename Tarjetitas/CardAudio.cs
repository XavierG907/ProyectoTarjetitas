using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;

namespace Tarjetitas
{
    public partial class CardAudio : Form
    {
        private bool edit;  //bandera para determinar el modo de presentación
        private Content content;    //referencia al reverso de la tarjeta
        private SoundPlayer player;     //reproductor .wav

        //dll importado para reproducir .wav
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int Record(string Comando, string StringRetono, int Longitud, int hwndCallback);


        public CardAudio(bool _edit, ref Content _content)
        {
            InitializeComponent();
            player = new SoundPlayer();     //inicializar reproductor
            edit = _edit;                   //obtener el tipo de presentación  
            content = _content;             //obtener referencia del reverso de la tarjeta

            if (!edit){         
                buttonRecord.Visible = false;       //no permitir edición de audio si es modo visualización
                buttonStopRecord.Visible = false;
                buttonSearchAudio.Visible = false;
            }
            else {
                buttonStopRecord.Visible = false;   //para edición, ocultar buttonStopRecord para funcionamiento correcto
            }
        }

        private void buttonSearchAudio_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Sound |*.wav";

            if(ofd.ShowDialog() == DialogResult.OK) //obtener la ruta del archivo wav
                content.content = ofd.FileName;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            try{
                player.SoundLocation = content.content; //proporcionar la ruta de la grabación (por content)
                player.Play();  //reproducir
            }catch (Exception){
                return;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            player.Stop();  //parar audio
        }

        private void buttonStopRecord_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.FileName = "audio.wav";
            sfd.Filter = "Sound |*.mp3;*.wav";  //filtro, guardar tanto .wav como .mp3.

            Record("pause recsound", "", 0, 0); //pausar grabación

            if (sfd.ShowDialog() == DialogResult.OK)    //si se guardó de forma correcta
            {
                content.content = sfd.FileName;     //obtener la ruta y pasarlo a la referencia content
                buttonRecord.Visible = true;        //actualizar botones
                buttonStopRecord.Visible = false;

                Record("save recsound " + sfd.FileName, "", 0, 0);  //salvar grabación
            }

            Record("close recsound", "", 0, 0);                 //cerrar grabación
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            Record("open new Type waveaudio Alias recsound", "", 0, 0); //abrir grabación y grabar
            Record("record recsound", "", 0, 0);

            player.Stop();                              //callar el audio por si estaba sonando
            buttonRecord.Visible = false;               //actualizar botones
            buttonStopRecord.Visible = true;
        }

        private void CardAudio_Load(object sender, EventArgs e)
        {
            try{
                player.SoundLocation = content.content; //proporcionar la ruta de la grabación (por content)
                player.Play();  //reproducir
            }
            catch (Exception){
                return;
            }
        }

        private void CardAudio_Leave(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}
