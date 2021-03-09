using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullochPitts
{
    class Perceptron
    {
        #region Variables compuestas
        public int[,] x;
        public double[] w;
        public int[] dx;
        #endregion

        #region Variables primitivas
        public double umbral;
        public int y;
        public double s = 0;
        #endregion

        #region Metodo Constructor
        public Perceptron(int numPatrones, int numEntradas, double umbral)
        {
            this.x = new int[numPatrones + 1, numEntradas + 1];
            this.w = new double[numEntradas + 1];
            this.dx = new int[numPatrones + 1];
            this.umbral = umbral;
        }
        #endregion

        public bool Propagar(int Patron)
        {
            for (int i = 1; i < w.Length; i++)
            {
                s += w[i] * x[Patron, i];
            }

            s += umbral;

            if (s > 0)
            {
                y = 1;
            }
            else
            {
                y = -1;
            }

            if (y != dx[Patron])
            {
                double delta;
                for (int i = 1; i < w.Length; i++)
                {
                    delta = dx[Patron] * x[Patron, i];
                    w[i] += delta;
                }
                umbral += dx[Patron];

                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
