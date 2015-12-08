using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cook_RockPaperScissors
{
    public partial class frmMain : Form
    {

        int playerHealth = 10;
        int compHealth = 10;
        int playerWins = 0;
        bool playerWin = false;
        int count;
        int rockDmg = 2;
        int paperDmg = 2;
        int scissorsDmg = 2;
        int rockBonus = 0;
        int paperBonus = 0;
        int scissorBonus = 0;

        MainPlay play = new MainPlay();
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            lblMessage.Text = " ";
            lblPlayerChoice.Text = "Rock";
           
            lblPlayerRoll.Text = Convert.ToString(play.PlayerRollDice());
            {
                if (lblPlayerRoll.Text == "1")
                    playerHealth -= 2;
                else if (lblPlayerRoll.Text == "20")
                    compHealth -= 2;
            }

            lblCompRoll.Text = Convert.ToString(play.CompRollDice());
            {
                if (lblCompRoll.Text == "1")
                    compHealth -= 2;
                else if (lblCompRoll.Text == "20")
                    playerHealth -= 2;
            }

            lblComChoice.Text = play.CompGuess();

            {
                if (lblComChoice.Text == "Rock")
                {
                    playerHealth += 0;
                    compHealth += 0;
                    lblPlayerHealth.Text = playerHealth.ToString();
                    lblComHealth.Text = compHealth.ToString();
                }

                else if (lblComChoice.Text == "Paper")
                {
                    playerHealth -= 2;
                    compHealth += 0;
                    lblPlayerHealth.Text = playerHealth.ToString();
                    lblComHealth.Text = compHealth.ToString();
                }

                else if (lblComChoice.Text == "Scissors")
                {
                    playerHealth += 0;
                    compHealth -= rockDmg;
                    lblPlayerHealth.Text = playerHealth.ToString();
                    lblComHealth.Text = compHealth.ToString();
                }
            }

            if (playerHealth <= 0)
            {
                lblMessage.Text = "You lose! Press a button to play again.";
                playerHealth = 10;
                compHealth = 10;
                playerWins = 0;
                lblPlayerWins.Text = playerWins.ToString();
                playerWin = false;
            }

            else if (compHealth <= 0)
            {
                lblMessage.Text = " You win! Press a button to play again.";
                playerHealth = 10;
                compHealth = 10;
                playerWins += 1;
                lblPlayerWins.Text = playerWins.ToString();
                playerWin = true;
            }

            if (playerWin == true)
            {
                for (count = 0; count == playerWins; count++)
                {
                    compHealth += 5;
                    playerHealth += 5;


                }
            }
            playerWin = false;
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            lblMessage.Text = " ";
            
            lblPlayerChoice.Text = "Paper";
            lblPlayerRoll.Text = Convert.ToString(play.PlayerRollDice());
            {
                if (lblPlayerRoll.Text == "1")
                    playerHealth -= 2;
                else if (lblPlayerRoll.Text == "20")
                    compHealth -= 2;
            }

            lblCompRoll.Text = Convert.ToString(play.CompRollDice());
            {
                if (lblCompRoll.Text == "1")
                    compHealth -= 2;
                else if (lblCompRoll.Text == "20")
                    playerHealth -= 2;
            }

            lblComChoice.Text = play.CompGuess();
            {

                if (lblComChoice.Text == "Rock")
                {
                    playerHealth += 0;
                    compHealth -= paperDmg;
                    lblPlayerHealth.Text = playerHealth.ToString();
                    lblComHealth.Text = compHealth.ToString();
                }

                else if (lblComChoice.Text == "Paper")
                {
                    playerHealth += 0;
                    compHealth +=0;

                    lblPlayerHealth.Text = playerHealth.ToString();
                    lblComHealth.Text = compHealth.ToString();
                }

                else if (lblComChoice.Text == "Scissors")
                {
                    playerHealth -= 2;
                    compHealth += 0;

                    lblPlayerHealth.Text = playerHealth.ToString();
                    lblComHealth.Text = compHealth.ToString();
                }
            }

            if (playerHealth <= 0)
            {
                lblMessage.Text = "You lose! Press a button to play again.";
                playerHealth = 10;
                compHealth = 10;
                playerWins = 0;
                lblPlayerWins.Text = playerWins.ToString();
                playerWin = false;
            }

            else if (compHealth <= 0)
            {
                lblMessage.Text = " You win! Press a button to play again.";
                playerHealth = 10;
                compHealth = 10;
                playerWins += 1;

                lblPlayerWins.Text = playerWins.ToString();
                playerWin = true;
            }

            if (playerWin == true)
            {
                for (count = 0; count < playerWins; count++)
                {
                    compHealth += 5;
                    playerHealth += 5;
                }
            }
            playerWin = false;
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            lblMessage.Text = " ";
            lblPlayerChoice.Text = "Scissors";

            lblPlayerRoll.Text = Convert.ToString(play.PlayerRollDice());
            {
                if (lblPlayerRoll.Text == "1")
                    playerHealth -= 2;
                else if (lblPlayerRoll.Text == "20")
                    compHealth -= 2;
            }

            lblCompRoll.Text = Convert.ToString(play.CompRollDice());
            {
                if (lblCompRoll.Text == "1")
                    compHealth -= 2;
                else if (lblCompRoll.Text == "20")
                    playerHealth -= 2;
            }

            lblComChoice.Text = play.CompGuess();
            {

                if (lblComChoice.Text == "Rock")
                {
                    playerHealth -= 2;
                    compHealth += 0;

                    lblPlayerHealth.Text = playerHealth.ToString();
                    lblComHealth.Text = compHealth.ToString();
                }

                else if (lblComChoice.Text == "Paper")
                {
                    playerHealth += 0;
                    compHealth -= scissorsDmg;

                    lblPlayerHealth.Text = playerHealth.ToString();
                    lblComHealth.Text = compHealth.ToString();
                }

                else if (lblComChoice.Text == "Scissors")
                {
                    playerHealth += 0;
                    compHealth += 0;

                    lblPlayerHealth.Text = playerHealth.ToString();
                    lblComHealth.Text = compHealth.ToString();
                }
            }

            if (playerHealth <= 0)
            {
                lblMessage.Text = "You lose! Press a button to play again.";
                playerHealth = 10;
                compHealth = 10;
                playerWins = 0;
                scissorBonus = 0;
                scissorsDmg = 2;
                lblPlayerWins.Text = playerWins.ToString();
                playerWin = false;
            }

            else if (compHealth <= 0)
            {
                lblMessage.Text = " You win! Press a button to play again.";
                playerHealth = 10;
                compHealth = 10;
                playerWins += 1;
                lblPlayerWins.Text = playerWins.ToString();
                playerWin = true;
            }

            if (playerWin == true)
            {
                for (count = 0; count < playerWins; ++count)
                {
                    compHealth += 5;
                    playerHealth += 5;
                }
            }
            playerWin = false;
            
        }
    }
}
