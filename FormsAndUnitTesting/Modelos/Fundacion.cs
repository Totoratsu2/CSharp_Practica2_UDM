using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormsAndUnitTesting
{
    public class Fundacion
    {
        private int _nit;
        private string _nombre;
        private double _saldo;

        public Fundacion(int nit, string nombre, double saldo)
        {
            Nit = nit;
            Nombre = nombre;
            Saldo = saldo;
        }

        public int Nit { get => _nit; set => _nit = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Saldo { get => _saldo; set => _saldo = value; }
    }
}