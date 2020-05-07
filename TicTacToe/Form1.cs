using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int[] boardState = new int[] { 0, 0, 0, 0, 0, 0, 0, 0,0};
        bool PlayerTurn = true;
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Brennan Coslett\nmatrikelNum: k11944223\nFor JKU C#", "About");
        }

        private void updatePlayerTurn()
        {
            PlayerTurn = !PlayerTurn;
            if (PlayerTurn)
            {
                current_player.Text = "     Player   ";
            }
            else
            {
                current_player.Text = "        AI      ";
            }
            turn_count++;
        }
        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "X";
            button.Enabled = false;
            boardState[Int32.Parse(button.Name.Substring(6))] = 1;
            checkForWinner();
            updatePlayerTurn();
        }
        private void checkForWinner()
        {
            int winner = 0;
            if (boardState[0] == boardState[1] && boardState[1] == boardState[2] && !button0.Enabled)//horizontal WinCons
            {
                winner = boardState[0];
            }
            else if (boardState[3] == boardState[4] && boardState[4] == boardState[5] && !button3.Enabled)
            {
                winner = boardState[3];
            }
            else if (boardState[6] == boardState[7] && boardState[7] == boardState[8] && !button6.Enabled)
            {
                winner = boardState[6];
            }
            else if (boardState[0] == boardState[3] && boardState[3] == boardState[6] && !button0.Enabled) //vert WinCons
            {
                winner = boardState[0];
            }
            else if (boardState[1] == boardState[4] && boardState[4] == boardState[7] && !button1.Enabled)
            {
                winner = boardState[1];
            }
            else if (boardState[2] == boardState[5] && boardState[5] == boardState[8] && !button2.Enabled)
            {
                winner = boardState[2];
            }
            else if (boardState[0] == boardState[4] && boardState[4] == boardState[8] && !button0.Enabled) //diag WinCons
            {
                winner = boardState[0];
            }
            else if (boardState[2] == boardState[4] && boardState[4] == boardState[6] && !button2.Enabled)
            {
                winner = boardState[2];
            }
            if(turn_count == 9)
            {
                draw_num.Text = ((Int32.Parse(draw_num.Text) + 1).ToString());
                MessageBox.Show("No Winner", "Draw");
                
            }
            else if (winner != 0)
            {
                foreach(Control c in Controls)
                {
                    try
                    {
                        Button b = (Button)c;
                        b.Enabled = false;
                    }
                    catch { };
                }
                if(winner == 1)
                {
                    ai_win_num.Text = ((Int32.Parse(ai_win_num.Text) + 1).ToString());
                    MessageBox.Show("AI Wins!", "Winner");
                    
                }
                else if(winner == 2) 
                {
                    player_win_num.Text = ((Int32.Parse(player_win_num.Text) + 1).ToString());
                    MessageBox.Show("Player Wins!", "Winner");
                    
                }
            }
        }
    }
}
