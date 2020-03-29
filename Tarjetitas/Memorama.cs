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
    public partial class Memorama : Form
    {
        string usuario;
        Color boton;
        Color panel;
        Color fondo;
        DataTable tarjetas;
        TarjetitasDB db = new TarjetitasDB();
        public Memorama(string id_baraja, string _usuario)
        {
            InitializeComponent();
            usuario = _usuario;
            string query = "SELECT T.rgb_boton,T.rgb_panel,T.rgb_fondo FROM usuario U INNER JOIN tema T ON U.idTema = T.id " +
                "WHERE U.usuario = '"+usuario+"';";
            DataTable tema = db.consulta(query);
            fondo = ColorTranslator.FromHtml(tema.Rows[0]["rgb_fondo"].ToString());
            this.BackColor = fondo;
            panel1.BackColor = ColorTranslator.FromHtml(tema.Rows[0]["rgb_panel"].ToString());

            query = "SELECT * FROM tarjetas WHERE id_baraja="+id_baraja+";";
            tarjetas = db.consulta(query);
        }
    }
}
