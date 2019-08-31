namespace Snake
{
    partial class controlForm
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
            this.rightButtonLabel = new System.Windows.Forms.Label();
            this.leftButtonLabel = new System.Windows.Forms.Label();
            this.pauseButtonLabel = new System.Windows.Forms.Label();
            this.switchMusicButtonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rightButtonLabel
            // 
            this.rightButtonLabel.AutoSize = true;
            this.rightButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightButtonLabel.Location = new System.Drawing.Point(54, 18);
            this.rightButtonLabel.Name = "rightButtonLabel";
            this.rightButtonLabel.Size = new System.Drawing.Size(146, 18);
            this.rightButtonLabel.TabIndex = 0;
            this.rightButtonLabel.Text = "Поворот вправо - D";
            // 
            // leftButtonLabel
            // 
            this.leftButtonLabel.AutoSize = true;
            this.leftButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftButtonLabel.Location = new System.Drawing.Point(59, 53);
            this.leftButtonLabel.Name = "leftButtonLabel";
            this.leftButtonLabel.Size = new System.Drawing.Size(137, 18);
            this.leftButtonLabel.TabIndex = 1;
            this.leftButtonLabel.Text = "Поворот влево - A";
            // 
            // pauseButtonLabel
            // 
            this.pauseButtonLabel.AutoSize = true;
            this.pauseButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pauseButtonLabel.Location = new System.Drawing.Point(40, 89);
            this.pauseButtonLabel.Name = "pauseButtonLabel";
            this.pauseButtonLabel.Size = new System.Drawing.Size(174, 18);
            this.pauseButtonLabel.TabIndex = 2;
            this.pauseButtonLabel.Text = "Пауза / Продолжить - P";
            // 
            // switchMusicButtonLabel
            // 
            this.switchMusicButtonLabel.AutoSize = true;
            this.switchMusicButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.switchMusicButtonLabel.Location = new System.Drawing.Point(40, 124);
            this.switchMusicButtonLabel.Name = "switchMusicButtonLabel";
            this.switchMusicButtonLabel.Size = new System.Drawing.Size(175, 18);
            this.switchMusicButtonLabel.TabIndex = 3;
            this.switchMusicButtonLabel.Text = "Выкл. / Вкл. музыку - M";
            // 
            // controlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 162);
            this.Controls.Add(this.switchMusicButtonLabel);
            this.Controls.Add(this.pauseButtonLabel);
            this.Controls.Add(this.leftButtonLabel);
            this.Controls.Add(this.rightButtonLabel);
            this.MaximizeBox = false;
            this.Name = "controlForm";
            this.Text = "Управление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rightButtonLabel;
        private System.Windows.Forms.Label leftButtonLabel;
        private System.Windows.Forms.Label pauseButtonLabel;
        private System.Windows.Forms.Label switchMusicButtonLabel;
    }
}