using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McCullochPitts
{
    public partial class Form1 : Form
    {
        public int s;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMcCulloch_Click(object sender, EventArgs e)
        {
            CullochPitts cullochPitts = new CullochPitts(4, 2, 0);

            cullochPitts.x[1, 1] = 0;
            cullochPitts.x[1, 2] = 0;
            cullochPitts.x[2, 1] = 0;
            cullochPitts.x[2, 2] = 1;
            cullochPitts.x[3, 1] = 1;
            cullochPitts.x[3, 2] = 0;
            cullochPitts.x[4, 1] = 1;
            cullochPitts.x[4, 2] = 1;

            cullochPitts.w[1] = 1;
            cullochPitts.w[2] = 1;

            s = cullochPitts.Propagar(1);
            s = cullochPitts.Propagar(2);
            s = cullochPitts.Propagar(3);
            s = cullochPitts.Propagar(4);
        }

        private void btnPerceptron_Click(object sender, EventArgs e)
        {
            Perceptron perceptron = new Perceptron(4, 2, -3.4);

            perceptron.x[1, 1] = -1;
            perceptron.x[1, 2] = -1;
            perceptron.x[2, 1] = 1;
            perceptron.x[2, 2] = -1;
            perceptron.x[3, 1] = -1;
            perceptron.x[3, 2] = 1;
            perceptron.x[4, 1] = 1;
            perceptron.x[4, 2] = 1;

            perceptron.w[1] = 2.3;
            perceptron.w[2] = -1.8;

            perceptron.dx[1] = -1;
            perceptron.dx[2] = -1;
            perceptron.dx[3] = -1;
            perceptron.dx[4] = 1;

            bool y;

            y = perceptron.Propagar(1);
            y = perceptron.Propagar(2);
            y = perceptron.Propagar(3);
            y = perceptron.Propagar(4);

            y = perceptron.Propagar(1);
            y = perceptron.Propagar(2);
            y = perceptron.Propagar(3);
            y = perceptron.Propagar(4);
        }
    }
}
