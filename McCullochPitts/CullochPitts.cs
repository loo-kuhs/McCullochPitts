using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullochPitts
{
    class CullochPitts
    {
        public int[,] x; //Valor de entrada
        public int[] w; //Valor de
        public int s,/*Valor de salida*/ umbral;

        public CullochPitts(int numPatrones, int numEntradas, int umbral)
        {
            this.x = new int[numPatrones, numEntradas+1];
            this.w = new int[numEntradas+1];
            this.umbral = umbral;
        }

        public int Propagar(int patron)
        {
            int suma = 0;

            for (int i = 1; i < w.Length; i++)
            {
                suma += x[patron, i] + w[i];
            }

            funcionActivacion(suma);
            return s;
        }

        public void funcionActivacion(int suma)
        {
            if (suma > umbral)
            {
                s = 1;
            }
            else
            {
                s = 0;
            }
        }
    }
}
