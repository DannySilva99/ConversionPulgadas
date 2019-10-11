using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionPulgadas
{
    class Conversion
    {
        public double Convertir(double Valor)
        {
            return Valor / 100;
        }
        public double Convertir(double Valor, int r)
        {
            return Valor * 39.37;
        }
        public double Convertir(double Valor, int r, int x)
        {
            return Valor * 1000;
        }
    }
}
