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
    }
}
