namespace Memory_Game

    //Designer voor het hoofdmenu, Spreekt voor zich...
{
    partial class MainMenu
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
            this.PlayButton = new System.Windows.Forms.Button();
            this.LeaderboardsButton = new System.Windows.Forms.Button();
            this.StoreButton = new System.Windows.Forms.Button();
            this.QuiteGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Location = new System.Drawing.Point(763, 121);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(391, 132);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // LeaderboardsButton
            // 
            this.LeaderboardsButton.BackColor = System.Drawing.Color.Transparent;
            this.LeaderboardsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LeaderboardsButton.FlatAppearance.BorderSize = 0;
            this.LeaderboardsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LeaderboardsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LeaderboardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeaderboardsButton.Location = new System.Drawing.Point(763, 357);
            this.LeaderboardsButton.Name = "LeaderboardsButton";
            this.LeaderboardsButton.Size = new System.Drawing.Size(391, 132);
            this.LeaderboardsButton.TabIndex = 1;
            this.LeaderboardsButton.UseVisualStyleBackColor = false;
            // 
            // StoreButton
            // 
            this.StoreButton.BackColor = System.Drawing.Color.Transparent;
            this.StoreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StoreButton.FlatAppearance.BorderSize = 0;
            this.StoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoreButton.Location = new System.Drawing.Point(763, 586);
            this.StoreButton.Name = "StoreButton";
            this.StoreButton.Size = new System.Drawing.Size(391, 132);
            this.StoreButton.TabIndex = 2;
            this.StoreButton.UseVisualStyleBackColor = false;
            // 
            // QuiteGameButton
            // 
            this.QuiteGameButton.BackColor = System.Drawing.Color.Transparent;
            this.QuiteGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.QuiteGameButton.FlatAppearance.BorderSize = 0;
            this.QuiteGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.QuiteGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.QuiteGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuiteGameButton.Location = new System.Drawing.Point(763, 822);
            this.QuiteGameButton.Name = "QuiteGameButton";
            this.QuiteGameButton.Size = new System.Drawing.Size(391, 132);
            this.QuiteGameButton.TabIndex = 3;
            this.QuiteGameButton.UseVisualStyleBackColor = false;
            this.QuiteGameButton.Click += new System.EventHandler(this.QuiteGameButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Memory_Game.Properties.Resources.MAINMENU1080P1;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.QuiteGameButton);
            this.Controls.Add(this.StoreButton);
            this.Controls.Add(this.LeaderboardsButton);
            this.Controls.Add(this.PlayButton);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button LeaderboardsButton;
        private System.Windows.Forms.Button StoreButton;
        private System.Windows.Forms.Button QuiteGameButton;
    }
}