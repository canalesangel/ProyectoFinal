using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Model
{
    class Estudiante
    {
        public int Matricula { get; set; }                  
        // Clave primaria
        public string Nombre { get; set; }                  
        // Nombre del estudiante
        public string Apellidop { get; set; }               
        // Apellido paterno
        public string Apellidom { get; set; }              
        // Apellido materno
        public string Correo { get; set; }                 
        // Correo electrónico
        public string Telefono { get; set; }                
        // Número telefónico
        public string Carrera { get; set; }                 
        // Carrera del estudiante
        public string Semestre { get; set; }                
        // Semestre actual
        public string Estado { get; set; }                  
        // Estado (activo, baja, etc.)
            
        // Fecha de nacimiento
        public string FechaNacimiento { get; set; }
      


    }
}
