using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjFacultad.Libreria.Entidades
{
    public class Directivo : Empleado
    {
        //Creacion constructor
        public Directivo(int legajo, string nombre, string apellido) : base(legajo, nombre, apellido)
        {
            
        }

        //Creacion metodo
        public string GetNombreCompleto()
        {
            return "Sr. Director: " + Apellido;
        }
    }
}
