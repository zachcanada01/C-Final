using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics; 

namespace Playing_With_buttons_for_final
{
    public partial class GameBoard : Form
    {
        List<Button> playerPosition;
        List<Button> enemyPosition;
        Random rand = new Random();
        int totalShips = 5;
        int totalEnemy = 5;
        int rounds = 5;
        int playerTotalScore = 0;
        int enemyTotalScore = 0;



        public GameBoard()
        {
            InitializeComponent();
            loadButtons();
            attackButton.Enabled = false;
            enemyCoordinate.Text = null;
           
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
                A1.BackColor = Color.Blue;
                
            }
        }

        private void A2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                A2.BackColor = Color.Blue;
                
            }
        }

        private void A3_Click(object sender, EventArgs e)
        {
            if (true)
            {
                A3.BackColor = Color.Blue;
                
            }
        }

        private void A4_Click(object sender, EventArgs e)
        {
            if (true)
            {
                A4.BackColor = Color.Blue;
               
            }
        }

        private void A5_Click(object sender, EventArgs e)
        {
            if (true)
            {
                A5.BackColor = Color.Blue;
                
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                B1.BackColor = Color.Blue;
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                B2.BackColor = Color.Blue;
               
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (true)
            {
                B3.BackColor = Color.Blue;
                
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (true)
            {
                B4.BackColor = Color.Blue;
                
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (true)
            {
                B5.BackColor = Color.Blue;
                
            }
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                C1.BackColor = Color.Blue;
                
            }
        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                C2.BackColor = Color.Blue;
                
            }
        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (true)
            {
                C3.BackColor = Color.Blue;
                
            }
        }

        private void C4_Click(object sender, EventArgs e)
        {
            if (true)
            {
                C4.BackColor = Color.Blue;
                
            }
        }

        private void C5_Click(object sender, EventArgs e)
        {
            if (true)
            {
                C5.BackColor = Color.Blue;
                
            }
        }

        private void D1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                D1.BackColor = Color.Blue;
                
            }
        }

        private void D2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                D2.BackColor = Color.Blue;
                
            }
        }

        private void D3_Click(object sender, EventArgs e)
        {
            if (true)
            {
                D3.BackColor = Color.Blue;
                
            }
        }

        private void D4_Click(object sender, EventArgs e)
        {
            if (true)
            {
                D4.BackColor = Color.Blue;
                
            }
        }

        private void D5_Click(object sender, EventArgs e)
        {
            if (true)
            {
                D5.BackColor = Color.Blue;
                
            }
        }

        private void E1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                E1.BackColor = Color.Blue;
                
            }
        }

        private void E2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                E2.BackColor = Color.Blue;
                
            }
        }

        private void E3_Click(object sender, EventArgs e)
        {
            if (true)
            {
                E3.BackColor = Color.Blue;
                
            }
        }

        private void E4_Click(object sender, EventArgs e)
        {
            if (true)
            {
                E4.BackColor = Color.Blue;
                
            }
        }

        private void E5_Click(object sender, EventArgs e)
        {
            if (true)
            {
                
                
            }
        }

        private void playerPicksPosition(object sender, EventArgs e)
        {
            if (totalShips > 0)
            {
                var button = (Button)sender;
                button.Enabled = false;
                button.Tag = "playerShip";
                button.BackColor = Color.Blue;
                totalShips--;
            }
            if (totalShips == 0)
            {
                attackButton.Enabled = true;
                attackButton.BackColor = Color.Yellow;


            }

        }

        private void attackEnemyPosition(object sender, EventArgs e)
        {
            if(enemyCoordinate.Text != "")
            {
                var attackPos = enemyCoordinate.Text;
                attackPos = attack.ToLower();
                int index = enemyPosition.FindIndex(a => a.Name == attackPos);

                if(enemyPosition[index].Enabled && rounds > 0)
                {
                    rounds--;
                    if (enemyPosition[index].Tag == "enemyShip")
                    {
                        enemyPosition[index].Enabled = false;
                        enemyPosition[index].BackColor = Color.Red;
                        enemyPosition[index].BackColor = Color.LightBlue;
                        playerTotalScore++;
                        enemyPlayTimer.Start();
                    }
                    else
                    {
                        enemyPosition[index].Enabled = false;
                        enemyPosition[index].BackColor = Color.Black;
                        enemyPosition[index].BackColor = Color.LightBlue;
                        enemyPlayTimer.Start();
                    }
                        
                }
                

            }
            
        }

        private void enemyAttackPlayer(object sender, EventArgs e)
        {

        }

        private void enemyPicksPosition(object sender, EventArgs e)
        {
            int index = rand.Next(enemyPosition.Count);

            if(enemyPosition[index].Enabled == true && enemyPosition[index].Tag == null)
            {
                enemyPosition[index].Tag = "enemyShip";
                totalEnemy--;
            }
            else
            {
                index = rand.Next(enemyPosition.Count);
            }
        }
        private void loadButtons()
        {
            playerPosition = new List<Button> {A1, A2, A3, A4, A5, B1, B2, B3, B4, B5, C1, C2, C3, C4, C5, D1, D2, D3, D4, D5, E1, E2, E3, E4, E5 };
            enemyPosition = new List<Button> {A1, A2, A3, A4, A5, B1, B2, B3, B4, B5, C1, C2, C3, C4, C5, D1, D2, D3, D4, D5, E1, E2, E3, E4, E5 };

            for (int i = 0; i < enemyPosition.Count; i++)
            {
                enemyPosition[i].Tag = null;
                enemyCoordinate.Items.Add(enemyPosition[i].Text);
            }
            
        }
    }
}
