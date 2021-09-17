using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjFacultad.Libreria.Entidades
{
    public class Persona
    {
        protected string _apellido;
        protected DateTime _fechaNac;
        protected string _nombre;

        //Propiedades GETTER
        public string Apellido { get => _apellido; }
        public string Nombre { get => _nombre; }
        public DateTime Edad { get => _fechaNac; }

        //Creacion constructor 1
        public Persona (string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }
        public Persona(string nombre, string apellido, DateTime fechaNac)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._fechaNac = fechaNac;

        }

        //Metodos enunciado
        public string GetNombreCompleto(string identidad)
        {
            //Falta desarrollar
        }
        

    }
}
