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
    public partial class Board : Form
    {
        // States 0 = default 1 = computer 2 = player
        int[] BoardState = {0, 0, 0, 0, 0, 0, 0, 0, 0};
        enum Winner {Player, Computer, None};
        public Board()
        {
            InitializeComponent();
        }

        private void Board_Load(object sender, EventArgs e)
        {
            
        }

        private void Computer_Turn()
        {
            if (Valid_Win(BoardState) != -1)
            {
                int[] nextBoardState = MinMax();
                BoardState = nextBoardState;
            }
            else
            {
                if (Valid_Win(BoardState) == 1)
                {
                    //display Computer win Screen
                }
                else
                { 
                    //display Player win Screen
                }
            }
        }
        private int[] MinMax()
        {
            int[] nextState = null;
            //calculate open board positions recursively
            foreach (int x in BoardState) {
                if (x == 0) { }
            }
            //weigh and determine best option
            //calculate nextState
            return nextState;
        }
        private int Valid_Win(int[] boardState) 
        {
            if (boardState[0] == boardState[1] && boardState[1] == boardState[2])//horizontal WinCons
            {
                return boardState[0];
            } else if (boardState[3] == boardState[4] && boardState[4] == boardState[5])
            {
                return boardState[3];
            } else if (boardState[6] == boardState[7] && boardState[7] == boardState[8])
            {
                return boardState[6];
            }
            else if (boardState[0] == boardState[3] && boardState[3] == boardState[6]) //vert WinCons
            {
                return boardState[0];
            }
            else if (boardState[1] == boardState[4] && boardState[4] == boardState[7])
            {
                return boardState[1];
            }
            else if (boardState[2] == boardState[5] && boardState[5] == boardState[8])
            {
                return boardState[2];
            }else if (boardState[0] == boardState[4] && boardState[4] == boardState[8]) //diag WinCons
            {
                return boardState[0];
            }else if (boardState[2] == boardState[4] && boardState[4] == boardState[6])
            {
                return boardState[2];
            }
            return -1;
        }
    }
}
