using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gacha_sFighting
{
    public partial class SelectCharacterMenu : Form
    {
        public SelectCharacterMenu()
        {
            InitializeComponent();

            StartButton.Enabled = false;
        }

        private void AssassinButton_Click(object sender, EventArgs e)
        {
            GameData.SelectedCharacter = "Assassin";
            CharacterText.Text = GameData.SelectedCharacter;

            StartButton.Enabled = true;
        }

        private void NormalGuyButton_Click(object sender, EventArgs e)
        {
            GameData.SelectedCharacter = "Normal Guy";
            CharacterText.Text = GameData.SelectedCharacter;

            StartButton.Enabled = true;
        }

        private void TankButton_Click(object sender, EventArgs e)
        {
            GameData.SelectedCharacter = "Tank";
            CharacterText.Text = GameData.SelectedCharacter;

            StartButton.Enabled = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();

            this.Hide();
        }

        private void CharacterText_Click(object sender, EventArgs e)
        {

        }

        private void SelectCharacterMenu_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int enemyNumber = rnd.Next(0, 3);

            switch(enemyNumber)
            {
                case 0:
                    GameData.Enemy = "Assassin";
                    break;
                case 1:
                    GameData.Enemy = "Normal Guy";
                    break;
                case 2:
                    GameData.Enemy = "Tank";
                    break;
                default:
                    GameData.Enemy = "NormalGuy";
                    break;
            }

            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }
    }
}
