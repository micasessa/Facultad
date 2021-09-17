using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjFacultad.Libreria.Entidades
{
    public class Empleado : Persona
    {
        private DateTime _fechaIngreso;
        private int _legajo;
        private List<Salario> _salarios;
        private Salario _ultimoSalario;

        //Creacion propiedades
        public int Legajo { get => _legajo; }
        public DateTime FechaIngreso { get => _fechaIngreso; }
        public Salario UltimoSalario { get => _ultimoSalario; }
        public List<Salario> Salario { get => _salarios; }
        public DateTime FechaNacimiento { get => _fechaNac; } //hace ref al atributo _fechaNac de la clase Persona que hereda
        //public int Antiguedad { //FALTA DESARROLLAR }

        //Creacion Constructores
        public Empleado (int legajo, string nombre, string apellido, DateTime fechaNac, DateTime fechaIngreso): base(nombre, apellido, fechaNac)
        {
            this._legajo = legajo;
            this._fechaIngreso = fechaIngreso;
        }

        public Empleado (int legajo, string nombre, string apellido) : base (nombre, apellido)
        {
            this._legajo = legajo;
        }

        //Creacion de metodo NombreCompleto
        public string GetNombreCompleto()
        {
            return "Nombre y Apellido: " + Nombre + Apellido;
        }

    }
}
