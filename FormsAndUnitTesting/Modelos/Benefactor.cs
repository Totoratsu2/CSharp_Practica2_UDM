using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormsAndUnitTesting
{
    public class Benefactor
    {
        private string _identificacion;
        private string _nombre;
        private double _ayuda;

        public Benefactor(string identificacion, string nombre, double ayuda)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Ayuda = ayuda;
        }

        public string Identificacion { get => _identificacion; set => _identificacion = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Ayuda { get => _ayuda; set => _ayuda = value; }
    }
}