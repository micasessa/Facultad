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
        //private Salario _ultimoSalario;

        //Creacion propiedades
        public int Legajo { get => _legajo; }
        public DateTime FechaIngreso { get => _fechaIngreso; }
        public Salario UltimoSalario { get => Salario; }
        public List<Salario> Salario { get => _salarios; }
        public DateTime FechaNacimiento { get => _fechaNac; } //hace ref al atributo _fechaNac de la clase Persona que hereda
        public int Antiguedad { //FALTA DESARROLLAR }

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

        //Empleado a su vez implementa GetCredencial devolviendo el string con el siguiente template: "{legajo} - {nombreCompleto} salario $ {ultimoSalarioNeto}"
        public string GetCredencial()
        {
            //FALTA DESARROLLO ULTIMOSALARIONETO!
            return Legajo + "-" + GetNombreCompleto() + UltimoSalario;
        }

        public void AgregarSalario(Salario)
        {
            //FALTA DES
        }

        public bool Equals(object)
        {
            //FALTA DES
        }

        public string ToString ()
        {
            //FALTA DES
        }
        
    }
}
