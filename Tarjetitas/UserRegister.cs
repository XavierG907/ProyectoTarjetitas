/*
 * Created by SharpDevelop.
 * User: g2
 * Date: 14/03/2020
 * Time: 09:40 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;

namespace Tarjetitas
{
	/// <summary>
	/// Description of UserRegister.
	/// </summary>
	public partial class UserRegister : Form
	{
		private string verificationCode;
		private TarjetitasDB bd = new TarjetitasDB();
		DataTable themes;
		public UserRegister()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			loadCaptchaImage();
			LoadThemes();
		}
		private void loadCaptchaImage() {
			Color[] colores = {Color.AliceBlue,Color.Beige,Color.Violet,Color.Green,Color.Pink,Color.Brown,
								Color.Gold,Color.Yellow,Color.Gray,Color.Magenta};
			Random r1 = new Random();  
			int number = r1.Next(10000, 99999);
			verificationCode = number.ToString();
			var image = new Bitmap(this.pbCaptcha.Width, this.pbCaptcha.Height);  
			var font = new Font("TimesNewRoman", 70, FontStyle.Bold, GraphicsUnit.Pixel);  
			var graphics = Graphics.FromImage(image);  
			graphics.DrawString(number.ToString(), font, Brushes.Green, new Point(0, 0));
			Pen lapiz = new Pen(Color.Red, 1);
			graphics.DrawLine(lapiz,0,0,500,50);
			//Aqui añado lineas random para que se vea más decente xd
			int x1, y1, x2, y2, mx=pbCaptcha.Width, my=pbCaptcha.Height, index;
			lapiz.Color = Color.Black;
			for (int i=5; i < mx; i+=8){
				graphics.DrawLine(lapiz,i,0,i,my);
			} 
			for (int i=5; i < my; i+=8){
				graphics.DrawLine(lapiz,0,i,mx,i);
			}
			lapiz.Width = 2;
			for (int i=0; i < 15; i++) {
				x1 = r1.Next(0,mx); x2 = r1.Next(0,mx);
				y1 = r1.Next(0,my); y2 = r1.Next(0,my);
				index = r1.Next(0,9);
				lapiz.Color = colores[index];
				graphics.DrawLine(lapiz,x1,y1,x2,y2);
			}
			pbCaptcha.Image = image;
		}
		void BtnChangeCodeClick(object sender, EventArgs e) {
			loadCaptchaImage();
		}
		
		//Debo de comprobar que todos los datos proporcionados sean validos
		bool emptyFields() {
			ClearErros();
			bool flag = false;
			if (txtName.Text.Length == 0) {
				errorName.Text = "Campo vacio";
				flag = true;}
			if (txtLastName.Text.Length == 0) {
				errorLastName.Text = "Campo vacio";
				flag = true;}
			//Validar edad
			if (txtUserName.Text.Length == 0) {
				errorUserName.Text = "Campo vacio";
				flag = true;}
			if (txtPassword.Text.Length == 0) {
				errorPassword.Text = "Debe contener entre 8 y 16 caracteres, una mayúscula, una minuscula y dígito";
				flag = true;}
			if (txtVerification.Text.Length == 0) {
				errorCode.Text = "Campo vacio";
				flag = true;}
			return flag;
		}
		bool dataError() {
			ClearErros();
			bool flag = false;
			Regex regla = new Regex("^[A-Za-z]{1,}(\\s[A-Za-z]{1,}){0,}$");
			if (!regla.IsMatch(txtName.Text)) {
				errorName.Text = "Debe contener letras y un espacio entre cada nombre";
				flag = true;
			}
			if (!regla.IsMatch(txtLastName.Text)) {
				errorLastName.Text = "Debe contener letras y un espacio entre cada apellido";
				flag = true;
			}
			regla = new Regex("^(?=\\w*\\d)(?=\\w*[A-Z])(?=\\w*[a-z])\\w{8,16}$");
			if (!regla.IsMatch(txtPassword.Text)) { //Falta validar toda la contraseña
				errorPassword.Text = "Debe contener entre 8 y 16 caracteres, una mayúscula, una minuscula y dígito";
				flag = true;
			}
			else if (txtPassword.Text != txtConfPassword.Text) {
				errorConfPassword.Text = "Las contraseñas no coinciden";
				flag = true;
			}
			if (txtVerification.Text != verificationCode) {
				errorCode.Text = "El código de verificación no coincide";
				flag = true;
			}
			return flag;
		}
		bool exitsUserName() {
			//Necesito la base de datos para validar esta parte
			string comando = "SELECT COUNT(*) FROM usuario WHERE usuario='"+txtUserName.Text+"';";
			if (int.Parse(bd.consulta(comando).Rows[0][0].ToString()) != 0)
			{
				errorUserName.Text = "Usuario ya registrado. Introduzca otro.";
				return true;
			}
			return false;
		}
		void ClearErros() {
			errorName.Text 			= "";
			errorLastName.Text 		= "";
			errorUserName.Text 		= "";
			errorPassword.Text 		= "";
			errorConfPassword.Text 	= "";
			errorCode.Text 			= "";
			errorGeneral.Text 		= "";
		}
		void BtnCreateUserClick(object sender, EventArgs e) {
			string fechNa = dtpBirthdaay.Value.ToString("yyyy-MM-dd");
			if (emptyFields()) {
				errorGeneral.Text = "* Los campos marcados con rojo son obligatorios";
				return;
			}
			if (dataError()) {
				errorGeneral.Text = "Revise los campos marcados con error";
				return;
			}
			if (exitsUserName()) {
				errorGeneral.Text = "Error con el nombre de usuario";
				return;
			}
			//Añadir usuario
			string comando = "INSERT INTO usuario VALUES('"+txtUserName.Text+"','"+txtName.Text+"','"+
				txtLastName.Text+"','"+fechNa+"','"+txtEmail.Text+"','"+txtPassword.Text+"',"+
				(cbTema.Text).ToString()+");";
			bd.ejecutarComando(comando);

			//Abrir ventana de inicio con mensaje de bienvenida
			MessageBox.Show("Registro de usuario concluido.\nBienvenido a la aplicción :D");
			MenuPrincipal mp = new MenuPrincipal(txtUserName.Text); //inicializar main menu
			this.Hide();
			mp.ShowDialog(); //mostrarlo
			this.Close();
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
			foreach (DataRow r in themes.Rows)
			{
				cbTema.Items.Add(r["id"]);
			}
			cbTema.SelectedIndex = 0;
		}

		private void cbTema_DrawItem(object sender, DrawItemEventArgs e)
		{
			e.DrawBackground();
			DataRow row = themes.Rows[e.Index];
			Brush borde = new SolidBrush(e.ForeColor);
			Color color = ColorTranslator.FromHtml(row["rgb_boton"].ToString());
			Brush pincel = new SolidBrush(color);
			Pen boli = new Pen(e.ForeColor);

			e.Graphics.DrawRectangle(boli, new Rectangle(e.Bounds.Left+2, e.Bounds.Top+2, 20, e.Bounds.Height-4));
			e.Graphics.FillRectangle(pincel,new Rectangle(e.Bounds.Left+3, e.Bounds.Top+3, 18, e.Bounds.Height-6));
			e.Graphics.DrawString("Boton",e.Font,borde,e.Bounds.Left+25, e.Bounds.Top+2);

			color = ColorTranslator.FromHtml(row["rgb_panel"].ToString());
			pincel = new SolidBrush(color);
			e.Graphics.DrawRectangle(boli, new Rectangle(e.Bounds.Left+82 + 2, e.Bounds.Top + 2, 20, e.Bounds.Height - 4));
			e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.Left+85, e.Bounds.Top + 3, 18, e.Bounds.Height - 6));
			e.Graphics.DrawString("Panel", e.Font, borde, e.Bounds.Left+107, e.Bounds.Top + 2);

			color = ColorTranslator.FromHtml(row["rgb_fondo"].ToString());
			pincel = new SolidBrush(color);
			e.Graphics.DrawRectangle(boli, new Rectangle(e.Bounds.Left + 162 + 2, e.Bounds.Top + 2, 20, e.Bounds.Height - 4));
			e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.Left + 165, e.Bounds.Top + 3, 18, e.Bounds.Height - 6));
			e.Graphics.DrawString("Fondo", e.Font, borde, e.Bounds.Left + 187, e.Bounds.Top + 2);

			e.DrawFocusRectangle();
		}
	}
}
