using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool Turn=true;

        public Form1()
        {
            InitializeComponent();

            this.Text = "TicTacToe";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control item in this.Controls)
                {
                    Button b = item as Button;
                    if (b.Enabled == false)
                    {
                        b.Enabled = true;
                        b.Text= "";
                    }       
                }     
            }
            catch
            {

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (Turn == true)
            {
                button.Text = "X";
            }
            else            
               button.Text = "O";
                
            Turn = !Turn;
            button.Enabled=false;

            if (ChackWinner() == true)
            {
                if (Turn == true)
                    MessageBox.Show("Player O won!");
                else
                    MessageBox.Show("Player X won!");

                try
                {
                    foreach (Control item in this.Controls)
                    {
                        Button b = item as Button;
                        if (b.Enabled == true)
                            b.Enabled = false;
                    }
                }
                catch
                {

                }
            }

            else if (EndOfGame() == true)
            { 
                MessageBox.Show("Game over");
                try
                {
                    foreach (Control item in this.Controls)
                    {
                        Button b = item as Button;
                        if (b.Enabled == true)
                            b.Enabled = false;
                    }
                }
                catch
                {

                }
            }

        }

       private bool EndOfGame()
        {
            try
            {
                foreach (Control item in this.Controls)
                {
                    Button b = item as Button;
                    if (b.Enabled == true)
                        return false;
                }
                return true;
            }
            catch
            {       
                return true;
            }
        }

        private bool ChackWinner()
        {
            if (btnA1.Text == btnA2.Text && btnA2.Text == btnA3.Text && btnA1.Text != "")
            return true;

            if (btnB1.Text == btnB2.Text && btnB2.Text == btnB3.Text && btnB1.Text != "")
            return true;

            if (btnC1.Text == btnC2.Text && btnC2.Text == btnC3.Text && btnC1.Text != "")
            return true;

            if (btnA1.Text == btnB1.Text && btnB1.Text == btnC1.Text && btnA1.Text != "")
            return true;

            if (btnA2.Text == btnB2.Text && btnB2.Text == btnC2.Text && btnA2.Text != "")
            return true;
 
            if (btnA3.Text == btnB3.Text && btnB3.Text == btnC3.Text && btnA3.Text != "")
            return true;

            if (btnA1.Text==btnB2.Text && btnB2.Text==btnC3.Text && btnA1.Text!="")
            return true;

            if (btnA3.Text==btnB2.Text && btnB2.Text==btnC1.Text && btnA3.Text!="")
            return true;

            return false;    
        }

    }
}
