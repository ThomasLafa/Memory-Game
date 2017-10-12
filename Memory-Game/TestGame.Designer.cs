namespace Memory_Game
{
    partial class TestGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestGame));
            this.BackToMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.BackToMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackToMenuButton.FlatAppearance.BorderSize = 0;
            this.BackToMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BackToMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BackToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToMenuButton.Location = new System.Drawing.Point(1444, 828);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(371, 125);
            this.BackToMenuButton.TabIndex = 0;
            this.BackToMenuButton.UseVisualStyleBackColor = false;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // TestGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.BackToMenuButton);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "TestGame";
            this.Controls.SetChildIndex(this.BackToMenuButton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToMenuButton;
    }
}
