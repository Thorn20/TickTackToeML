using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TickTackToeML.Game;

namespace TickTackToeML
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();           
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            PlayerSelectMenu PSMenu = new PlayerSelectMenu();
            PSMenu.ShowDialog();

            if (PSMenu.DialogResult == DialogResult.OK)
            {
                this.Hide();

                GameForm game = new GameForm( Player.Copy(PSMenu.PlayerList[PSMenu.cboBox_Player1Selection.SelectedIndex]),
                                              Player.Copy(PSMenu.PlayerList[PSMenu.cboBox_Player2Selection.SelectedIndex]));

                game.ShowDialog();

                this.Show();
            }
        }
    }
}
