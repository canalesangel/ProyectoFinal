using ProyectoFinal.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Controller
{
    // Define la clase ControlAsistencia para
    // manejar las operaciones CRUD de la tabla 'asistencias'
    public class ControlAsistencia
    {
        // Crea una instancia de la clase de conexión a MySQL
        private ConexionMySQL con = new ConexionMySQL();

        // Método para agregar una nueva asistencia
        public bool AgregarAsistencia(Asistencia a)
        {
            // Abre la conexión a la base de datos
            con.open();

            // Prepara la instrucción SQL para insertar una nueva
            // asistencia con los valores del objeto 'a'
            string sql = $"INSERT INTO asistencias (Matricula, IdMateria, Fecha, HoraEntrada, HoraSalida, EstadoAsistencia, Observaciones) " +
                         $"VALUES ({a.Matricula}, {a.IdMateria}, '{a.Fecha:yyyy-MM-dd}', '{a.HoraEntrada}', '{a.HoraSalida}', '{a.EstadoAsistencia}', '{a.Observaciones}')";

            // Ejecuta la instrucción SQL y almacena el resultado (true si tuvo éxito)
            bool resultado = con.executeInstruction(sql);

            // Cierra la conexión a la base de datos
            con.close();

            // Retorna si la operación fue exitosa o no
            return resultado;
        }

        // Método para buscar una asistencia por su ID
        public Asistencia BuscarAsistencia(int id)
        {
            // Abre la conexión a la base de datos
            con.open();

            // Prepara la instrucción SQL para buscar la asistencia con el ID proporcionado
            string sql = $"SELECT * FROM asistencias WHERE IdAsistencia = {id}";

            // Ejecuta la consulta y obtiene los resultados en un DataSet
            DataSet ds = con.executeQuery(sql);

            // Cierra la conexión a la base de datos
            con.close();

            // Verifica si se encontró al menos un registro
            if (ds.Tables[0].Rows.Count > 0)
            {
                // Toma la primera fila del resultado
                DataRow row = ds.Tables[0].Rows[0];

                // Crea y retorna un objeto Asistencia con los datos obtenidos
                return new Asistencia
                {
                    IdAsistencia = Convert.ToInt32(row["IdAsistencia"]),
                    Matricula = Convert.ToInt32(row["Matricula"]),
                    IdMateria = Convert.ToInt32(row["IdMateria"]),
                    Fecha = Convert.ToDateTime(row["Fecha"]),
                    HoraEntrada = TimeSpan.Parse(row["HoraEntrada"].ToString()),
                    HoraSalida = TimeSpan.Parse(row["HoraSalida"].ToString()),
                    EstadoAsistencia = row["EstadoAsistencia"].ToString(),
                    Observaciones = row["Observaciones"].ToString()
                };
            }

            // Si no se encontró el registro, retorna null
            return null;
        }

        // Método para actualizar una asistencia existente
        public bool ActualizarAsistencia(Asistencia a)
        {
            // Abre la conexión a la base de datos
            con.open();

            // Prepara la instrucción SQL para actualizar los datos de la asistencia con base en su Id
            string sql = $"UPDATE asistencias SET Matricula={a.Matricula}, IdMateria={a.IdMateria}, Fecha='{a.Fecha:yyyy-MM-dd}', " +
                         $"HoraEntrada='{a.HoraEntrada}', HoraSalida='{a.HoraSalida}', EstadoAsistencia='{a.EstadoAsistencia}', " +
                         $"Observaciones='{a.Observaciones}' WHERE IdAsistencia={a.IdAsistencia}";

            // Ejecuta la instrucción SQL y almacena el resultado (true si tuvo éxito)
            bool resultado = con.executeInstruction(sql);

            // Cierra la conexión a la base de datos
            con.close();

            // Retorna si la operación fue exitosa o no
            return resultado;
        }

        // Método para eliminar una asistencia por su ID
        public bool EliminarAsistencia(int id)
        {
            // Abre la conexión a la base de datos
            con.open();

            // Prepara la instrucción SQL para eliminar la asistencia con el ID proporcionado
            string sql = $"DELETE FROM asistencias WHERE IdAsistencia = {id}";

            // Ejecuta la instrucción SQL y almacena el resultado (true si tuvo éxito)
            bool resultado = con.executeInstruction(sql);

            // Cierra la conexión a la base de datos
            con.close();

            // Retorna si la operación fue exitosa o no
            return resultado;
        }

        // Método para listar todas las asistencias
        public List<Asistencia> ListarAsistencias()
        {
            // Crea una lista vacía para almacenar los registros de asistencia
            List<Asistencia> lista = new List<Asistencia>();

            // Abre la conexión a la base de datos
            con.open();

            // Prepara la instrucción SQL para obtener todos los registros de la tabla asistencias
            string sql = "SELECT * FROM asistencias";

            // Ejecuta la consulta y obtiene los resultados en un DataSet
            DataSet ds = con.executeQuery(sql);

            // Cierra la conexión a la base de datos
            con.close();

            // Recorre cada fila del DataSet y la convierte en un objeto Asistencia
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lista.Add(new Asistencia
                {
                    IdAsistencia = Convert.ToInt32(row["IdAsistencia"]),
                    Matricula = Convert.ToInt32(row["Matricula"]),
                    IdMateria = Convert.ToInt32(row["IdMateria"]),
                    Fecha = Convert.ToDateTime(row["Fecha"]),
                    HoraEntrada = TimeSpan.Parse(row["HoraEntrada"].ToString()),
                    HoraSalida = TimeSpan.Parse(row["HoraSalida"].ToString()),
                    EstadoAsistencia = row["EstadoAsistencia"].ToString(),
                    Observaciones = row["Observaciones"].ToString()
                });
            }

            // Retorna la lista de asistencias
            return lista;
        }
    }
}
