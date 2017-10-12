using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class TestGame : Memory_Game.MainMenu
    {
        public TestGame()
        {
            InitializeComponent();
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainmenuform = new MainMenu();
            mainmenuform.ShowDialog();
            Close();
        }
    }
}
