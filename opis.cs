using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kółkoikrzyżyk
{
    public partial class opis : Form
    { 
        public string winner;
        public Form1 board;
        public opis(Form1 b)
        {
            board = b;
            InitializeComponent();
        }

        private void showWinner(object sender, EventArgs e)
        {
            wygranyLabel.Text = "Wygrał: " + winner;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            board.clearBoard();
            this.Close();
        }
    }
}
