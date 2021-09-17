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
    }
}
