using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjFacultad.Libreria.Entidades
{
    public class Facultad
    {
        private List<Alumno> _alumnos;
        private int _cantidadSedes;
        private List<Empleado> _empleados;
        private string _nombre;

        //Creacion propiedades
        public int CantidadSedes { get => _cantidadSedes; }
        public string Nombre { get => _nombre; }

        //Creacion constructor 1
        public Facultad (string nombre, int cantidadSedes)
        {
            this._nombre = nombre;
            this._cantidadSedes = cantidadSedes;
        }

    }
}
