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

namespace Tarjetitas
{
	/// <summary>
	/// Description of UserRegister.
	/// </summary>
	public partial class UserRegister : Form
	{
		private string verificationCode;
		public UserRegister()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			loadCaptchaImage();
			cbTema.SelectedIndex = 0;
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
				errorPassword.Text = "Debe contener al menos 8 caracteres, una mayúscula, caracter especial(#/()=?\\.)" +
					" y dígito";
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
			regla = new Regex("^[\\w#/()=?\\.]{8,32}$");
			if (!regla.IsMatch(txtPassword.Text)) { //Falta validar toda la contraseña
				errorPassword.Text = "Debe contener al menos 8 caracteres, una mayúscula, caracter especial(#/()=?\\.)" +
					" y dígito";
				flag = true;
			}
			else if (txtPassword.Text != txtConfPassword.Text) {
				errorConfPassword.Text = "Las contraseñas no coinciden";
				flag = true;
			}
			if (txtVerification.Text != verificationCode) {
				errorCode.Text = "El código de verificación no coincide";
			}
			return flag;
		}
		bool exitsUserName() {
			//Necesito la base de datos para validar esta parte
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
			
			//Abrir ventana de inicio con mensaje de bienvenida
			
		}
	}
}
