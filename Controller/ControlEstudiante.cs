using ProyectoFinal.Model;// Importa el modelo Estudiante
using MySql.Data.MySqlClient; // Importa el espacio de nombres
                              // para trabajar con MySQL
using System;
using System.Collections.Generic;
using System.Data; // Necesario para usar DataSet y DataRow

namespace ProyectoFinal.Controller
{
    class ControlEstudiante 
        // Clase que controla las operaciones con el objeto
        // Estudiante en la base de datos
    {

        // Instancia de la clase de conexión a MySQL
        ConexionMySQL con = new ConexionMySQL();

        // MÉTODO: Agrega un nuevo estudiante a la base de datos
        public bool AgregarEstudiante(Estudiante estudiante)
        {
            try
            {
                con.open(); // Abre la conexión a la base de datos

              
                // Crea una cadena SQL para insertar los datos en la tabla estudiantes
                string sql = $@"
                INSERT INTO estudiantes (Matricula, Nombre, Apellidop, Apellidom, Correo, Telefono, 
                                         FechaNacimiento, Carrera, Semestre, Estado)
                VALUES ({estudiante.Matricula}, '{estudiante.Nombre}', '{estudiante.Apellidop}', 
                        '{estudiante.Apellidom}', '{estudiante.Correo}', '{estudiante.Telefono}', 
                        '{estudiante.FechaNacimiento}', '{estudiante.Carrera}', '{estudiante.Semestre}', 
                        '{estudiante.Estado}')";

                return con.executeInstruction(sql); // Ejecuta la instrucción SQL y devuelve si fue exitosa
            }
            finally
            {
                con.close(); // Cierra la conexión a la base de datos
            }
        }

        // MÉTODO: Modifica un estudiante ya existente en la base de datos
        public bool ModificarEstudiante(Estudiante estudiante)
        {
            try
            {
                con.open(); // Abre la conexión a la base de datos
              

                // Crea una cadena SQL de actualización (UPDATE) para modificar los datos
                string sql = $@"
                UPDATE estudiantes 
                SET Nombre = '{estudiante.Nombre}', Apellidop = '{estudiante.Apellidop}', 
                    Apellidom = '{estudiante.Apellidom}', Correo = '{estudiante.Correo}', 
                    Telefono = '{estudiante.Telefono}', FechaNacimiento = '{estudiante.FechaNacimiento}', 
                    Carrera = '{estudiante.Carrera}', Semestre = '{estudiante.Semestre}', 
                    Estado = '{estudiante.Estado}'
                WHERE Matricula = {estudiante.Matricula}";

                return con.executeInstruction(sql); // Ejecuta la instrucción y devuelve si fue exitosa
            }
            finally
            {
                con.close(); // Cierra la conexión
            }
        }

        // MÉTODO: Elimina un estudiante por su matrícula
        public bool EliminarEstudiante(int matricula)
        {
            try
            {
                con.open(); // Abre la conexión

                // Crea una cadena SQL para eliminar el registro
                string sql = $"DELETE FROM estudiantes " +
                    $"WHERE Matricula = {matricula}";
                // Ejecuta la eliminación y devuelve si fue exitosa
                return con.executeInstruction(sql); 
            }
            finally
            {
                con.close(); // Cierra la conexión
            }
        }

        // MÉTODO: Obtiene un estudiante por su matrícula
        public Estudiante ObtenerEstudiante(int matricula)
        {
            try
            {
                con.open(); // Abre la conexión

                // Crea la instrucción SQL para seleccionar un estudiante
                string sql = $"SELECT * FROM estudiantes " +
                    $"WHERE Matricula = {matricula}";

                // Ejecuta la consulta y guarda el resultado en un DataSet
                DataSet d = con.executeQuery(sql);

                // Si se encontró al menos un resultado
                if (d.Tables[0].Rows.Count > 0)
                {
                    // Toma la primera fila y la convierte a objeto Estudiante
                    DataRow row = d.Tables[0].Rows[0];
                    return MapearEstudiante(row); // Retorna el estudiante
                }

                return null; // Si no se encontró, retorna null
            }
            finally
            {
                con.close(); // Cierra la conexión
            }
        }

        // MÉTODO: Lista todos los estudiantes de la base de datos
        public List<Estudiante> ListarEstudiantes()
        // Lista donde se almacenarán los estudiantes
        {
            List<Estudiante> estudiantes = new List<Estudiante>(); 

            try
            {
                con.open(); // Abre la conexión

                // Ejecuta una consulta para obtener todos los registros
                DataSet d = con.executeQuery("SELECT * FROM estudiantes");

                // Recorre todas las filas del DataSet
                foreach (DataRow row in d.Tables[0].Rows)
                {
                    // Convierte cada fila en un objeto y lo agrega a la lista
                    estudiantes.Add(MapearEstudiante(row)); 
                }

                return estudiantes; // Retorna la lista de estudiantes
            }
            finally
            {
                con.close(); // Cierra la conexión
            }
        }

        // MÉTODO PRIVADO: Convierte una fila (DataRow) a un objeto Estudiante
        private Estudiante MapearEstudiante(DataRow row)
        {
            // Crea y retorna un nuevo objeto Estudiante asignando
            // cada valor desde la fila
            return new Estudiante
            {
                Matricula = Convert.ToInt32(row["Matricula"]),
                Nombre = row["Nombre"].ToString(),
                Apellidop = row["Apellidop"].ToString(),
                Apellidom = row["Apellidom"].ToString(),
                Correo = row["Correo"].ToString(),
                Telefono = row["Telefono"].ToString(),
                FechaNacimiento = row["FechaNacimiento"].ToString(),
                Carrera = row["Carrera"].ToString(),
                Semestre = row["Semestre"].ToString(),
                Estado = row["Estado"].ToString(),
            };
        }
    }// fin de clase 
} //fin de namespace ProyectoFinal.Controller

