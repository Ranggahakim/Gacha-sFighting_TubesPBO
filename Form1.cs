using System.Numerics;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gacha_sFighting
{
    public partial class Form1 : Form
    {
        int[] np = new int[4];

        int[] ne = new int[4];

        private Character Player, Enemy;
        public Form1()
        {
            InitializeComponent();

            SpawnActors();

            Start();
        }

        private void SpawnActors()
        {
            switch (GameData.SelectedCharacter)
            {
                case "Assassin":
                    Player = new Assassin();
                    break;
                case "Normal Guy":
                    Player = new NormalGuy();
                    break;
                case "Tank":
                    Player = new Tank();
                    break;
                default:
                    Console.WriteLine("Karakter tidak valid.");
                    break;
            }

            switch (GameData.Enemy)
            {
                case "Assassin":
                    Enemy = new Assassin();
                    break;
                case "Normal Guy":
                    Enemy = new NormalGuy();
                    break;
                case "Tank":
                    Enemy = new Tank();
                    break;
                default:
                    Console.WriteLine("Karakter tidak valid.");
                    break;
            }

            PlayerChar.Text = GameData.SelectedCharacter;
            EnemyChar.Text = GameData.Enemy;

            Player_HP.Text = "HP : " + Player.HP.ToString();
            Enemy_HP.Text = "HP : " + Enemy.HP.ToString();
        }

        private async void Start()
        {
            PlayerNotif.Visible = false;
            EnemyNotif.Visible = false;

            Roll_Button.Enabled = false;

            AttackButton.Visible = false;
            HealButton.Visible = false;

            ResetText();

            await Task.Delay(1500);

            GameplayLoop();
        }

        private void Player_HP_Click(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Roll_Button_Click(object sender, EventArgs e)
        {
            PressRoll();
        }

        private async void GameplayLoop()
        {
            switch (WinOrLose())
            {
                case "enemyWin":
                    Finish(false);
                    break;
                case "playerWin":
                    Finish(true);
                    break;
                case "false":
                    ResetText();

                    Roll_Button.Enabled = false;

                    await Task.Delay(1000);

                    EnemyRoll();

                    await Task.Delay(500);

                    Roll_Button.Enabled = true;

                    break;
                default:
                    break;
            }
        }

        void Finish(bool win)
        {
            ResultMenu resultMenu = new ResultMenu();
            if (win)
            {
                resultMenu.ResultTextValue = "You Win";
            }
            else
            {
                resultMenu.ResultTextValue = "You Lose";
            }

            resultMenu.Show();

            this.Hide();
        }

        private string WinOrLose()
        {
            if (Player.HP <= 0)
            {
                return "enemyWin";

            }
            else if (Enemy.HP <= 0)
            {
                return "playerWin";
            }
            else
            {
                return "false";
            }
        }

        private void ResetText()
        {
            N1_Player.Text = "X";
            N2_Player.Text = "X";
            N3_Player.Text = "X";
            N4_Player.Text = "X";

            N1_Enemy.Text = "X";
            N2_Enemy.Text = "X";
            N3_Enemy.Text = "X";
            N4_Enemy.Text = "X";

            PlayerResultText.Visible = false;
            EnemyResultText.Visible = false;
        }

        private async void CompareNumbers()
        {
            int playerResult = np.GroupBy(n => n).Max(g => g.Count());
            int enemyResult = ne.GroupBy(n => n).Max(g => g.Count());

            PlayerResultText.Visible = true;
            EnemyResultText.Visible = true;

            PlayerResultText.Text = playerResult.ToString();
            EnemyResultText.Text = enemyResult.ToString();

            if (playerResult > enemyResult)
            {
                AttackButton.Visible = true;
                HealButton.Visible = true;

                Roll_Button.Visible = false;
            }
            else if (enemyResult > playerResult)
            {
                switch (Enemy.DoAction())
                {
                    case "Attack":
                        Enemy.Attack(Player);
                        PlayerNotif.Visible = true;

                        PlayerNotif.ForeColor = Color.Red;
                        PlayerNotif.Text = "-" + Enemy.AtkDamage;

                        await Task.Delay(350);

                        Player_HP.Text = "HP : " + Player.HP.ToString();
                        PlayerNotif.Visible = false;

                        await Task.Delay(500);
                        GameplayLoop();

                        break;
                    case "Heal":
                        Enemy.Heal();

                        EnemyNotif.Visible = true;
                        EnemyNotif.ForeColor = Color.Green;
                        EnemyNotif.Text = "+" + Enemy.HealAmount;

                        await Task.Delay(350);

                        Enemy_HP.Text = "HP : " + Enemy.HP.ToString();
                        EnemyNotif.Visible = false;

                        await Task.Delay(500);
                        GameplayLoop();

                        break;
                    default:
                        break;
                }
            }
            else
            {
                await Task.Delay(500);
                GameplayLoop();
            }
        }

        private async void PlayerDoAction(string value)
        {
            switch (value)
            {
                case "Attack":
                    Player.Attack(Enemy);

                    EnemyNotif.ForeColor = Color.Red;
                    EnemyNotif.Visible = true;
                    EnemyNotif.Text = "-" + Player.AtkDamage;

                    await Task.Delay(350);

                    Enemy_HP.Text = "HP : " + Enemy.HP.ToString();
                    EnemyNotif.Visible = false;

                    break;
                case "Heal":
                    Player.Heal();

                    PlayerNotif.ForeColor = Color.Green;
                    PlayerNotif.Visible = true;
                    PlayerNotif.Text = "+" + Player.HealAmount;

                    await Task.Delay(350);

                    Player_HP.Text = "HP : " + Player.HP.ToString();
                    PlayerNotif.Visible = false;

                    break;
                default:
                    break;
            }
            AttackButton.Visible = false;
            HealButton.Visible = false;

            Roll_Button.Visible = true;

            await Task.Delay(500);
            GameplayLoop();
        }

        private async void EnemyRoll()
        {
            N1_Enemy.Text = "X";
            N2_Enemy.Text = "X";
            N3_Enemy.Text = "X";
            N4_Enemy.Text = "X";

            Roll_Button.Enabled = false;

            ne[0] = RollFunction(N1_Enemy);
            await Task.Delay(250);

            ne[1] = RollFunction(N2_Enemy);
            await Task.Delay(250);

            ne[2] = RollFunction(N3_Enemy);
            await Task.Delay(250);

            ne[3] = RollFunction(N4_Enemy);
            await Task.Delay(250);
        }


        private async void PressRoll()
        {
            N1_Player.Text = "X";
            N2_Player.Text = "X";
            N3_Player.Text = "X";
            N4_Player.Text = "X";


            await Task.Delay(100);

            Roll_Button.Enabled = false;

            np[0] = RollFunction(N1_Player);
            await Task.Delay(250);

            np[1] = RollFunction(N2_Player);
            await Task.Delay(250);

            np[2] = RollFunction(N3_Player);
            await Task.Delay(250);

            np[3] = RollFunction(N4_Player);
            await Task.Delay(250);

            Roll_Button.Enabled = false;

            await Task.Delay(500);

            CompareNumbers();
        }

        private int RollFunction(Label myLabel)
        {
            Random rnd = new Random();

            int number = rnd.Next(1, 8);

            myLabel.Text = Convert.ToString(number);

            return number;
        }

        private void N1_Player_Click(object sender, EventArgs e)
        {

        }

        private void AttackButton_Click(object sender, EventArgs e)
        {
            PlayerDoAction("Attack");
        }

        private void HealButton_Click(object sender, EventArgs e)
        {
            PlayerDoAction("Heal");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();

            this.Hide();
        }
    }
}