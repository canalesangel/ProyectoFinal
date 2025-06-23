using ProyectoFinal.Controller;
using ProyectoFinal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.View
{
    public partial class EstudianteRA : Form
    {
        Estudiante estudiante = new Estudiante();
        ControlEstudiante controlEstudiante = new ControlEstudiante();
        public EstudianteRA()
        {
            InitializeComponent();

        }
        public bool actualizarEstudiante ( int matricula) {            
            
           
            estudiante = controlEstudiante.ObtenerEstudiante(matricula);
            if (estudiante != null)
            {
                txt_Matricula.Text = estudiante.Matricula.ToString();
                txt_Nombre.Text = estudiante.Nombre;
                txt_ApellidoP.Text = estudiante.Apellidop;
                txt_ApellidoM.Text = estudiante.Apellidom;
                txt_Correo.Text = estudiante.Correo;
                txt_Telefono.Text = estudiante.Telefono;
                dtp_FechaNacimiento.Value = DateTime.Parse(estudiante.FechaNacimiento);
                txt_Carrera.Text = estudiante.Carrera;
                txt_Semestre.Text = estudiante.Semestre;
                txt_Estado.Text = estudiante.Estado;
                return true;
            }
            else
            {
                MessageBox.Show("Estudiante no encontrado.");
                return false;
            }
            
        }
        private void btn_RegistrarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                // Asignar los valores de los campos de texto a las propiedades del objeto Estudiante
                estudiante.Matricula = int.Parse(txt_Matricula.Text);
                estudiante.Nombre = txt_Nombre.Text;
                estudiante.Apellidop = txt_ApellidoP.Text;
                estudiante.Apellidom = txt_ApellidoM.Text;
                estudiante.Correo = txt_Correo.Text;
                estudiante.Telefono = txt_Telefono.Text;
                estudiante.FechaNacimiento = dtp_FechaNacimiento.Value.ToString("yyyy-MM-dd");
                estudiante.Carrera = txt_Carrera.Text;
                estudiante.Semestre = txt_Semestre.Text;
                estudiante.Estado = txt_Estado.Text;
               
                // Llamar al método para agregar el estudiante
                controlEstudiante.AgregarEstudiante(estudiante);
                MessageBox.Show("Estudiante registrado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el estudiante: " + ex.Message);
            }
        }//fin de btn_RegistrarEstudiante_Click

        private void btn_ActualizarEstudiante_Click(object sender, EventArgs e)
        {
            // Validar que la matrícula sea un número válido.
            if (!int.TryParse(txt_Matricula.Text, out int matricula))
            {
                MessageBox.Show("La matrícula debe ser un número válido.");
                return;
            }

            // Crear un objeto Estudiante y asignar sus propiedades desde los controles del formulario.
            Estudiante estudiante = new Estudiante
            {
                Matricula = matricula,
                Nombre = txt_Nombre.Text,
                Apellidop = txt_ApellidoP.Text,
                Apellidom = txt_ApellidoM.Text,
                Correo = txt_Correo.Text,
                Telefono = txt_Telefono.Text,
                // Convertir la fecha del control DateTimePicker a cadena en formato adecuado para la base de datos.
                FechaNacimiento = dtp_FechaNacimiento.Value.ToString("yyyy-MM-dd"),
                Carrera = txt_Carrera.Text,
                Semestre = txt_Semestre.Text,
                Estado = txt_Estado.Text
            };

            // Llamar al método ModificarEstudiante y mostrar el resultado de la operación.
            bool modificado = controlEstudiante.ModificarEstudiante(estudiante);

            if (modificado)
            {
                MessageBox.Show("Se actualizó el estudiante correctamente.");
            }
            else
            {
                MessageBox.Show("Ocurrió un error al actualizar el estudiante.");
            }

        }//fin de btn_ActualizarEstudiante_Click

        private void btn_ConsultarEstudiantes_Click(object sender, EventArgs e)
        {
            EstudianteCEA estudianteCEA = new EstudianteCEA();
            this.Hide(); // Oculta el formulario actual
            estudianteCEA.ShowDialog(); // Muestra el formulario de consulta de estudiante
            this.Close(); // Cierra el formulario actual
        }
    }//fin de clase form EstudianteRA
} //namespace ProyectoFinal.View
