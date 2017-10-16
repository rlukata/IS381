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
        }
      
        public enum Player
        {
            X,
            O
        }

        //initialize player to X 
        Player currentPlayer = Player.X;

        //event handler for button_click
        private void Button_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.Text = currentPlayer.ToString();
            currentPlayer = currentPlayer == Player.X ? Player.O : Player.X;
            button.Enabled = false;
            Check();
        }

        private void button0x0_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void button0x1_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void button1x1_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void button2x1_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void button1x0_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void button2x0_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void button1x2_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void button0x2_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void button2x2_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

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

        private void Check()
        {
            //Check if tie
            if (button0x0.Text != "" && button0x1.Text != "" && button0x2.Text != "" &&
                button1x0.Text != "" && button1x1.Text != "" && button1x2.Text != "" &&
                button2x0.Text != "" && button2x1.Text != "" && button2x2.Text != "")
            {
                textBox1.Text = "Tied";
                disableXOButtonsEndGame();
            }

            //Check diagonal for X
            if (button0x0.Text == "X" && button1x1.Text == "X" && button2x2.Text == "X")
            {
                textBox1.Text = "Player X wins";
                disableXOButtonsEndGame();

            }
            if (button0x2.Text == "X" && button1x1.Text == "X" && button2x0.Text == "X")
            {
                textBox1.Text = "Player X wins";
                disableXOButtonsEndGame();
            }
            //Check rows for X
            if (button0x0.Text == "X" && button0x1.Text == "X" && button0x2.Text == "X")
            {
                textBox1.Text = "Player X wins";
                disableXOButtonsEndGame();
            }
            if (button1x0.Text == "X" && button1x1.Text == "X" && button1x2.Text == "X")
            {
                textBox1.Text = "Player X wins";
                disableXOButtonsEndGame();
            }
            if (button2x0.Text == "X" && button2x1.Text == "X" && button2x2.Text == "X")
            {
                textBox1.Text = "Player X wins";
                disableXOButtonsEndGame();
            }
            //Check columns for X
            if (button0x0.Text == "X" && button1x0.Text == "X" && button2x0.Text == "X")
            {
                textBox1.Text = "Player X wins";
                disableXOButtonsEndGame();
            }
            if (button0x1.Text == "X" && button1x1.Text == "X" && button2x1.Text == "X")
            {
                textBox1.Text = "Player X wins";
                disableXOButtonsEndGame();
            }
            if (button0x2.Text == "X" && button1x2.Text == "X" && button2x2.Text == "X")
            {
                textBox1.Text = "Player X wins";
                disableXOButtonsEndGame();
            }

            //Check diagonal for O
            if (button0x0.Text == "O" && button1x1.Text == "O" && button2x2.Text == "O")
            {
                textBox1.Text = "Player O wins";
                disableXOButtonsEndGame();
            }
            if (button0x2.Text == "O" && button1x1.Text == "O" && button2x0.Text == "O")
            {
                textBox1.Text = "Player O wins";
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
                textBox1.Text = "Player O wins";
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
                textBox1.Text = "Player O wins";
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
                textBox1.Text = "Player O wins";
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
                textBox1.Text = "Player O wins";
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
                textBox1.Text = "Player O wins";
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
                textBox1.Text = "Player O wins";
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
            buttonReset.Text = "";
            enableXOButtonsEndGame();
            currentPlayer = Player.X;
        }
    }
}
