using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjFacultad.Libreria.Entidades
{
    public class  Salario
    {
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuentos;
        private DateTime _fecha;

        //Creacion propiedades Getter
        public double Bruto { get => _bruto; }
        public string CodigoTransferencia { get => _codigoTransferencia; }
        public double Descuentos { get => _descuentos; }
        public DateTime Fecha { get => _fecha; }

        //Creacion de metodos
        public double GetSalarioNeto()
        {
            //Falta desarrollar
        }

        public void Salario (double)
        {
            //Falta desarrollar
        }
    }
}
