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
            if (enemyCoordinate.Text != "")
            {
                var attackPos = enemyCoordinate.Text;
                attackPos = attackPos.ToLower();
                int index = enemyPosition.FindIndex(a => a.Name == attackPos);

                if (enemyPosition[index].Enabled && rounds > 0)
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
            if (playerPosition.Count > 0 && rounds > 0)
            {
                rounds--;
                int index = rand.Next(playerPosition.Count);
                
                if (playerPosition[index].Tag == "playerShip")
                {
                    playerPosition[index].BackColor = Color.Red;
                    enemyMoves.Text = "" + playerPosition[index].Text;
                    playerPosition[index].Enabled = false;
                    playerPosition[index].BackColor = Color.LightBlue;
                    playerPosition.RemoveAt(index);
                    enemyTotalScore++;
                    enemyPlayTimer.Stop();
                }
                else
                {
                    playerPosition[index].BackColor = Color.Black;
                    enemyMoves.Text = "" + playerPosition[index].Text;
                    playerPosition[index].Enabled = false;
                    playerPosition[index].BackColor = Color.Blue;
                    playerPosition.RemoveAt(index);
                    enemyPlayTimer.Stop();
                    ;
                }

            }

        }

        private void enemyPicksPosition(object sender, EventArgs e)
        {
            int index = rand.Next(enemyPosition.Count);

            if (enemyPosition[index].Enabled == true && enemyPosition[index].Tag == null)
            {
                enemyPosition[index].Tag = "enemyShip";
                totalEnemy--;
            }
            else
            {
                index = rand.Next(enemyPosition.Count);
            }
            if (totalEnemy < 1)
            {
                enemyPositionPicker.Stop();
            }
        }
        private void loadButtons()
        {
            playerPosition = new List<Button> { A1, A2, A3, A4, A5, B1, B2, B3, B4, B5, C1, C2, C3, C4, C5, D1, D2, D3, D4, D5, E1, E2, E3, E4, E5 };
            enemyPosition = new List<Button> { cA1, cA2, cA3, cA4, cA5, cB1, cB2, cB3, cB4, cB5, cC1, cC2, cC3, cC4, cC5, cD1, cD2, cD3, cD4, cD5, cE1, cE2, cE3, cE4, cE5};

            for (int i = 0; i < enemyPosition.Count; i++)
            {
                enemyPosition[i].Tag = null;
                enemyCoordinate.Items.Add(enemyPosition[i].Text);
            }

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
           
        }

        private void A2_Click(object sender, EventArgs e)
        {
           
        }

        private void A3_Click(object sender, EventArgs e)
        {
          
        }

        private void A4_Click(object sender, EventArgs e)
        {
           
        }

        private void A5_Click(object sender, EventArgs e)
        {
           
        }

        private void B1_Click(object sender, EventArgs e)
        {
           
        }

        private void B2_Click(object sender, EventArgs e)
        {
         
        }

        private void B3_Click(object sender, EventArgs e)
        {
          
        }

        private void B4_Click(object sender, EventArgs e)
        {
           
        }

        private void B5_Click(object sender, EventArgs e)
        {
           
        }

        private void C1_Click(object sender, EventArgs e)
        {
            
        }

        private void C2_Click(object sender, EventArgs e)
        {
            
        }

        private void C3_Click(object sender, EventArgs e)
        {
        }

        private void C4_Click(object sender, EventArgs e)
        {
            
        }

        private void C5_Click(object sender, EventArgs e)
        {
            
        }

        private void D1_Click(object sender, EventArgs e)
        {
         
        }

        private void D2_Click(object sender, EventArgs e)
        {
           
        }

        private void D3_Click(object sender, EventArgs e)
        {

        }

        private void D4_Click(object sender, EventArgs e)
        {
          
        }

        private void D5_Click(object sender, EventArgs e)
        {
         
        }

        private void E1_Click(object sender, EventArgs e)
        {
           
        }

        private void E2_Click(object sender, EventArgs e)
        {
            
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

       

        
    }
}
