namespace Snake
{
    partial class snakeApplication
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameFieldPanel = new System.Windows.Forms.Panel();
            this.saveNicknameButton = new System.Windows.Forms.Button();
            this.inputNicknameTextBox = new System.Windows.Forms.TextBox();
            this.congratulationsLabel = new System.Windows.Forms.Label();
            this.alertTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameStartButton = new System.Windows.Forms.Button();
            this.controlButton = new System.Windows.Forms.Button();
            this.leaderboardButton = new System.Windows.Forms.Button();
            this.gameDifficultChangeButton = new System.Windows.Forms.Button();
            this.easyDiffButton = new System.Windows.Forms.Button();
            this.normalDiffButton = new System.Windows.Forms.Button();
            this.hardDiffButton = new System.Windows.Forms.Button();
            this.scoreTitleLabel = new System.Windows.Forms.Label();
            this.currentScoreLabel = new System.Windows.Forms.Label();
            this.gameFieldPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameFieldPanel
            // 
            this.gameFieldPanel.BackColor = System.Drawing.SystemColors.Info;
            this.gameFieldPanel.Controls.Add(this.saveNicknameButton);
            this.gameFieldPanel.Controls.Add(this.inputNicknameTextBox);
            this.gameFieldPanel.Controls.Add(this.congratulationsLabel);
            this.gameFieldPanel.Controls.Add(this.alertTextBox);
            this.gameFieldPanel.Location = new System.Drawing.Point(12, 12);
            this.gameFieldPanel.Name = "gameFieldPanel";
            this.gameFieldPanel.Size = new System.Drawing.Size(502, 502);
            this.gameFieldPanel.TabIndex = 0;
            // 
            // saveNicknameButton
            // 
            this.saveNicknameButton.Location = new System.Drawing.Point(226, 373);
            this.saveNicknameButton.Name = "saveNicknameButton";
            this.saveNicknameButton.Size = new System.Drawing.Size(75, 23);
            this.saveNicknameButton.TabIndex = 3;
            this.saveNicknameButton.Text = "Сохранить";
            this.saveNicknameButton.UseVisualStyleBackColor = true;
            this.saveNicknameButton.Visible = false;
            this.saveNicknameButton.Click += new System.EventHandler(this.SaveNicknameButton_Click);
            // 
            // inputNicknameTextBox
            // 
            this.inputNicknameTextBox.Location = new System.Drawing.Point(185, 333);
            this.inputNicknameTextBox.Name = "inputNicknameTextBox";
            this.inputNicknameTextBox.Size = new System.Drawing.Size(156, 20);
            this.inputNicknameTextBox.TabIndex = 2;
            this.inputNicknameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputNicknameTextBox.Visible = false;
            // 
            // congratulationsLabel
            // 
            this.congratulationsLabel.AutoSize = true;
            this.congratulationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.congratulationsLabel.Location = new System.Drawing.Point(121, 275);
            this.congratulationsLabel.Name = "congratulationsLabel";
            this.congratulationsLabel.Size = new System.Drawing.Size(296, 36);
            this.congratulationsLabel.TabIndex = 1;
            this.congratulationsLabel.Text = "Вы попали в топ-10 лучших игроков.\r\nВведите Ваш никнейм:";
            this.congratulationsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.congratulationsLabel.Visible = false;
            // 
            // alertTextBox
            // 
            this.alertTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alertTextBox.Location = new System.Drawing.Point(185, 225);
            this.alertTextBox.Name = "alertTextBox";
            this.alertTextBox.ReadOnly = true;
            this.alertTextBox.Size = new System.Drawing.Size(156, 29);
            this.alertTextBox.TabIndex = 4;
            this.alertTextBox.Text = "Игра окончена";
            this.alertTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alertTextBox.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // gameStartButton
            // 
            this.gameStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameStartButton.Location = new System.Drawing.Point(536, 12);
            this.gameStartButton.Name = "gameStartButton";
            this.gameStartButton.Size = new System.Drawing.Size(150, 65);
            this.gameStartButton.TabIndex = 0;
            this.gameStartButton.Text = "Новая игра";
            this.gameStartButton.UseVisualStyleBackColor = true;
            this.gameStartButton.Click += new System.EventHandler(this.GameStartButton_Click);
            // 
            // controlButton
            // 
            this.controlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.controlButton.Location = new System.Drawing.Point(536, 154);
            this.controlButton.Name = "controlButton";
            this.controlButton.Size = new System.Drawing.Size(150, 65);
            this.controlButton.TabIndex = 7;
            this.controlButton.Text = "Управление";
            this.controlButton.UseVisualStyleBackColor = true;
            this.controlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // leaderboardButton
            // 
            this.leaderboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leaderboardButton.Location = new System.Drawing.Point(536, 225);
            this.leaderboardButton.Name = "leaderboardButton";
            this.leaderboardButton.Size = new System.Drawing.Size(150, 65);
            this.leaderboardButton.TabIndex = 6;
            this.leaderboardButton.Text = "Таблица лидеров";
            this.leaderboardButton.UseVisualStyleBackColor = true;
            this.leaderboardButton.Click += new System.EventHandler(this.LeaderboardButton_Click);
            // 
            // gameDifficultChangeButton
            // 
            this.gameDifficultChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameDifficultChangeButton.Location = new System.Drawing.Point(536, 83);
            this.gameDifficultChangeButton.Name = "gameDifficultChangeButton";
            this.gameDifficultChangeButton.Size = new System.Drawing.Size(150, 65);
            this.gameDifficultChangeButton.TabIndex = 5;
            this.gameDifficultChangeButton.Text = "Уровень сложности";
            this.gameDifficultChangeButton.UseVisualStyleBackColor = true;
            this.gameDifficultChangeButton.Click += new System.EventHandler(this.GameDifficultChangeButton_Click);
            // 
            // easyDiffButton
            // 
            this.easyDiffButton.Location = new System.Drawing.Point(692, 83);
            this.easyDiffButton.Name = "easyDiffButton";
            this.easyDiffButton.Size = new System.Drawing.Size(75, 20);
            this.easyDiffButton.TabIndex = 8;
            this.easyDiffButton.Text = "Easy";
            this.easyDiffButton.UseVisualStyleBackColor = true;
            this.easyDiffButton.Visible = false;
            this.easyDiffButton.Click += new System.EventHandler(this.EasyDiffButton_Click);
            // 
            // normalDiffButton
            // 
            this.normalDiffButton.Location = new System.Drawing.Point(692, 105);
            this.normalDiffButton.Name = "normalDiffButton";
            this.normalDiffButton.Size = new System.Drawing.Size(75, 20);
            this.normalDiffButton.TabIndex = 9;
            this.normalDiffButton.Text = "Normal";
            this.normalDiffButton.UseVisualStyleBackColor = true;
            this.normalDiffButton.Visible = false;
            this.normalDiffButton.Click += new System.EventHandler(this.NormalDiffButton_Click);
            // 
            // hardDiffButton
            // 
            this.hardDiffButton.Location = new System.Drawing.Point(692, 128);
            this.hardDiffButton.Name = "hardDiffButton";
            this.hardDiffButton.Size = new System.Drawing.Size(75, 20);
            this.hardDiffButton.TabIndex = 10;
            this.hardDiffButton.Text = "Hard";
            this.hardDiffButton.UseVisualStyleBackColor = true;
            this.hardDiffButton.Visible = false;
            this.hardDiffButton.Click += new System.EventHandler(this.HardDiffButton_Click);
            // 
            // scoreTitleLabel
            // 
            this.scoreTitleLabel.AutoSize = true;
            this.scoreTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreTitleLabel.Location = new System.Drawing.Point(12, 528);
            this.scoreTitleLabel.Name = "scoreTitleLabel";
            this.scoreTitleLabel.Size = new System.Drawing.Size(51, 18);
            this.scoreTitleLabel.TabIndex = 11;
            this.scoreTitleLabel.Text = "Счет:";
            this.scoreTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.scoreTitleLabel.Visible = false;
            // 
            // currentScoreLabel
            // 
            this.currentScoreLabel.AutoSize = true;
            this.currentScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentScoreLabel.Location = new System.Drawing.Point(59, 528);
            this.currentScoreLabel.Name = "currentScoreLabel";
            this.currentScoreLabel.Size = new System.Drawing.Size(17, 18);
            this.currentScoreLabel.TabIndex = 12;
            this.currentScoreLabel.Text = "0";
            this.currentScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.currentScoreLabel.Visible = false;
            // 
            // snakeApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 562);
            this.Controls.Add(this.currentScoreLabel);
            this.Controls.Add(this.scoreTitleLabel);
            this.Controls.Add(this.hardDiffButton);
            this.Controls.Add(this.normalDiffButton);
            this.Controls.Add(this.easyDiffButton);
            this.Controls.Add(this.controlButton);
            this.Controls.Add(this.leaderboardButton);
            this.Controls.Add(this.gameDifficultChangeButton);
            this.Controls.Add(this.gameStartButton);
            this.Controls.Add(this.gameFieldPanel);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "snakeApplication";
            this.Text = "Змейка";
            this.Load += new System.EventHandler(this.SnakeApplication_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SnakeApplication_KeyPress);
            this.gameFieldPanel.ResumeLayout(false);
            this.gameFieldPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gameFieldPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button gameStartButton;
        private System.Windows.Forms.TextBox alertTextBox;
        private System.Windows.Forms.Button controlButton;
        private System.Windows.Forms.Button leaderboardButton;
        private System.Windows.Forms.Button gameDifficultChangeButton;
        private System.Windows.Forms.Button easyDiffButton;
        private System.Windows.Forms.Button normalDiffButton;
        private System.Windows.Forms.Button hardDiffButton;
        private System.Windows.Forms.Label scoreTitleLabel;
        private System.Windows.Forms.Label currentScoreLabel;
        private System.Windows.Forms.Label congratulationsLabel;
        private System.Windows.Forms.TextBox inputNicknameTextBox;
        private System.Windows.Forms.Button saveNicknameButton;
    }
}

