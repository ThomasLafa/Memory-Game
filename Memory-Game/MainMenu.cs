using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class MainMenu : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();

        public MainMenu()
        {
            InitializeComponent();
            player.Stream = Properties.Resources.GoT1;
            player.Play();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Hide();
            player2.Stream = Properties.Resources.Play_sound;
            player2.Play();
            TestGame testgameform = new TestGame();
            testgameform.ShowDialog();
            Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void QuiteGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
