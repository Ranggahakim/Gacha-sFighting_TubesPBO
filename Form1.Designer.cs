namespace Gacha_sFighting
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            Player_HP = new Label();
            Enemy_HP = new Label();
            N1_Player = new Label();
            N2_Player = new Label();
            N3_Player = new Label();
            N4_Player = new Label();
            N4_Enemy = new Label();
            N3_Enemy = new Label();
            N2_Enemy = new Label();
            N1_Enemy = new Label();
            Roll_Button = new Button();
            PlayerChar = new Label();
            EnemyChar = new Label();
            PlayerNotif = new Label();
            EnemyNotif = new Label();
            PlayerResultText = new Label();
            EnemyResultText = new Label();
            AttackButton = new Button();
            HealButton = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(132, 65);
            label1.Name = "label1";
            label1.Size = new Size(53, 32);
            label1.TabIndex = 0;
            label1.Text = "You";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(428, 66);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 1;
            label2.Text = "Enemy";
            // 
            // Player_HP
            // 
            Player_HP.AutoSize = true;
            Player_HP.Location = new Point(132, 108);
            Player_HP.Name = "Player_HP";
            Player_HP.Size = new Size(57, 20);
            Player_HP.TabIndex = 2;
            Player_HP.Text = "HP : XX";
            Player_HP.Click += Player_HP_Click;
            // 
            // Enemy_HP
            // 
            Enemy_HP.AutoSize = true;
            Enemy_HP.Location = new Point(428, 109);
            Enemy_HP.Name = "Enemy_HP";
            Enemy_HP.Size = new Size(57, 20);
            Enemy_HP.TabIndex = 3;
            Enemy_HP.Text = "HP : XX";
            Enemy_HP.Click += label3_Click;
            // 
            // N1_Player
            // 
            N1_Player.AutoSize = true;
            N1_Player.Location = new Point(132, 312);
            N1_Player.Name = "N1_Player";
            N1_Player.Size = new Size(18, 20);
            N1_Player.TabIndex = 4;
            N1_Player.Text = "X";
            N1_Player.Click += N1_Player_Click;
            // 
            // N2_Player
            // 
            N2_Player.AutoSize = true;
            N2_Player.Location = new Point(156, 312);
            N2_Player.Name = "N2_Player";
            N2_Player.Size = new Size(18, 20);
            N2_Player.TabIndex = 5;
            N2_Player.Text = "X";
            // 
            // N3_Player
            // 
            N3_Player.AutoSize = true;
            N3_Player.Location = new Point(180, 312);
            N3_Player.Name = "N3_Player";
            N3_Player.Size = new Size(18, 20);
            N3_Player.TabIndex = 6;
            N3_Player.Text = "X";
            // 
            // N4_Player
            // 
            N4_Player.AutoSize = true;
            N4_Player.Location = new Point(204, 312);
            N4_Player.Name = "N4_Player";
            N4_Player.Size = new Size(18, 20);
            N4_Player.TabIndex = 7;
            N4_Player.Text = "X";
            // 
            // N4_Enemy
            // 
            N4_Enemy.AutoSize = true;
            N4_Enemy.Location = new Point(496, 313);
            N4_Enemy.Name = "N4_Enemy";
            N4_Enemy.Size = new Size(18, 20);
            N4_Enemy.TabIndex = 11;
            N4_Enemy.Text = "X";
            // 
            // N3_Enemy
            // 
            N3_Enemy.AutoSize = true;
            N3_Enemy.Location = new Point(472, 313);
            N3_Enemy.Name = "N3_Enemy";
            N3_Enemy.Size = new Size(18, 20);
            N3_Enemy.TabIndex = 10;
            N3_Enemy.Text = "X";
            // 
            // N2_Enemy
            // 
            N2_Enemy.AutoSize = true;
            N2_Enemy.Location = new Point(448, 313);
            N2_Enemy.Name = "N2_Enemy";
            N2_Enemy.Size = new Size(18, 20);
            N2_Enemy.TabIndex = 9;
            N2_Enemy.Text = "X";
            // 
            // N1_Enemy
            // 
            N1_Enemy.AutoSize = true;
            N1_Enemy.Location = new Point(424, 313);
            N1_Enemy.Name = "N1_Enemy";
            N1_Enemy.Size = new Size(18, 20);
            N1_Enemy.TabIndex = 8;
            N1_Enemy.Text = "X";
            // 
            // Roll_Button
            // 
            Roll_Button.Font = new Font("Segoe UI", 14F);
            Roll_Button.Location = new Point(278, 347);
            Roll_Button.Name = "Roll_Button";
            Roll_Button.Size = new Size(96, 51);
            Roll_Button.TabIndex = 12;
            Roll_Button.Text = "Roll";
            Roll_Button.UseVisualStyleBackColor = true;
            Roll_Button.Click += Roll_Button_Click;
            // 
            // PlayerChar
            // 
            PlayerChar.AutoSize = true;
            PlayerChar.Font = new Font("Segoe UI", 14F);
            PlayerChar.Location = new Point(132, 183);
            PlayerChar.Name = "PlayerChar";
            PlayerChar.Size = new Size(53, 32);
            PlayerChar.TabIndex = 13;
            PlayerChar.Text = "You";
            // 
            // EnemyChar
            // 
            EnemyChar.AutoSize = true;
            EnemyChar.Font = new Font("Segoe UI", 14F);
            EnemyChar.Location = new Point(428, 184);
            EnemyChar.Name = "EnemyChar";
            EnemyChar.Size = new Size(53, 32);
            EnemyChar.TabIndex = 14;
            EnemyChar.Text = "You";
            // 
            // PlayerNotif
            // 
            PlayerNotif.AutoSize = true;
            PlayerNotif.Font = new Font("Segoe UI", 24F);
            PlayerNotif.Location = new Point(132, 129);
            PlayerNotif.Name = "PlayerNotif";
            PlayerNotif.Size = new Size(94, 54);
            PlayerNotif.TabIndex = 15;
            PlayerNotif.Text = "- 50";
            // 
            // EnemyNotif
            // 
            EnemyNotif.AutoSize = true;
            EnemyNotif.Font = new Font("Segoe UI", 24F);
            EnemyNotif.Location = new Point(428, 129);
            EnemyNotif.Name = "EnemyNotif";
            EnemyNotif.Size = new Size(94, 54);
            EnemyNotif.TabIndex = 16;
            EnemyNotif.Text = "- 50";
            // 
            // PlayerResultText
            // 
            PlayerResultText.AutoSize = true;
            PlayerResultText.Font = new Font("Segoe UI", 12F);
            PlayerResultText.Location = new Point(132, 261);
            PlayerResultText.Name = "PlayerResultText";
            PlayerResultText.Size = new Size(23, 28);
            PlayerResultText.TabIndex = 17;
            PlayerResultText.Text = "2";
            // 
            // EnemyResultText
            // 
            EnemyResultText.AutoSize = true;
            EnemyResultText.Font = new Font("Segoe UI", 12F);
            EnemyResultText.Location = new Point(428, 262);
            EnemyResultText.Name = "EnemyResultText";
            EnemyResultText.Size = new Size(23, 28);
            EnemyResultText.TabIndex = 18;
            EnemyResultText.Text = "2";
            // 
            // AttackButton
            // 
            AttackButton.Location = new Point(278, 205);
            AttackButton.Name = "AttackButton";
            AttackButton.Size = new Size(94, 29);
            AttackButton.TabIndex = 19;
            AttackButton.Text = "Attack >>";
            AttackButton.UseVisualStyleBackColor = true;
            AttackButton.Click += AttackButton_Click;
            // 
            // HealButton
            // 
            HealButton.Location = new Point(277, 244);
            HealButton.Name = "HealButton";
            HealButton.Size = new Size(94, 29);
            HealButton.TabIndex = 20;
            HealButton.Text = "<< Heal";
            HealButton.UseVisualStyleBackColor = true;
            HealButton.Click += HealButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 22;
            backButton.Text = "<< back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 516);
            Controls.Add(backButton);
            Controls.Add(HealButton);
            Controls.Add(AttackButton);
            Controls.Add(EnemyResultText);
            Controls.Add(PlayerResultText);
            Controls.Add(EnemyNotif);
            Controls.Add(PlayerNotif);
            Controls.Add(EnemyChar);
            Controls.Add(PlayerChar);
            Controls.Add(Roll_Button);
            Controls.Add(N4_Enemy);
            Controls.Add(N3_Enemy);
            Controls.Add(N2_Enemy);
            Controls.Add(N1_Enemy);
            Controls.Add(N4_Player);
            Controls.Add(N3_Player);
            Controls.Add(N2_Player);
            Controls.Add(N1_Player);
            Controls.Add(Enemy_HP);
            Controls.Add(Player_HP);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label Player_HP;
        private Label Enemy_HP;
        private Label N1_Player;
        private Label N2_Player;
        private Label N3_Player;
        private Label N4_Player;
        private Label N4_Enemy;
        private Label N3_Enemy;
        private Label N2_Enemy;
        private Label N1_Enemy;
        private Button Roll_Button;
        private Label PlayerChar;
        private Label EnemyChar;
        private Label PlayerNotif;
        private Label EnemyNotif;
        private Label PlayerResultText;
        private Label EnemyResultText;
        private Button AttackButton;
        private Button HealButton;
        private Button backButton;
    }
}
