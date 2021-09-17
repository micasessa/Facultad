using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjFacultad.Libreria.Entidades
{
    public class Docente: Empleado
    {
        //Creacion constructor
        public Docente(int legajo, string nombre, string apellido) : base(legajo, nombre, apellido)
        {

        }

        //Creacion metodo
        public string GetNombreCompleto(string nombre, string apellido)
        {
            //FALTA DESARROLLO
        }
    }
}
