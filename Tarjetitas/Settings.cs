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
        TarjetitasDB bd = new TarjetitasDB();
        DataTable UserData = new DataTable();
        DataTable themes = new DataTable();
        public Settings(int idTheme, Color _colorButtons, Color _colorPanels, Color _colorBackground, string _User, Form _origenF, Panel _origenP)
        {
            InitializeComponent();

            origenP = _origenP;
            origenF = _origenF;

            tempP = _origenP.Size;
            _origenP.Size = new Size(_origenP.Size.Width, _origenP.Size.Height + 100);

            tempF = _origenF.Size;
            _origenF.Size = new Size(_origenF.Size.Width, _origenF.Size.Height + 100);

            panel1.BackColor = PanelColor = _colorPanels;
            this.BackColor = FondoColor = _colorBackground;
            btnCreateUser.BackColor = BotonColor = _colorButtons;
            if (idTheme == 1)
            { //cambiar color de fuentes en caso de temas claros.
                label17.ForeColor = btnCreateUser.ForeColor = Color.Black;
            }
            User = _User;

            GetUserData();
            ShowUserData();
            LoadThemes();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (IsUpdating())
            {
                DialogResult result = MessageBox.Show("¿Deseas guardar los cambios?", "Configuración de usuario", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SaveChanges();
                }
                else if (result == DialogResult.Cancel)
                    return;
            }
            origenF.Size = tempF;
            origenP.Size = tempP;
            this.Close();
        }
        void GetUserData()
        {
            string query = "SELECT * FROM usuario WHERE usuario = '"+User+"';";
            UserData = bd.consulta(query);
        }
        void ShowUserData()
        {
            txtUserName.Text = UserData.Rows[0][0].ToString();
            txtName.Text = UserData.Rows[0][1].ToString();
            txtLastName.Text = UserData.Rows[0][2].ToString();
            dtpBirthdaay.Value = DateTime.Parse(UserData.Rows[0][3].ToString());
            txtEmail.Text = UserData.Rows[0][4].ToString();
            txtPassword.Text = UserData.Rows[0][5].ToString();
            txtConfPassword.Text = UserData.Rows[0][5].ToString();
        }
        void LoadThemes()
        {
            cbTema.Items.Clear();
            string comando = "SELECT * FROM tema";
            themes = bd.consulta(comando);
            if (themes.Rows.Count == 0)
            {
                //Agregar tema por defecto si no hay ninguno
                string query = "INSERT INTO TEMA VALUES(0,'#FFFFFF','#FAFAFA','#000000');";
                bd.ejecutarComando(query);
                themes = bd.consulta(comando);
            }
            int temp = 0;
            foreach (DataRow r in themes.Rows)
            {
                cbTema.Items.Add(r["id"]);
                if (r["id"].ToString() == UserData.Rows[0]["idTema"].ToString())
                    cbTema.SelectedIndex = temp;
                temp++;
            }
        }

        private void cbTema_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            DataRow row = themes.Rows[e.Index];
            Brush borde = new SolidBrush(e.ForeColor);
            Color color = ColorTranslator.FromHtml(row["rgb_boton"].ToString());
            Brush pincel = new SolidBrush(color);
            Pen boli = new Pen(e.ForeColor);

            e.Graphics.DrawRectangle(boli, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 20, e.Bounds.Height - 4));
            e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 18, e.Bounds.Height - 6));
            e.Graphics.DrawString("Boton", e.Font, borde, e.Bounds.Left + 25, e.Bounds.Top + 2);

            color = ColorTranslator.FromHtml(row["rgb_panel"].ToString());
            pincel = new SolidBrush(color);
            e.Graphics.DrawRectangle(boli, new Rectangle(e.Bounds.Left + 82 + 2, e.Bounds.Top + 2, 20, e.Bounds.Height - 4));
            e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.Left + 85, e.Bounds.Top + 3, 18, e.Bounds.Height - 6));
            e.Graphics.DrawString("Panel", e.Font, borde, e.Bounds.Left + 107, e.Bounds.Top + 2);

            color = ColorTranslator.FromHtml(row["rgb_fondo"].ToString());
            pincel = new SolidBrush(color);
            e.Graphics.DrawRectangle(boli, new Rectangle(e.Bounds.Left + 162 + 2, e.Bounds.Top + 2, 20, e.Bounds.Height - 4));
            e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.Left + 165, e.Bounds.Top + 3, 18, e.Bounds.Height - 6));
            e.Graphics.DrawString("Fondo", e.Font, borde, e.Bounds.Left + 187, e.Bounds.Top + 2);

            e.DrawFocusRectangle();
        }
        //Debo de comprobar que todos los datos proporcionados sean validos
        bool emptyFields()
        {
            ClearErros();
            bool flag = false;
            if (txtName.Text.Length == 0)
            {
                errorName.Text = "Campo vacio";
                flag = true;
            }
            if (txtLastName.Text.Length == 0)
            {
                errorLastName.Text = "Campo vacio";
                flag = true;
            }
            //Validar edad
            if (txtUserName.Text.Length == 0)
            {
                errorUserName.Text = "Campo vacio";
                flag = true;
            }
            if (txtPassword.Text.Length == 0 && txtUserName.Text != "admin")
            {
                errorPassword.Text = "Debe contener entre 8 y 16 caracteres, una mayúscula, una minuscula y dígito";
                flag = true;
            }
            return flag;
        }
        bool dataError()
        {
            ClearErros();
            bool flag = false;
            Regex regla = new Regex("^[A-Za-z]{1,}(\\s[A-Za-z]{1,}){0,}$");
            if (!regla.IsMatch(txtName.Text))
            {
                errorName.Text = "Debe contener letras y un espacio entre cada nombre";
                flag = true;
            }
            if (!regla.IsMatch(txtLastName.Text))
            {
                errorLastName.Text = "Debe contener letras y un espacio entre cada apellido";
                flag = true;
            }
            regla = new Regex("^(?=\\w*\\d)(?=\\w*[A-Z])(?=\\w*[a-z])\\w{8,16}$");
            if (!regla.IsMatch(txtPassword.Text) && txtUserName.Text != "admin")
            { //Falta validar toda la contraseña
                errorPassword.Text = "Debe contener entre 8 y 16 caracteres, una mayúscula, una minuscula y dígito";
                flag = true;
            }
            else if (txtPassword.Text != txtConfPassword.Text)
            {
                errorConfPassword.Text = "Las contraseñas no coinciden";
                flag = true;
            }
            return flag;
        }
        void ClearErros()
        {
            errorName.Text = "";
            errorLastName.Text = "";
            errorUserName.Text = "";
            errorPassword.Text = "";
            errorConfPassword.Text = "";
            errorGeneral.Text = "";
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            origenF.Size = tempF;
            origenP.Size = tempP;
        }

        private bool IsUpdating()
        {
            if (txtUserName.Text == UserData.Rows[0][0].ToString() && txtName.Text == UserData.Rows[0][1].ToString() &&
                txtLastName.Text == UserData.Rows[0][2].ToString() && dtpBirthdaay.Value == DateTime.Parse(UserData.Rows[0][3].ToString()) &&
                txtEmail.Text == UserData.Rows[0][4].ToString() && txtPassword.Text == UserData.Rows[0][5].ToString() &&
                txtConfPassword.Text == UserData.Rows[0][5].ToString() && cbTema.Text == UserData.Rows[0][6].ToString())
                return false;
            return true;
        }
        private bool ConfirmCurrentPassword()
        {
            bool IsCorrect = false;
            string s = "Ingresar contraseña actual: ";
            Form temp = new Form();
            Label l = new Label();
            l.Text = s;
            l.Font = new Font("Arial", 10, FontStyle.Bold);
            l.ForeColor = Color.White;
            l.AutoSize = true;
            l.Location = new Point(10, 10);

            MaskedTextBox txtContinuar = new MaskedTextBox();
            
            txtContinuar.Size = new Size(300, txtContinuar.Height);
            txtContinuar.Location = new Point(l.Location.X+230, l.Location.Y);
            txtContinuar.UseSystemPasswordChar = true;
            txtContinuar.Font = new Font("Arial", 10, FontStyle.Regular);

            Button continuar = new Button();
            continuar.Text = "Continuar";
            continuar.BackColor = Color.Red;
            continuar.Font = new Font("Arial", 12, FontStyle.Bold);
            continuar.ForeColor = Color.White;
            continuar.AutoSize = true;
            continuar.Size = new Size(300, continuar.Height);
            continuar.Location = new Point(l.Location.X + 230, l.Location.Y+l.Size.Height+10);
            continuar.Cursor = Cursors.Hand;
            continuar.FlatStyle = FlatStyle.Popup;
            continuar.Click += (_sender, _EventArgs) => { btnContinuar_Click(_sender, _EventArgs); };

            void btnContinuar_Click(object _sender, EventArgs _e)
            {
                if (txtContinuar.Text == UserData.Rows[0][5].ToString())
                {
                    IsCorrect = true;
                }
                else
                {
                    MessageBox.Show("La contraseña no coincide con la actual! :(");
                    IsCorrect = false;
                }
                temp.Close();
            }

            temp.Controls.Add(continuar);
            temp.Controls.Add(txtContinuar);
            temp.Controls.Add(l);
            temp.Size = new Size(600,130);
            temp.BackColor = ColorTranslator.FromHtml("#253449");
            temp.Text = "CONFIRMAR CONTRASEÑA ACTUAL";
            temp.FormBorderStyle = FormBorderStyle.FixedSingle;
            temp.MaximizeBox = false;
            temp.MinimizeBox = false;
            temp.StartPosition = FormStartPosition.CenterScreen;

            temp.ShowDialog();

            return IsCorrect;
        }
        private void SaveChanges()
        {
            string fechNa = dtpBirthdaay.Value.ToString("yyyy-MM-dd");
            if (emptyFields())
            {
                errorGeneral.Text = "* Los campos marcados con rojo son obligatorios";
                return;
            }
            if (dataError())
            {
                errorGeneral.Text = "Revise los campos marcados con error";
                return;
            }
            if (!IsUpdating())
            {
                MessageBox.Show("No se ha hecho ningun cambio");
                return;
            }
            if (!ConfirmCurrentPassword())
            {
                MessageBox.Show("No se han guardado los cambios");
                return;
            }

            //Añadir usuario
            string comando = "UPDATE usuario SET " +
                "nombre='" + txtName.Text + "'," +
                "apellido='" + txtLastName.Text + "'," +
                "fechaNac='" + fechNa + "'," +
                "correo='" + txtEmail.Text + "'," +
                "contraseña='" + txtPassword.Text + "'," +
                "idTema=" + (cbTema.Text).ToString() +
                " WHERE usuario = '" + txtUserName.Text + "';";
            bd.ejecutarComando(comando);

            //Abrir ventana de inicio con mensaje de bienvenida
            MessageBox.Show("Cambios realizados con exito! :D");
            this.Close();
        }
    }
}
