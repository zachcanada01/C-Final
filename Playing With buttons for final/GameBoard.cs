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
    public partial class GameBoard : Form
    {
        int userChoice;

        public GameBoard()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu f2 = new MainMenu();
            f2.ShowDialog();
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void A1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                
            }
        }
    }
}
