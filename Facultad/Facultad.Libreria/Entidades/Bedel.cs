using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjFacultad.Libreria.Entidades
{
    public class Bedel : Empleado
    {
        protected string _apodo;

        //Creacion propiedad GETTER
        public string Apodo { get => _apodo; }

        //Creacion constructores
        public Bedel (int legajo, string nombre, string apellido, string apodo ) : base (legajo, nombre, apellido )
        {
            this._apodo = apodo;
        }
    }
}
