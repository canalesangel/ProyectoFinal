using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Controller; // Importa el controlador de estudiantes

namespace ProyectoFinal.View
{
    public partial class EstudianteCEA : Form
    {
        // Constructor de la clase EstudianteCEA
        // Inicializa los componentes del formulario

        ControlEstudiante controlEstudiante = new ControlEstudiante();
        // Instancia del controlador de estudiante
        EstudianteRA estudianteRA = new EstudianteRA();
        public EstudianteCEA()
        {
            InitializeComponent();
            dataGridView1.DataSource = controlEstudiante.ListarEstudiantes(); // Actualiza la tabla con los datos de los estudiantes
        }

        private void btn_ActualizarEstudiante_Click(object sender, EventArgs e)
        {
            estudianteRA.actualizarEstudiante(Convert.ToInt32(txt_Actualizar.Text));
            this.Hide(); // Oculta el formulario actual
            estudianteRA.ShowDialog(); // Muestra el formulario de registro de estudiante
            this.Close(); // Cierra el formulario actual después de que se cierre el formulario de registro
        }

        private void btn_EliminarEstudiante_Click(object sender, EventArgs e)
        {
            if(controlEstudiante.EliminarEstudiante(Convert.ToInt32(txt_Eliminar.Text)))
            {
                MessageBox.Show("Estudiante eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al eliminar el estudiante.");
            }
        }

        private void btn_ActualizarTablaEstudiantes_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controlEstudiante.ListarEstudiantes(); // Actualiza la tabla con los datos de los estudiantes
        }

        private void btn_RegistrarEstudiante_Click(object sender, EventArgs e)
        {
            
            this.Hide(); // Oculta el formulario actual
            estudianteRA.ShowDialog(); // Muestra el formulario de registro de estudiante
            this.Close(); // Cierra el formulario actual 
        }


        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1(); // Crea una instancia del formulario principal
            this.Hide(); // Oculta el formulario actual
            menu.ShowDialog(); // Muestra el formulario principal en modo de diálogo
            this.Close(); // Cierra el formulario actual después de que se cierre el menú
        }
    }
}
