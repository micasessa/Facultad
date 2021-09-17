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


        //En caso de alumno, el metodo ToString invoca el metodo GetCredencial que devuelve un string con este template
        //"Código {codigo}) {apellido}, {nombre}"
        public string GetCredencial ()
        {
            return "Codigo" + Codigo + _apellido.Persona + _nombre.Persona;
        }

        //metodo para que me devuelva el nombre de la clase
        public override string ToString()
        {
            return GetCredencial(codigo);
        }



    }
}