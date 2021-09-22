using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickTackToeML.Game
{
    public partial class GameForm : Form
    {
        Player CurrentPlayer;
        Player Player1;
        Player Player2;

        Label[] Cells;

        public GameForm( Player player1, Player player2)
        {           
            InitializeComponent();

            LoadPlayers(player1, player2);

            LoadCells();

            FirstTurn();
        }

        private void LoadPlayers( Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;

            Player1.Name = "Player 1";
            Player2.Name = "Player 2";
        }

        private void LoadCells()
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

            foreach (Label Cell in Cells)
                Cell.Text = " ";
        }

        private void FirstTurn()
        {
            Random coin = new Random();

            int flip = coin.Next(2);

            switch (flip)
            {
                case 0:
                    Player1.Symbol = "X";
                    Player2.Symbol = "O";
                    CurrentPlayer = Player1;
                    break;

                case 1:
                    Player1.Symbol = "O";
                    Player2.Symbol = "X";
                    CurrentPlayer = Player2;
                    break;
            }

            lbl_Turn.Text = CurrentPlayer.ToString() + " Turn";

            if (!CurrentPlayer.IsHuman)
                AiTurn();
        }

        private void NextTurn()
        {
            CheckGameEnd();

            if (CurrentPlayer == Player1)
                CurrentPlayer = Player2;
            else if (CurrentPlayer == Player2)
                CurrentPlayer = Player1;

            lbl_Turn.Text = CurrentPlayer.ToString() + " Turn";

            if (!CurrentPlayer.IsHuman)
                AiTurn();
        }

        private void AiTurn()
        {
            NextTurn();
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            Label clicked = (Label)sender;

            if (clicked.Text.Equals(" ") && CurrentPlayer.IsHuman)
            {
                clicked.Text = CurrentPlayer.Symbol;
                NextTurn();
            }            
        }

        private void CheckGameEnd()
        {
            bool GameEnd = false;
            
            //Check for winning line combo
            bool won = false;
            int i;
            //Horizontal lines
            for (i = 0; i < Cells.Length; i += 3)
                if (!Cells[i].Text.Equals(" ") && StringsAreEqual(Cells[i].Text, Cells[i + 1].Text, Cells[i + 2].Text))
                    won = true;
            //Vertical lines
            for (i = 0; i < Cells.Length / 3; i++)
                if (!Cells[i].Text.Equals(" ") && StringsAreEqual(Cells[i].Text, Cells[i + 3].Text, Cells[i + 6].Text))
                    won = true;
            //Top Right Diagonal
            i = 0;
            if (!Cells[i].Text.Equals(" ") && StringsAreEqual(Cells[i].Text, Cells[i + 4].Text, Cells[i + 8].Text))
                won = true;
            //Top Left Diagonal
            i = 2;
            if (!Cells[i].Text.Equals(" ") && StringsAreEqual(Cells[i].Text, Cells[i + 2].Text, Cells[i + 4].Text))
                won = true;

            GameEnd = won;

            //if no winner check for full board
            if (!won)
            {
                bool fullBoard = true;
                foreach (Label cell in Cells)
                    if (cell.Text.Equals(" "))
                        fullBoard = false;

                GameEnd = fullBoard;
            }

            //Check game end
            if(GameEnd)
            {
                //check for win
                if (won)
                    MessageBox.Show("The Winner is\n" + CurrentPlayer);
                else
                    MessageBox.Show("Draw");

                DialogResult = DialogResult.OK;
            }
        }

        private bool StringsAreEqual( string strA, string strB, string strC)
        {
            bool Equal = false;

            if (strA.Equals(strB) && strB.Equals(strC))
                Equal = true;

            return Equal;
        }
    }
}
