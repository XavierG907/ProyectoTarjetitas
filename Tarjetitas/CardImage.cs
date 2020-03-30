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
    public partial class CardImage : Form
    {
        Content content;    //referencia al contenido reverso de la tarjeta
        bool edit;          //guarda el modo de presentación
        public CardImage(bool _edit, ref Content _content)
        {
            InitializeComponent();
            content = _content;     //obtener la referencia del contenido reverso
            edit = _edit;           //obtener el modo de presentación
        }

        private void pictureBoxImage_MouseClick(object sender, MouseEventArgs e)
        {
            if (!edit)  //si está en modo visualización, pues no puede realizar esta opción
                return;

            contextMenuStripOpenImage.Show(this.pictureBoxImage, new Point(e.X, e.Y)); //permitirle seleccionar imagen
        }

        private void contextMenuStripOpenImage_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Picture |*.jpg;*.jpeg;*.png;"; 

            this.contextMenuStripOpenImage.Hide(); //ocultar el contexmenustrip para que no estorbe

            if (ofd.ShowDialog() != DialogResult.OK) //obligar a que el usuario eliga una imagen con los filtros deseados
                return;

            content.content = ofd.FileName;                                  //actualizar la ruta al content
            pictureBoxImage.BackgroundImageLayout = ImageLayout.Stretch;     //propiedad del picturebox 
            pictureBoxImage.BackgroundImage = new Bitmap(content.content);   //agregar la imagen al picturebox
        }

        private void CardImage_Load(object sender, EventArgs e)
        {
            try{
                pictureBoxImage.BackgroundImageLayout = ImageLayout.Stretch;    //tratar de actualizar posible imagen existente siempre y cuando se pueda
                pictureBoxImage.BackgroundImage = new Bitmap(content.content);
            }catch (Exception){
                return;
            }
        }
    }
}
