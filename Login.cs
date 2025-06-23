// Importa el espacio de nombres que contiene el formulario principal del proyecto
using ProyectoFinal.View;

// Importa el espacio de nombres base de .NET
using System;

namespace ProyectoFinal
{
    // Define una clase parcial llamada Login que hereda de Form (formulario de Windows)
    public partial class Login : Form
    {
        // Crea una instancia del formulario principal (Form1) llamado "Menu"
        Form1 Menu = new Form1(); // Instancia del men� principal

        // Constructor de la clase Login
        public Login()
        {
            // Inicializa los componentes del formulario (dise�o, controles, etc.)
            InitializeComponent();
        }

        // M�todo que se ejecuta al hacer clic en el bot�n de ingreso (Login)
        public void btn_Ingreso_Click(object sender, EventArgs e)
        {
            // Obtiene el texto ingresado por el usuario en el campo de usuario
            string usuario = txt_Usuario.Text;

            // Obtiene el texto ingresado por el usuario en el campo de contrase�a
            string password = txt_Password.Text;

            // Verifica si alguno de los campos est� vac�o
            if (usuario == "" || password == "")
            {
                // Muestra un mensaje de advertencia si hay campos vac�os
                MessageBox.Show("Por favor, complete todos los campos.");
                return; // Sale del m�todo
            }
            // Verifica si el usuario o la contrase�a son incorrectos (valores fijos)
            else if (usuario != "admin" || password != "123")
            {
                // Muestra un mensaje de error si las credenciales son incorrectas
                MessageBox.Show("Usuario o contrase�a incorrectos.");
                return; // Sale del m�todo
            }
            else
            {   // Si el usuario y la contrase�a son correctos:

                // Oculta el formulario de login
                this.Hide();

                // Muestra el formulario principal de la aplicaci�n (en modo de di�logo)
                Menu.ShowDialog();

                // Cierra el formulario de login al salir del formulario principal
                this.Close();
            }

        }
    }
}

