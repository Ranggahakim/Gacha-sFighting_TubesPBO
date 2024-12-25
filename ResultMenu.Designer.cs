namespace Gacha_sFighting
{
    partial class ResultMenu
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
            ResultText = new Label();
            RetryButton = new Button();
            MainMenuButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // ResultText
            // 
            ResultText.AutoSize = true;
            ResultText.Font = new Font("Segoe UI", 48F);
            ResultText.Location = new Point(239, 43);
            ResultText.Name = "ResultText";
            ResultText.Size = new Size(360, 106);
            ResultText.TabIndex = 0;
            ResultText.Text = "You Won";
            // 
            // RetryButton
            // 
            RetryButton.Location = new Point(353, 211);
            RetryButton.Name = "RetryButton";
            RetryButton.Size = new Size(94, 29);
            RetryButton.TabIndex = 1;
            RetryButton.Text = "Retry";
            RetryButton.UseVisualStyleBackColor = true;
            RetryButton.Click += RetryButton_Click;
            // 
            // MainMenuButton
            // 
            MainMenuButton.Location = new Point(353, 257);
            MainMenuButton.Name = "MainMenuButton";
            MainMenuButton.Size = new Size(94, 29);
            MainMenuButton.TabIndex = 2;
            MainMenuButton.Text = "Main Menu";
            MainMenuButton.UseVisualStyleBackColor = true;
            MainMenuButton.Click += MainMenuButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(353, 305);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ResultMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(MainMenuButton);
            Controls.Add(RetryButton);
            Controls.Add(ResultText);
            Name = "ResultMenu";
            Text = "ResultMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ResultText;
        private Button RetryButton;
        private Button MainMenuButton;
        private Button ExitButton;
    }
}