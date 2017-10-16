using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{

    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
            button0x0.Click += Button_Click;
            button0x1.Click += Button_Click;
            button0x2.Click += Button_Click;
            button1x0.Click += Button_Click;
            button1x1.Click += Button_Click;
            button1x2.Click += Button_Click;
            button2x0.Click += Button_Click;
            button2x1.Click += Button_Click;
            button2x2.Click += Button_Click;
        }

        //struct describing the different types of players (X, O)
        enum Player
        {
            X, O
        }

        //initialize player to X 
        Player currentPlayer = Player.X;

        //event handler defininf the behavior of button_click
        private void Button_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.Text = currentPlayer.ToString();
            currentPlayer = currentPlayer == Player.X ? Player.O : Player.X;
            button.Enabled = false;
            Check();
        }

        //disable the buttons
        private void disableXOButtonsEndGame()
        {
            button0x0.Enabled = false;
            button0x1.Enabled = false;
            button0x2.Enabled = false;
            button1x0.Enabled = false;
            button1x1.Enabled = false;
            button1x2.Enabled = false;
            button2x0.Enabled = false;
            button2x1.Enabled = false;
            button2x2.Enabled = false;
        }

        //enable the buttons
        private void enableXOButtonsEndGame()
        {
            button0x0.Enabled = true;
            button0x1.Enabled = true;
            button0x2.Enabled = true;
            button1x0.Enabled = true;
            button1x1.Enabled = true;
            button1x2.Enabled = true;
            button2x0.Enabled = true;
            button2x1.Enabled = true;
            button2x2.Enabled = true;
        }

        /**
         * The logic of the function Check compares the button's string (buttonXXX.Text) with 
         * the others button's string. Since it's a matrix of 3x3, there are three ways to win:
         *  - Three X or O in a diagonal
         *  - Three X or O in a row
         *  - Three X or O in a column
         **/
        private void Check()
        {
            //Check if tie
            if (button0x0.Text != "" && button0x1.Text != "" && button0x2.Text != "" &&
                button1x0.Text != "" && button1x1.Text != "" && button1x2.Text != "" &&
                button2x0.Text != "" && button2x1.Text != "" && button2x2.Text != "")
            {
                labelResult.Text = "Tied";
                disableXOButtonsEndGame();
            }

            //Check diagonal for X
            if (button0x0.Text == "X" && button1x1.Text == "X" && button2x2.Text == "X")
            {
                labelResult.Text = "Player X wins";
                disableXOButtonsEndGame();

            }
            if (button0x2.Text == "X" && button1x1.Text == "X" && button2x0.Text == "X")
            {
                labelResult.Text = "Player X wins";
                disableXOButtonsEndGame();
            }

            //Check rows for X
            if (button0x0.Text == "X" && button0x1.Text == "X" && button0x2.Text == "X")
            {
                labelResult.Text = "Player X wins";
                disableXOButtonsEndGame();
            }
            if (button1x0.Text == "X" && button1x1.Text == "X" && button1x2.Text == "X")
            {
                labelResult.Text = "Player X wins";
                disableXOButtonsEndGame();
            }
            if (button2x0.Text == "X" && button2x1.Text == "X" && button2x2.Text == "X")
            {
                labelResult.Text = "Player X wins";
                disableXOButtonsEndGame();
            }

            //Check columns for X
            if (button0x0.Text == "X" && button1x0.Text == "X" && button2x0.Text == "X")
            {
                labelResult.Text = "Player X wins";
                disableXOButtonsEndGame();
            }
            if (button0x1.Text == "X" && button1x1.Text == "X" && button2x1.Text == "X")
            {
                labelResult.Text = "Player X wins";
                disableXOButtonsEndGame();
            }
            if (button0x2.Text == "X" && button1x2.Text == "X" && button2x2.Text == "X")
            {
                labelResult.Text = "Player X wins";
                disableXOButtonsEndGame();
            }

            //Check diagonal for O
            if (button0x0.Text == "O" && button1x1.Text == "O" && button2x2.Text == "O")
            {
                labelResult.Text = "Player O wins";
                disableXOButtonsEndGame();
            }
            if (button0x2.Text == "O" && button1x1.Text == "O" && button2x0.Text == "O")
            {
                labelResult.Text = "Player O wins";
                button0x0.Enabled = false;
                button0x1.Enabled = false;
                button0x2.Enabled = false;
                button1x0.Enabled = false;
                button1x1.Enabled = false;
                button1x2.Enabled = false;
                button2x0.Enabled = false;
                button2x1.Enabled = false;
                button2x2.Enabled = false;
            }

            //Check rows for O
            if (button0x0.Text == "O" && button0x1.Text == "O" && button0x2.Text == "O")
            {
                labelResult.Text = "Player O wins";
                button0x0.Enabled = false;
                button0x1.Enabled = false;
                button0x2.Enabled = false;
                button1x0.Enabled = false;
                button1x1.Enabled = false;
                button1x2.Enabled = false;
                button2x0.Enabled = false;
                button2x1.Enabled = false;
                button2x2.Enabled = false;
            }
            if (button1x0.Text == "O" && button1x1.Text == "O" && button1x2.Text == "O")
            {
                labelResult.Text = "Player O wins";
                button0x0.Enabled = false;
                button0x1.Enabled = false;
                button0x2.Enabled = false;
                button1x0.Enabled = false;
                button1x1.Enabled = false;
                button1x2.Enabled = false;
                button2x0.Enabled = false;
                button2x1.Enabled = false;
                button2x2.Enabled = false;
            }
            if (button2x0.Text == "O" && button2x1.Text == "O" && button2x2.Text == "O")
            {
                labelResult.Text = "Player O wins";
                button0x0.Enabled = false;
                button0x1.Enabled = false;
                button0x2.Enabled = false;
                button1x0.Enabled = false;
                button1x1.Enabled = false;
                button1x2.Enabled = false;
                button2x0.Enabled = false;
                button2x1.Enabled = false;
                button2x2.Enabled = false;
            }

            //Check columns for O
            if (button0x0.Text == "O" && button1x0.Text == "O" && button2x0.Text == "O")
            {
                labelResult.Text = "Player O wins";
                button0x0.Enabled = false;
                button0x1.Enabled = false;
                button0x2.Enabled = false;
                button1x0.Enabled = false;
                button1x1.Enabled = false;
                button1x2.Enabled = false;
                button2x0.Enabled = false;
                button2x1.Enabled = false;
                button2x2.Enabled = false;
            }
            if (button0x1.Text == "O" && button1x1.Text == "O" && button2x1.Text == "O")
            {
                labelResult.Text = "Player O wins";
                button0x0.Enabled = false;
                button0x1.Enabled = false;
                button0x2.Enabled = false;
                button1x0.Enabled = false;
                button1x1.Enabled = false;
                button1x2.Enabled = false;
                button2x0.Enabled = false;
                button2x1.Enabled = false;
                button2x2.Enabled = false;
            }
            if (button0x2.Text == "O" && button1x2.Text == "O" && button2x2.Text == "O")
            {
                labelResult.Text = "Player O wins";
                button0x0.Enabled = false;
                button0x1.Enabled = false;
                button0x2.Enabled = false;
                button1x0.Enabled = false;
                button1x1.Enabled = false;
                button1x2.Enabled = false;
                button2x0.Enabled = false;
                button2x1.Enabled = false;
                button2x2.Enabled = false;
            }
        }

        //restart
        private void buttonReset_Click(object sender, EventArgs e)
        {
            button0x0.Text = "";
            button0x1.Text = "";
            button0x2.Text = "";
            button1x0.Text = "";
            button1x1.Text = "";
            button1x2.Text = "";
            button2x0.Text = "";
            button2x1.Text = "";
            button2x2.Text = "";
            labelResult.Text = "";
            enableXOButtonsEndGame();
            currentPlayer = Player.X;
        }

    }
}
