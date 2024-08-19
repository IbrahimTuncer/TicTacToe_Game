using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Game
{

    public partial class Form1 : Form
    {

        char who = 'O';
        short movement = 0;

        int player1 = 0;
        int player2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            who = 'O';
            movement = 0;
            tableLayoutPanel1.Enabled = true;
            btn1.Enabled = true; btn1.Text = ""; btn1.BackColor = Color.White;
            btn2.Enabled = true; btn2.Text = ""; btn2.BackColor = Color.White;
            btn3.Enabled = true; btn3.Text = ""; btn3.BackColor = Color.White;
            btn4.Enabled = true; btn4.Text = ""; btn4.BackColor = Color.White;
            btn5.Enabled = true; btn5.Text = ""; btn5.BackColor = Color.White;
            btn6.Enabled = true; btn6.Text = ""; btn6.BackColor = Color.White;
            btn7.Enabled = true; btn7.Text = ""; btn7.BackColor = Color.White;
            btn8.Enabled = true; btn8.Text = ""; btn8.BackColor = Color.White;
            btn9.Enabled = true; btn9.Text = ""; btn9.BackColor = Color.White;
        }

        private void ınfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game is Tic Tac Toe, and The coder is Ibrahim Tuncer - 240ADB016");
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Enabled = false;
            
            if(who == 'O')
            {
                btn.BackColor = Color.Blue;
                btn.Text = "O";
                if((btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn2.Text != "") ||
                    (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn5.Text != "") ||
                    (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn8.Text != "") ||
                    (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn5.Text != "") ||
                    (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn5.Text != "") ||
                    (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn4.Text != "") ||
                    (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn5.Text != "") ||
                    (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn6.Text != ""))
                {
                    player1++;
                    lbl2.Text = player1.ToString();
                    MessageBox.Show(($"The winner is :  {who.ToString().ToUpper()}!!!"));
                    tableLayoutPanel1.Enabled = false;
                }
                else if(movement == 8)
                {
                    MessageBox.Show("Draw!!!");
                }
                who = 'X';
            }
            else if (who == 'X')
            {
                btn.BackColor = Color.Red;
                btn.Text = "X";

                if ((btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn2.Text != "") ||
                    (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn5.Text != "") ||
                    (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn8.Text != "") ||
                    (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn5.Text != "") ||
                    (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn5.Text != "") ||
                    (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn4.Text != "") ||
                    (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn5.Text != "") ||
                    (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn6.Text != ""))
                {
                    player2++;
                    lbl3.Text = player2.ToString();
                    MessageBox.Show(($"The winner is :  {who.ToString().ToUpper()}!!!"));
                    tableLayoutPanel1.Enabled = false;
                }
                else if (movement == 8)
                {
                    MessageBox.Show("Draw!!!");
                }

                who = 'O';
            }
            movement++;
        }
    }
}