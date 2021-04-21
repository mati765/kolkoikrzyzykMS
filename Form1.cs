using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kółkoikrzyżyk
{
    enum CurrentPlayer
    {
        Cross,
        Circle
    }
    public partial class Form1 : Form
    {
        CurrentPlayer currentPlayer;
        public Form1()
        {
            InitializeComponent();
            currentPlayer = CurrentPlayer.Cross;
            changeLabel();
        }

        private void Pole(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if(currentPlayer == CurrentPlayer.Cross)
            {
                senderButton.Text = "X";
                currentPlayer = CurrentPlayer.Circle;
            }
            else
            {
                senderButton.Text = "O";
                currentPlayer = CurrentPlayer.Cross;
            }
            if (CheckForWinner())
                pokażWinner();
            changeLabel();
        }
        public void changeLabel()
        {
            if(currentPlayer == CurrentPlayer.Cross)
            {
                currentPlayerLabel.Text = "Krzyżyk";
            }
            else
            {
                currentPlayerLabel.Text = "Kółko";
            }
        }
        public bool CheckForWinner()
        {
            if (GL.Text == "X" && ŚL.Text == "X" && DL.Text == "X")
            {
                return true;
            }
            else if (GŚ.Text == "X" && ŚŚ.Text == "X" && DŚ.Text == "X")
            {
                return true;
            }
            else if (GP.Text == "X" && ŚP.Text == "X" && DP.Text == "X")
            {
                return true;
            }
            else if (GL.Text == "X" && GŚ.Text == "X" && GP.Text == "X")
            {
                return true;
            }
            else if (ŚL.Text == "X" && ŚŚ.Text == "X" && ŚP.Text == "X")
            {
                return true;
            }
            else if (DL.Text == "X" && DŚ.Text == "X" && DP.Text == "X")
            {
                return true;
            }
            else if (GL.Text == "X" && ŚŚ.Text == "X" && DP.Text == "X")
            {
                return true;
            }
            else if (GP.Text == "X" && ŚŚ.Text == "X" && DL.Text == "X")
            {
                return true;
            }
            if (GL.Text == "O" && ŚL.Text == "O" && DL.Text == "O")
            {
                return true;
            }
            else if (GŚ.Text == "O" && ŚŚ.Text == "O" && DŚ.Text == "O")
            {
                return true;
            }
            else if (GP.Text == "O" && ŚP.Text == "O" && DP.Text == "O")
            {
                return true;
            }
            else if (GL.Text == "O" && GŚ.Text == "O" && GP.Text == "O")
            {
                return true;
            }
            else if (ŚL.Text == "O" && ŚŚ.Text == "O" && ŚP.Text == "O")
            {
                return true;
            }
            else if (DL.Text == "O" && DŚ.Text == "O" && DP.Text == "O")
            {
                return true;
            }
            else if (GL.Text == "O" && ŚŚ.Text == "O" && DP.Text == "O")
            {
                return true;
            }
            else if (GP.Text == "O" && ŚŚ.Text == "O" && DL.Text == "O")
            {
                return true;
            }

            return false;
        }
        public void pokażWinner()
        {
            opis victoryScreen = new opis(this);
            victoryScreen.winner = GL.Text;
            victoryScreen.Show();
        }
        public void clearBoard()
        {
            TableLayoutControlCollection buttons = tableLayoutPanel1.Controls;
            
            for(int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i] is Button)
                    buttons[i].Text = "";
            }
            currentPlayer = CurrentPlayer.Cross;
            currentPlayerLabel.Text = "Krzyżyk";
        }
    }
}
