using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameCh14_8
{
    public partial class Form1 : Form
    {
        int userInput;
        int comNum;

        Random rand = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comNum = rand.Next(1, 1000);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckGuess();
        }

        public void CheckGuess()
        {
            
            userInput = int.Parse(txtInput.Text);
            
           
            if (userInput == comNum)
            {
                lblMessage.Text = "You guessed correctly!";
                this.BackColor = System.Drawing.Color.Green;

            }

            else if (userInput < comNum)
                lblMessage.Text = "You are too low.";

            else if (userInput > comNum)
                lblMessage.Text = "You are too high.";

            
        }

        public void StartOver()
        {
            comNum = rand.Next(1, 1000);
            txtInput.Text = " ";
            lblMessage.Text = " ";
            this.BackColor = System.Drawing.Color.LightGreen;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            StartOver();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
