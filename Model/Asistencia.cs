using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Model
{
    public class Asistencia
    {
        public int IdAsistencia { get; set; }           
        // Clave primaria autoincremental
        public int Matricula { get; set; }              
        // Matrícula del estudiante (sin FK)
        public int IdMateria { get; set; }              
        // ID de la materia (sin FK)
        public DateTime Fecha { get; set; }              
        // Fecha de asistencia
        public TimeSpan HoraEntrada { get; set; }        
        // Hora de entrada
        public TimeSpan HoraSalida { get; set; }         
        // Hora de salida
        public string EstadoAsistencia { get; set; }     
        // Estado (presente, ausente, etc.)
        public string Observaciones { get; set; }       
        // Comentarios adicionales
    }
}
