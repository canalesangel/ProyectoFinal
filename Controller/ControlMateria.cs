using ProyectoFinal.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Controller
{
    // Clase que controla las operaciones de base de datos para la tabla 'materias'
    public class ControlMateria
    {
        // Se crea una instancia de la clase ConexionMySQL para manejar la conexión a la base de datos
        private ConexionMySQL con = new ConexionMySQL();

        // Método para agregar una nueva materia a la base de datos
        public bool AgregarMateria(Materia m)
        {
            con.open(); // Abre la conexión con la base de datos

            // Se crea la instrucción SQL para insertar una nueva materia con los valores del objeto 'm'
            string sql = $"INSERT INTO materias (NombreMateria, Creditos, Carrera, Semestre) " +
                         $"VALUES ('{m.NombreMateria}', {m.Creditos}, '{m.Carrera}', '{m.Semestre}')";

            // Ejecuta la instrucción SQL y guarda si fue exitosa (true o false)
            bool resultado = con.executeInstruction(sql);

            con.close(); // Cierra la conexión con la base de datos
            return resultado; // Devuelve el resultado de la operación
        }

        // Método para buscar una materia por su ID
        public Materia BuscarMateria(int id)
        {
            con.open(); // Abre la conexión a la base de datos

            // Instrucción SQL para seleccionar la materia con el ID especificado
            string sql = $"SELECT * FROM materias WHERE IdMateria = {id}";

            // Ejecuta la consulta y almacena los resultados en un DataSet
            DataSet ds = con.executeQuery(sql);

            con.close(); // Cierra la conexión

            // Si se encontró al menos una fila (materia), se crea un objeto Materia y se llenan sus datos
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0]; // Se toma la primera fila del resultado
                return new Materia
                {
                    IdMateria = Convert.ToInt32(row["IdMateria"]), // Se obtiene y convierte el ID
                    NombreMateria = row["NombreMateria"].ToString(), // Se obtiene el nombre
                    Creditos = Convert.ToInt32(row["Creditos"]), // Se obtienen los créditos
                    Carrera = row["Carrera"].ToString(), // Se obtiene la carrera
                    Semestre = row["Semestre"].ToString() // Se obtiene el semestre
                };
            }

            return null; // Si no se encontró ninguna materia, se devuelve null
        }

        // Método para actualizar los datos de una materia existente
        public bool ActualizarMateria(Materia m)
        {
            con.open(); // Abre la conexión

            // Instrucción SQL para actualizar la materia con los nuevos datos
            string sql = $"UPDATE materias SET NombreMateria='{m.NombreMateria}', Creditos={m.Creditos}, " +
                         $"Carrera='{m.Carrera}', Semestre='{m.Semestre}' WHERE IdMateria={m.IdMateria}";

            // Ejecuta la instrucción y guarda si fue exitosa
            bool resultado = con.executeInstruction(sql);

            con.close(); // Cierra la conexión
            return resultado; // Devuelve el resultado
        }

        // Método para eliminar una materia usando su ID
        public bool EliminarMateria(int id)
        {
            con.open(); // Abre la conexión

            // Instrucción SQL para eliminar la materia con el ID indicado
            string sql = $"DELETE FROM materias WHERE IdMateria = {id}";

            // Ejecuta la instrucción y guarda si fue exitosa
            bool resultado = con.executeInstruction(sql);

            con.close(); // Cierra la conexión
            return resultado; // Devuelve el resultado
        }

        // Método para obtener una lista con todas las materias de la base de datos
        public List<Materia> ListarMaterias()
        {
            List<Materia> lista = new List<Materia>(); // Lista para guardar las materias

            con.open(); // Abre la conexión

            string sql = "SELECT * FROM materias"; // Consulta SQL para obtener todas las materias

            DataSet ds = con.executeQuery(sql); // Ejecuta la consulta y guarda los resultados

            con.close(); // Cierra la conexión

            // Recorre cada fila del DataSet y crea objetos Materia para agregarlos a la lista
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lista.Add(new Materia
                {
                    IdMateria = Convert.ToInt32(row["IdMateria"]), // Convierte y asigna el ID
                    NombreMateria = row["NombreMateria"].ToString(), // Asigna el nombre
                    Creditos = Convert.ToInt32(row["Creditos"]), // Asigna los créditos
                    Carrera = row["Carrera"].ToString(), // Asigna la carrera
                    Semestre = row["Semestre"].ToString() // Asigna el semestre
                });
            }

            return lista; // Devuelve la lista completa de materias
        }
    }
}
