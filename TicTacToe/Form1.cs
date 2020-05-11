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
        int[] BoardState = new int[9];
        static readonly int[,] WinConditions = new int[8,3] {{0,1,2},{3,4,5},{6,7,8},{0,3,6},{1,4,7},{2,5,8},{0,4,8},{2,4,6}};
        int Turn_Count = 0;
        string Algorithm = "Minimax";
        bool AIFirstTurn = true;

        public Form1()
        {
            InitializeComponent();
            Algorithm_Val.Text = Algorithm;
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
            Turn_Count++;
            if (!GameFinished(BoardState))// also updates turn labels and if Winner resets board
            {
                AI_Turn(BoardState);
            }
        }

        private void AI_Turn(int[] boardState)
        {
            int[] CurrentBoardState = new int[9];
            for(int i = 0; i < CurrentBoardState.Length; i++)
            {
                CurrentBoardState[i] = boardState[i];
            }
            Button[] ListOfButtons = new Button[] { button0, button1, button2,
                button3, button4, button5, button6, button7, button8 };
            bool UseMinimax = Algorithm == "Minimax";
            int MoveIndex = -1;
            if (UseMinimax)
            {
                if (AIFirstTurn)
                {
                    MoveIndex = RandomNextMoveIndex(boardState);
                    AIFirstTurn = false;
                }
                else if (TwoOfThree(CurrentBoardState) != -1)
                {
                    MoveIndex = TwoOfThree(CurrentBoardState);
                }
                else
                {

                    float OptimalScore = float.MinValue;
                    float Score;
                    for (int i = 0; i < 9; i++)
                    {
                        if (CurrentBoardState[i] == 0)
                        {
                            CurrentBoardState[i] = 1;
                            Score = Minimax(CurrentBoardState, 0, false);
                            CurrentBoardState[i] = 0;
                            if (Score > OptimalScore)
                            {
                                OptimalScore = Score;
                                MoveIndex = i;
                            }
                        }
                    }
                }
            }
            else
            {
                MoveIndex = RandomNextMoveIndex(boardState);
            }
            UpdateAISpace(MoveIndex, ListOfButtons);
            GameFinished(boardState);
        }

        private void UpdateAISpace(int MoveIndex, Button[] ListOfButtons)
        {
            BoardState[MoveIndex] = 1;
            ListOfButtons[MoveIndex].Text = "O";
            ListOfButtons[MoveIndex].Enabled = false;
            Turn_Count++;
        }
        private float Minimax(int[] boardState, int depth, bool isMaxing)
        {
            int result = CheckWinState(boardState).Item1;
            if (result != 0)
            {
                return depth == 0 ? result : result / depth;
            }
            if (isMaxing)
            {
                float OptimalScore = float.MinValue;
                for (int i = 0; i < 9; i++)
                {
                    if (boardState[i] == 0)
                    {
                        boardState[i] = 1;
                        float Score = Minimax(boardState, depth + 1, false);
                        boardState[i] = 0;
                        OptimalScore = Math.Max(Score, OptimalScore);
                    }
                }
                return OptimalScore;
            }
            else
            {
                float OptimalScore = float.MaxValue;
                for (int i = 0; i < 9; i++)
                {
                    if (boardState[i] == 0)
                    {
                        boardState[i] = -1;
                        float Score = Minimax(boardState, depth + 1, true);
                        boardState[i] = 0;
                        OptimalScore = Math.Min(Score, OptimalScore);
                    }
                }
                return OptimalScore;
            }
        }

        private int RandomNextMoveIndex(int[] boardState)
        {
            Random rnd = new Random();
            List<int> ValidMoves = new List<int>();
            for (int i = 0; i < boardState.Length; i++)
            {
                if (boardState[i] == 0) { ValidMoves.Add(i); }
            }
            return ValidMoves.Count != 0 ? ValidMoves[rnd.Next(ValidMoves.Count)] : -1;
        }

        private (int, bool) CheckWinState(int[] boardState)
        {
            var Winner = (Value: 0, ButtonState: false);
            Button[] ListOfButtons = new Button[] { button0, button1, button2,
                button3, button4, button5, button6, button7, button8 };
            for (int i = 0; i < 8; i++)
            {
                if (boardState[WinConditions[i, 0]] == boardState[WinConditions[i,1]] 
                    && boardState[WinConditions[i,1]] == boardState[WinConditions[i,2]] && boardState[WinConditions[i, 2]] != 0)
                {
                    Winner.Value = boardState[WinConditions[i, 0]];
                    if (!ListOfButtons[i].Enabled)
                    {
                        Winner.ButtonState = true;
                    }
                }
            }
            return Winner;
        }

        private int TwoOfThree(int[] boardState)
        {
            int IndexOfZero = -1;
            for (int i = 0; i < 8; i++)
            {
                if (boardState[WinConditions[i, 0]] == -1 &&  boardState[WinConditions[i, 1]] == -1 && boardState[WinConditions[i, 1]] != 0)
                {
                    for (int j = 0; i < 3; i++)
                    {
                        if (boardState[WinConditions[i, j]] == 0) { IndexOfZero = WinConditions[i, j]; }
                    }
                }
                else if (boardState[WinConditions[i, 1]] == -1 && boardState[WinConditions[i, 2]] == -1 && boardState[WinConditions[i, 1]] != 0)
                {
                    for (int j = 0; i < 3; i++)
                    {
                        if (boardState[WinConditions[i, j]] == 0) { IndexOfZero = WinConditions[i, j]; }
                    }
                }
                else if (boardState[WinConditions[i, 2]] == -1 && boardState[WinConditions[i, 0]] == -1 && boardState[WinConditions[i, 2]] != 0)
                {
                    for (int j = 0; i < 3; i++)
                    {
                        if (boardState[WinConditions[i, j]] == 0) { IndexOfZero = WinConditions[i, j]; }
                    }
                }
                else if (boardState[WinConditions[i, 2]] == -1 && boardState[WinConditions[i, 0]] == -1 && boardState[WinConditions[i, 2]] != 0)
                {
                    for (int j = 0; i < 3; i++)
                    {
                        if (boardState[WinConditions[i, j]] == 0) { IndexOfZero = WinConditions[i, j]; }
                    }
                }
            }
            return IndexOfZero;
        }

        private bool GameFinished(int[] boardState)
        {
            var Winner = CheckWinState(boardState);

            if (Winner.Item1 != 0 && Winner.Item2 == true)
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
                if (Winner.Item1 == 1)
                {
                    ai_win_num.Text = ((Int32.Parse(ai_win_num.Text) + 1).ToString());
                    MessageBox.Show("AI Wins!", "Winner");

                }
                else if (Winner.Item1 == -1)
                {
                    player_win_num.Text = ((Int32.Parse(player_win_num.Text) + 1).ToString());
                    MessageBox.Show("Player Wins!", "Winner");

                }
                ResetGame();
                return true;
            }
            else if (Turn_Count == 9)
            {
                draw_num.Text = ((Int32.Parse(draw_num.Text) + 1).ToString());
                MessageBox.Show("No Winner", "Draw");
                ResetGame();
                return true;

            }
            return false;
        }

        private void ResetGame(bool AlgorithmChange = false)
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
            Turn_Count = 0;
            Array.Clear(BoardState, 0, BoardState.Length);
            if (AlgorithmChange)
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
                Algorithm = "Minimax";

            }
            else
            {
                Algorithm = "Random";
            }
            Algorithm_Val.Text = Algorithm;
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
