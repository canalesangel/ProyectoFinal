using ProyectoFinal.View;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        EstudianteCEA Estudiante = new EstudianteCEA();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Estudiantes_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            Estudiante.ShowDialog();

            this.Close();

        }
    }
}
