using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormsAndUnitTesting
{
    public class Familia
    {
        private int _identificacion;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private int _estrato;
        private string _barrio;
        private int _edad;
        private double _ayuda = 0.0;

        public Familia(int identificacion, string nombre, string apellido, string direccion, int estrato, string barrio, int edad)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Estrato = estrato;
            Barrio = barrio;
            Edad = edad;
        }

        public int Identificacion { get => _identificacion; set => _identificacion = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public int Estrato { get => _estrato; set => _estrato = value; }
        public string Barrio { get => _barrio; set => _barrio = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public double Ayuda { get => _ayuda; set => _ayuda = value; }

        public void recibirAyuda(double valorAyuda)
        {
            Ayuda += valorAyuda;
        }
    }
}