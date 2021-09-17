using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjFacultad.Libreria.Entidades
{
    public class Alumno : Persona
    {
        protected int _codigo;
        
        //Propiedad Getter
        public int Codigo { get => _codigo; }

        //Constructor 1
        public Alumno(int codigo, string nombre, string apellido) : base(nombre, apellido)
        {
            this._codigo = codigo;

        }
    }
}