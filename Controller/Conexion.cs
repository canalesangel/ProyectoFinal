using System;
using System.Collections.Generic;
using System.Data;// Librería para trabajar Datos
using MySql.Data.MySqlClient; // Librería para trabajar con MySQL
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Controller
{
   
        // Clase que administra la conexión y operaciones con MySQL
        class ConexionMySQL
        {
            private MySqlConnection connection; // Objeto para manejar la conexión con la BD
            private string servidor = "localhost"; // Dirección del servidor MySQL (puede ser IP o nombre)
            private string bd = "proyecto"; // Nombre de la base de datos
            private string usuario = "root"; // Nombre de usuario de acceso a la base
            private string password = ""; // Contraseña del usuario
            private string datos = null; // Variable de uso general (puedes eliminarla si no se usa)

            // Constructor sin parámetros: crea automáticamente la cadena de conexión con las variables definidas
            public ConexionMySQL()
            {
                // Construcción de la cadena de conexión usando las variables
                string cadenaConexion = "Database=" + bd +
                                        "; Data Source=" + servidor +
                                        "; User Id=" + usuario +
                                        "; Password=" + password;

                // Inicializa la conexión con la cadena construida
                this.connection = new MySqlConnection(cadenaConexion);
            }

            // Abre la conexión a la base de datos
            public void open()
            {
                this.connection.Open();
            }

            // Cierra la conexión a la base de datos
            public void close()
            {
                this.connection.Close();
            }

            // Ejecuta una consulta SELECT y devuelve el resultado en un DataSet
            public DataSet executeQuery(string sql)
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, this.connection); // Crea adaptador para consulta
                DataSet d = new DataSet(); // Contenedor de datos
                adapter.Fill(d); // Llena el DataSet con los resultados
                return d; // Retorna el conjunto de datos
            }

            // Ejecuta una instrucción SQL (INSERT, UPDATE, DELETE) y devuelve true si afecta filas
            public bool executeInstruction(string sql)
            {
                MySqlCommand cmd = new MySqlCommand(); // Crea el comando
                cmd.Connection = this.connection; // Asigna la conexión activa
                cmd.CommandText = sql; // Establece la instrucción SQL
                return cmd.ExecuteNonQuery() > 0; // Ejecuta y evalúa si modificó filas
            }
        }//final de la clase
    }
