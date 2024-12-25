namespace Gacha_sFighting
{
    partial class SelectCharacterMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            CharacterText = new Label();
            backButton = new Button();
            AssassinButton = new Button();
            NormalGuyButton = new Button();
            TankButton = new Button();
            StartButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(299, 59);
            label1.Name = "label1";
            label1.Size = new Size(179, 50);
            label1.TabIndex = 0;
            label1.Text = "Character";
            // 
            // CharacterText
            // 
            CharacterText.AutoSize = true;
            CharacterText.Font = new Font("Segoe UI", 18F);
            CharacterText.Location = new Point(239, 109);
            CharacterText.Name = "CharacterText";
            CharacterText.Size = new Size(333, 41);
            CharacterText.TabIndex = 1;
            CharacterText.Text = "You've not selected yet!";
            CharacterText.TextAlign = ContentAlignment.MiddleCenter;
            CharacterText.Click += CharacterText_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 2;
            backButton.Text = "<< back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // AssassinButton
            // 
            AssassinButton.Location = new Point(136, 238);
            AssassinButton.Name = "AssassinButton";
            AssassinButton.Size = new Size(94, 29);
            AssassinButton.TabIndex = 3;
            AssassinButton.Text = "Assassin";
            AssassinButton.UseVisualStyleBackColor = true;
            AssassinButton.Click += AssassinButton_Click;
            // 
            // NormalGuyButton
            // 
            NormalGuyButton.Location = new Point(312, 238);
            NormalGuyButton.Name = "NormalGuyButton";
            NormalGuyButton.Size = new Size(142, 29);
            NormalGuyButton.TabIndex = 4;
            NormalGuyButton.Text = "Normal Guy";
            NormalGuyButton.UseVisualStyleBackColor = true;
            NormalGuyButton.Click += NormalGuyButton_Click;
            // 
            // TankButton
            // 
            TankButton.Location = new Point(519, 238);
            TankButton.Name = "TankButton";
            TankButton.Size = new Size(142, 29);
            TankButton.TabIndex = 5;
            TankButton.Text = "Tank";
            TankButton.UseVisualStyleBackColor = true;
            TankButton.Click += TankButton_Click;
            // 
            // StartButton
            // 
            StartButton.Font = new Font("Segoe UI", 14F);
            StartButton.Location = new Point(312, 330);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(142, 57);
            StartButton.TabIndex = 6;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // SelectCharacterMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StartButton);
            Controls.Add(TankButton);
            Controls.Add(NormalGuyButton);
            Controls.Add(AssassinButton);
            Controls.Add(backButton);
            Controls.Add(CharacterText);
            Controls.Add(label1);
            Name = "SelectCharacterMenu";
            Text = "SelectCharacterMenu";
            Load += SelectCharacterMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label CharacterText;
        private Button backButton;
        private Button AssassinButton;
        private Button NormalGuyButton;
        private Button TankButton;
        private Button StartButton;
    }
}