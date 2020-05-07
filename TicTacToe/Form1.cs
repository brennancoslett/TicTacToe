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
        int[] BoardState = new int[] { 0, 0, 0, 0, 0, 0, 0, 0,0};
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

        private void Player_Turn(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "X";
            button.Enabled = false;
            BoardState[Int32.Parse(button.Name.Substring(6))] = -1;
            turn_count++;
            if (!checkForWinner(BoardState))// also updates turn labels and if winner resets board
            {
                AI_Turn();
            }
        }

        private void AI_Turn()
        {
            Button[] ListOfButtons = new Button[] { button0, button1, button2, 
                button3, button4, button5, button6, button7, button8 };
            int[] currentBoardState = BoardState;
            bool useMiniMax = (algorithm == "MiniMax");
            int moveIndex = -1;
            if (useMiniMax)
            {
                moveIndex = calcMiniMax(currentBoardState);
            } else
            {
                moveIndex = randomNextMoveIndex(currentBoardState);
            }
            if (moveIndex != -1)
            {
                BoardState[moveIndex] = 1;
                ListOfButtons[moveIndex].Text = "O";
                ListOfButtons[moveIndex].Enabled = false;
                turn_count++;
            }
            checkForWinner(BoardState);
        }

        private int calcMiniMax(int[] boardState)
        {
            int[] currentState = boardState;
            List<int> ValidMoves = new List<int>();
            int move = -1;
            for (int i = 0; i < currentState.Length; i++)
            {
                if (currentState[i] == 0) { ValidMoves.Add(i); }
            }
            for (int i = 0; i < ValidMoves.Count; i++)
            {
                if (ValidMoves[i] ==1) 
                {
                    currentState[i] = 1;
                    if (isStateWinner(currentState)) 
                    {
                        move = i;                    
                    }
                }
            }

            return move;
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
            if (ValidMoves.Count != 0)
            {
                move = ValidMoves[index];
                return move;
            }
            else
            {
                return -1;
            }
        }
        private bool isStateWinner(int[] board)
        {
            int[] boardState = board;
            if (boardState[0] == boardState[1] && boardState[1] == boardState[2] && !button0.Enabled)//horizontal WinCons
            {
                return true;
            }
            else if (boardState[3] == boardState[4] && boardState[4] == boardState[5] && !button3.Enabled)
            {
                return true;
            }
            else if (boardState[6] == boardState[7] && boardState[7] == boardState[8] && !button6.Enabled)
            {
                return true;
            }
            else if (boardState[0] == boardState[3] && boardState[3] == boardState[6] && !button0.Enabled) //vert WinCons
            {
                return true;
            }
            else if (boardState[1] == boardState[4] && boardState[4] == boardState[7] && !button1.Enabled)
            {
                return true;
            }
            else if (boardState[2] == boardState[5] && boardState[5] == boardState[8] && !button2.Enabled)
            {
                return true;
            }
            else if (boardState[0] == boardState[4] && boardState[4] == boardState[8] && !button0.Enabled) //diag WinCons
            {
                return true;
            }
            else if (boardState[2] == boardState[4] && boardState[4] == boardState[6] && !button2.Enabled)
            {
                return true;
            }
            return false;

        }

        private bool checkForWinner(int[] board)
        {
            int[] boardState = board;
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
            }
            return false;
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
            Array.Clear(BoardState, 0, BoardState.Length);
            if (algorithmChange)
            {
                player_win_num.Text = "0";
                ai_win_num.Text = "0";
                draw_num.Text = "0";
                MessageBox.Show("All Values Reset", "Algorithm Changed");
            }
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

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Brennan Coslett\nmatrikelNum: k11944223\nFor JKU C#", "About");
        }

    }
}
