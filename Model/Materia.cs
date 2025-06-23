using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Model
{// Modelo de la tabla materias
    public class Materia
    {
        public int IdMateria { get; set; }          
        // Clave primaria autoincremental
        public string NombreMateria { get; set; }    
        // Nombre de la materia
        public int Creditos { get; set; }            
        // Número de créditos
        public string Carrera { get; set; }          
        // Carrera a la que pertenece
        public string Semestre { get; set; }        
        // Semestre al que corresponde
       
         
    }
}
