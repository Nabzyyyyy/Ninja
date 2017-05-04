namespace Ninja.Forms
{
    partial class editForm
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
            this.btnCreateNewGame = new System.Windows.Forms.Button();
            this.txtCreateNewGame = new System.Windows.Forms.TextBox();
            this.txtAddPlayer = new System.Windows.Forms.TextBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblCurrentGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateNewGame
            // 
            this.btnCreateNewGame.Location = new System.Drawing.Point(347, 119);
            this.btnCreateNewGame.Name = "btnCreateNewGame";
            this.btnCreateNewGame.Size = new System.Drawing.Size(223, 41);
            this.btnCreateNewGame.TabIndex = 0;
            this.btnCreateNewGame.Text = "Create New Game";
            this.btnCreateNewGame.UseVisualStyleBackColor = true;
            this.btnCreateNewGame.Click += new System.EventHandler(this.btnCreateNewGame_Click);
            // 
            // txtCreateNewGame
            // 
            this.txtCreateNewGame.Location = new System.Drawing.Point(104, 119);
            this.txtCreateNewGame.Name = "txtCreateNewGame";
            this.txtCreateNewGame.Size = new System.Drawing.Size(205, 31);
            this.txtCreateNewGame.TabIndex = 1;
            // 
            // txtAddPlayer
            // 
            this.txtAddPlayer.Location = new System.Drawing.Point(104, 190);
            this.txtAddPlayer.Name = "txtAddPlayer";
            this.txtAddPlayer.Size = new System.Drawing.Size(205, 31);
            this.txtAddPlayer.TabIndex = 3;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(347, 190);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(223, 41);
            this.btnAddPlayer.TabIndex = 2;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Location = new System.Drawing.Point(298, 22);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(81, 25);
            this.lblGameName.TabIndex = 4;
            this.lblGameName.Text = "Game1";
            this.lblGameName.Click += new System.EventHandler(this.lblGameName_Click);
            // 
            // lblCurrentGame
            // 
            this.lblCurrentGame.AutoSize = true;
            this.lblCurrentGame.Location = new System.Drawing.Point(140, 22);
            this.lblCurrentGame.Name = "lblCurrentGame";
            this.lblCurrentGame.Size = new System.Drawing.Size(152, 25);
            this.lblCurrentGame.TabIndex = 5;
            this.lblCurrentGame.Text = "Current Game:";
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 308);
            this.Controls.Add(this.lblCurrentGame);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.txtAddPlayer);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.txtCreateNewGame);
            this.Controls.Add(this.btnCreateNewGame);
            this.Name = "editForm";
            this.Text = "Edit Games";
            this.Load += new System.EventHandler(this.editForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNewGame;
        private System.Windows.Forms.TextBox txtCreateNewGame;
        private System.Windows.Forms.TextBox txtAddPlayer;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblCurrentGame;
    }
}