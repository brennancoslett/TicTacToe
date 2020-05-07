using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        // 0 = blank, -1 = player, 1 = AI
        int[] boardState = new int[] { 0, 0, 0, 0, 0, 0, 0, 0,0};
        bool PlayerTurn = true;
        int turn_count = 0;
        string algorithm = "MiniMax";
        
        public Form1()
        {
            InitializeComponent();
            algorithm_val.Text = algorithm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Brennan Coslett\nmatrikelNum: k11944223\nFor JKU C#", "About");
        }

        private void updatePlayerTurn(string IsPlayerTurn = null, bool resetTurn = false)
        {
            if (IsPlayerTurn == null)
            {
                PlayerTurn = !PlayerTurn;
            }else if (IsPlayerTurn == "Player")
            {
                PlayerTurn = true;
            }else 
            {
                PlayerTurn = false;
            }
                
            if (resetTurn) { PlayerTurn = true; }
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
            boardState[Int32.Parse(button.Name.Substring(6))] = -1;
            if (!checkForWinner())// also updates turn labels and if winner resets board
            {
                AI_Turn();
            }
        }

        private void AI_Turn()
        {
            Button[] ListOfButtons = new Button[] { button0, button1, button2, 
                button3, button4, button5, button6, button7, button8 };
            int[] currentBoardState = boardState;
            bool useMiniMax = (algorithm == "MiniMax");
            if (useMiniMax)
            {

            }else
            {
                int moveIndex = randomNextMoveIndex(currentBoardState);
                boardState[moveIndex] = 1;
                ListOfButtons[moveIndex].Text = "O";
                ListOfButtons[moveIndex].Enabled = false;
                checkForWinner();
            }

        }

        private int randomNextMoveIndex(int[] boardState)
        {
            int[] currentState= boardState;

            Random rnd = new Random();
            List<int> ValidMoves = new List<int>();
            int move = -1;
            for(int i = 0; i < currentState.Length; i++)
            {
             if (currentState[i] == 0) { ValidMoves.Add(i); }   
            }
            int index = rnd.Next(ValidMoves.Count);
            move = ValidMoves[index];
            return move;
        }
        private void ResetGame(bool algorithmChange = false)
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
            
            turn_count = 0;
            Array.Clear(boardState, 0, boardState.Length);
            if (algorithmChange)
            {
                updatePlayerTurn(null, true);
                player_win_num.Text = "0";
                ai_win_num.Text = "0";
                draw_num.Text = "0";
                MessageBox.Show("All Values Reset", "Algorithm Changed");
            }
            else
            {
                updatePlayerTurn("Player");
            }
        }

        private bool checkForWinner()
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

            if (winner != 0)
            {
                foreach (Control c in Controls)
                {
                    try
                    {
                        Button b = (Button)c;
                        b.Enabled = false;
                    }
                    catch { };
                }
                if (winner == 1)
                {
                    ai_win_num.Text = ((Int32.Parse(ai_win_num.Text) + 1).ToString());
                    MessageBox.Show("AI Wins!", "Winner");

                }
                else if (winner == -1)
                {
                    player_win_num.Text = ((Int32.Parse(player_win_num.Text) + 1).ToString());
                    MessageBox.Show("Player Wins!", "Winner");

                }
                else if (turn_count == 9)
                {
                    draw_num.Text = ((Int32.Parse(draw_num.Text) + 1).ToString());
                    MessageBox.Show("No Winner", "Draw");

                }
                ResetGame();
                return true;
            }else
            {
                if (PlayerTurn)
                {
                    updatePlayerTurn("AI");
                }
                else 
                {
                    updatePlayerTurn("Player");
                }
            }
            return false;
        }

        private void changeAlgorithm(object sender, EventArgs e)
        {
            ToolStripMenuItem m = (ToolStripMenuItem)sender;
            string firstChar = m.Name.Substring(0, 1);
            if (firstChar == "m")
            {
                algorithm = "MiniMax";

            }
            else
            {
                algorithm = "Random";
            }
            algorithm_val.Text = algorithm;
            ResetGame(true);
        }
    }
}
