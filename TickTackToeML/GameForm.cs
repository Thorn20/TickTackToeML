using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickTackToeML
{
    public partial class GameForm : Form
    {
        public Label[] Cells;

        char WhosTurn;

        public GameForm()
        {
            InitializeComponent();           
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            btn_Play.Visible = false;
            StartGame();
        }

        void StartGame()
        {
            InitializeCells();

            WhosTurn = 'X';
        }

        void PlayTurn(Label cell)
        {
            switch (WhosTurn)
            {
                case 'X':
                    cell.Text = "X";
                    cell.ForeColor = Color.Red;
                    WhosTurn = 'O';
                    break;

                case 'O':
                    cell.Text = "O";
                    cell.ForeColor = Color.Blue;
                    WhosTurn = 'X';
                    break;
            }

            CheckGameEnd();
        }

        void CheckGameEnd()
        {
            //Check for winner
            bool IsWinner = false;
            char Winner = ' ';

            List<string[]> WinningLines = new List<string[]>();
            //horizontal
            WinningLines.Add(new string[] { lbl_TL.Text, lbl_TC.Text, lbl_TR.Text });
            WinningLines.Add(new string[] { lbl_ML.Text, lbl_MC.Text, lbl_MR.Text });
            WinningLines.Add(new string[] { lbl_BL.Text, lbl_BC.Text, lbl_BR.Text });
            //vertical
            WinningLines.Add(new string[] { lbl_TL.Text, lbl_ML.Text, lbl_BL.Text });
            WinningLines.Add(new string[] { lbl_TC.Text, lbl_MC.Text, lbl_BC.Text });
            WinningLines.Add(new string[] { lbl_TR.Text, lbl_MR.Text, lbl_BR.Text });
            //diagonal
            WinningLines.Add(new string[] { lbl_TL.Text, lbl_MC.Text, lbl_BR.Text });
            WinningLines.Add(new string[] { lbl_BL.Text, lbl_MC.Text, lbl_TR.Text });

            //Check if winning lines exist
            foreach(string[] line in WinningLines)
                if (!line[0].Equals(" ") && line[0].Equals(line[1]) && line[1].Equals(line[2]))
                {
                    IsWinner = true;
                    Winner = line[0].ToCharArray()[0];
                    break;
                }

            //Check for board full Condition
            bool NoMoreMoves = true;

            foreach (Label cell in Cells)
                if (cell.Text.Equals(" "))
                {
                    NoMoreMoves = false;
                    break;
                }
            
            //Check if game Ended
            if( IsWinner || NoMoreMoves)
            {
                if (IsWinner) MessageBox.Show("Winner is " + Winner);
                else MessageBox.Show("Draw");

                grpBox_Board.Visible = false;

                btn_Play.Visible = true;
            }
        }

        #region Cell Handling Methods
        void InitializeCells()
        {
            Cells = new Label[9];

            Cells[0] = lbl_TL;
            Cells[1] = lbl_TC;
            Cells[2] = lbl_TR;
            Cells[3] = lbl_ML;
            Cells[4] = lbl_MC;
            Cells[5] = lbl_MR;
            Cells[6] = lbl_BL;
            Cells[7] = lbl_BC;
            Cells[8] = lbl_BR;

            ClearCells();

            grpBox_Board.Visible = true;
        }
        void ClearCells()
        {
            foreach (Label Cell in Cells)
            {
                Cell.Text = " ";
                Cell.ForeColor = Color.Black;
            }
        }

        private void CellClicked(object sender, EventArgs e)
        {
            Label clicked = null;

            foreach (Label cell in Cells)
            {
                if (cell.Equals(sender))
                {
                    clicked = cell;
                    break;
                }
            }

            if (clicked.Text.Equals(" "))
                PlayTurn(clicked);
        }
        #endregion
    }
}
