using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadistica
{
    class Estadistica
    {
        
        public double Suma=0;

        public double Media(String[] Serie)
        {
            double Suma = 0;
            foreach (string valor in Serie)
            {
                Suma += int.Parse(valor);
            }
            return Suma / Serie.Length;
        }


        public double estandar(String[] serie)
        {
            double media_aritmetica = Media(serie),
                suma = 0;
            foreach (string valor in serie)
            {
                suma += Math.Pow(double.Parse(valor) - media_aritmetica, 2);
            }
            return suma / serie.Length;
        }
        public double tipica(String[] serie)
        {
            return Math.Sqrt(estandar(serie));
        }
    }
}
