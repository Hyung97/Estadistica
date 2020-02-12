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


        public double Armonica(string[] Serie)
        {
            double Suma = 0;
            foreach (string valor in Serie)
            {
                Suma += 1 / int.Parse(valor);
            }
            return Serie.Length / Suma;


        }
        public double tipica(string[] serie)
        {
            double media_aritmetica = Media(serie),
                Suma = 0,
                estandar = 0;
            foreach (string valor in serie)
            {
                Suma += Math.Pow(double.Parse(valor) - media_aritmetica, 2);
            }
            estandar = Suma / serie.Length;
            return Math.Sqrt(estandar);
        }
    }
}
