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
        Form1 Menu = new Form1(); // Instancia del menú principal

        // Constructor de la clase Login
        public Login()
        {
            // Inicializa los componentes del formulario (diseño, controles, etc.)
            InitializeComponent();
        }

        // Método que se ejecuta al hacer clic en el botón de ingreso (Login)
        public void btn_Ingreso_Click(object sender, EventArgs e)
        {
            // Obtiene el texto ingresado por el usuario en el campo de usuario
            string usuario = txt_Usuario.Text;

            // Obtiene el texto ingresado por el usuario en el campo de contraseña
            string password = txt_Password.Text;

            // Verifica si alguno de los campos está vacío
            if (usuario == "" || password == "")
            {
                // Muestra un mensaje de advertencia si hay campos vacíos
                MessageBox.Show("Por favor, complete todos los campos.");
                return; // Sale del método
            }
            // Verifica si el usuario o la contraseña son incorrectos (valores fijos)
            else if (usuario != "admin" || password != "123")
            {
                // Muestra un mensaje de error si las credenciales son incorrectas
                MessageBox.Show("Usuario o contraseña incorrectos.");
                return; // Sale del método
            }
            else
            {   // Si el usuario y la contraseña son correctos:

                // Oculta el formulario de login
                this.Hide();

                // Muestra el formulario principal de la aplicación (en modo de diálogo)
                Menu.ShowDialog();

                // Cierra el formulario de login al salir del formulario principal
                this.Close();
            }

        }
    }
}

