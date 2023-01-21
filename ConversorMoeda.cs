using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_dolar
{
    public class ConversorMoeda
    {
        public static int Iof = 6;

        public static double Dolar;

        public static double ConersorDolarReal(double dolar, double quantidade)
        {
            double conversor = dolar * quantidade;

            return conversor + conversor * Iof / 100;

            
        }
    }
}
