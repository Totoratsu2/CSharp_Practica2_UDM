using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormsAndUnitTesting
{
    public class Main
    {
        public static List<Familia> familias = new List<Familia>();
        public static List<Benefactor> benefactores = new List<Benefactor>();
        public static List<Fundacion> fundaciones = new List<Fundacion>();
        public static double saldoFundacion = 400000;

        public static bool entregarAyudas(int identificacionFamilia, double ayuda)
        {
            bool bandera = false;
            foreach (Familia familia in familias)
            {
                if(familia.Identificacion == identificacionFamilia && 0 < ayuda && ayuda <= saldoFundacion)
                {
                    familia.recibirAyuda(ayuda);
                    bandera = true;
                }
            }

            return bandera;
        }
    }
}