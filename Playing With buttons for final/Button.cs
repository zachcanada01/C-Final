using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playing_With_buttons_for_final
{
    public partial class Form1 : Form
    {
        int hit;
        int miss;
        int playerguess;
        int computerguess;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int randomGenerator = 5;

            if (randomGenerator == 5) {
                pictureBox5.Visible = true;
            }
        }
    }
}
