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
    public partial class PlayerSelectMenu : Form
    {
        public List<Player> PlayerList;
        public PlayerSelectMenu()
        {
            InitializeComponent();

            LoadPlayerList();
        }

        private void LoadPlayerList()
        {
            PlayerList = new List<Player>();

            PlayerList.Add(new Player());
            PlayerList.Add(new Player("AI Test", false));

            cboBox_Player1Selection.Items.AddRange(PlayerList.ToArray());
            cboBox_Player1Selection.SelectedIndex = 0;

            cboBox_Player2Selection.Items.AddRange(PlayerList.ToArray());
            cboBox_Player2Selection.SelectedIndex = 0;
        }
    }
}
