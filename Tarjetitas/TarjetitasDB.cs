using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace Tarjetitas
{
    class TarjetitasDB
    {
        private MySqlConnection conexion = new MySqlConnection("SERVER=localhost;DATABASE=tarjetitaspro;UID=root;PASSWORDS=;");
        private MySqlCommand comando;
        public TarjetitasDB()
        {

        }
        public void abrirConexion()
        {
            if (conexion.State != System.Data.ConnectionState.Open)
                conexion.Open(); 
        }
        public void cerrarConexion()
        {
            if(conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }
        public void ejecutarComando(string cadenaComando)
        {
            abrirConexion();
            comando = new MySqlCommand(cadenaComando, conexion);
            cerrarConexion();
        }

    }
}
