namespace Ninja
{
    partial class Form1
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
            this.currentGameLbl = new System.Windows.Forms.Label();
            this.cboBoxGame = new System.Windows.Forms.ComboBox();
            this.cboBoxKiller = new System.Windows.Forms.ComboBox();
            this.cboBoxTarget = new System.Windows.Forms.ComboBox();
            this.cboBoxAchievement = new System.Windows.Forms.ComboBox();
            this.cboBoxPlayer = new System.Windows.Forms.ComboBox();
            this.lblAchievement = new System.Windows.Forms.Label();
            this.lblKiller = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddKill = new System.Windows.Forms.Button();
            this.btnAddAchievement = new System.Windows.Forms.Button();
            this.btnEditGame = new System.Windows.Forms.Button();
            this.lblLeaderboard = new System.Windows.Forms.Label();
            this.btnShowLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // currentGameLbl
            // 
            this.currentGameLbl.AutoSize = true;
            this.currentGameLbl.Location = new System.Drawing.Point(12, 9);
            this.currentGameLbl.Name = "currentGameLbl";
            this.currentGameLbl.Size = new System.Drawing.Size(158, 25);
            this.currentGameLbl.TabIndex = 0;
            this.currentGameLbl.Text = "Current Game :";
            // 
            // cboBoxGame
            // 
            this.cboBoxGame.FormattingEnabled = true;
            this.cboBoxGame.Location = new System.Drawing.Point(176, 6);
            this.cboBoxGame.Name = "cboBoxGame";
            this.cboBoxGame.Size = new System.Drawing.Size(205, 33);
            this.cboBoxGame.TabIndex = 1;
            // 
            // cboBoxKiller
            // 
            this.cboBoxKiller.FormattingEnabled = true;
            this.cboBoxKiller.Location = new System.Drawing.Point(17, 94);
            this.cboBoxKiller.Name = "cboBoxKiller";
            this.cboBoxKiller.Size = new System.Drawing.Size(230, 33);
            this.cboBoxKiller.TabIndex = 2;
            // 
            // cboBoxTarget
            // 
            this.cboBoxTarget.FormattingEnabled = true;
            this.cboBoxTarget.Location = new System.Drawing.Point(263, 94);
            this.cboBoxTarget.Name = "cboBoxTarget";
            this.cboBoxTarget.Size = new System.Drawing.Size(230, 33);
            this.cboBoxTarget.TabIndex = 3;
            // 
            // cboBoxAchievement
            // 
            this.cboBoxAchievement.FormattingEnabled = true;
            this.cboBoxAchievement.Location = new System.Drawing.Point(263, 184);
            this.cboBoxAchievement.Name = "cboBoxAchievement";
            this.cboBoxAchievement.Size = new System.Drawing.Size(230, 33);
            this.cboBoxAchievement.TabIndex = 4;
            // 
            // cboBoxPlayer
            // 
            this.cboBoxPlayer.FormattingEnabled = true;
            this.cboBoxPlayer.Location = new System.Drawing.Point(17, 184);
            this.cboBoxPlayer.Name = "cboBoxPlayer";
            this.cboBoxPlayer.Size = new System.Drawing.Size(230, 33);
            this.cboBoxPlayer.TabIndex = 5;
            // 
            // lblAchievement
            // 
            this.lblAchievement.AutoSize = true;
            this.lblAchievement.Location = new System.Drawing.Point(258, 157);
            this.lblAchievement.Name = "lblAchievement";
            this.lblAchievement.Size = new System.Drawing.Size(202, 25);
            this.lblAchievement.TabIndex = 6;
            this.lblAchievement.Text = "Select Achievement";
            // 
            // lblKiller
            // 
            this.lblKiller.AutoSize = true;
            this.lblKiller.Location = new System.Drawing.Point(12, 66);
            this.lblKiller.Name = "lblKiller";
            this.lblKiller.Size = new System.Drawing.Size(126, 25);
            this.lblKiller.TabIndex = 7;
            this.lblKiller.Text = "Select Killer";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(258, 66);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(140, 25);
            this.lblTarget.TabIndex = 8;
            this.lblTarget.Text = "Select Target";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(12, 157);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(139, 25);
            this.lblPlayer.TabIndex = 9;
            this.lblPlayer.Text = "Select Player";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(17, 287);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(815, 454);
            this.dataGridView.TabIndex = 10;
            // 
            // btnAddKill
            // 
            this.btnAddKill.Location = new System.Drawing.Point(518, 94);
            this.btnAddKill.Name = "btnAddKill";
            this.btnAddKill.Size = new System.Drawing.Size(196, 33);
            this.btnAddKill.TabIndex = 11;
            this.btnAddKill.Text = "Add Kill";
            this.btnAddKill.UseVisualStyleBackColor = true;
            // 
            // btnAddAchievement
            // 
            this.btnAddAchievement.Location = new System.Drawing.Point(518, 184);
            this.btnAddAchievement.Name = "btnAddAchievement";
            this.btnAddAchievement.Size = new System.Drawing.Size(196, 33);
            this.btnAddAchievement.TabIndex = 12;
            this.btnAddAchievement.Text = "Add Achievement";
            this.btnAddAchievement.UseVisualStyleBackColor = true;
            // 
            // btnEditGame
            // 
            this.btnEditGame.Location = new System.Drawing.Point(794, 9);
            this.btnEditGame.Name = "btnEditGame";
            this.btnEditGame.Size = new System.Drawing.Size(142, 33);
            this.btnEditGame.TabIndex = 13;
            this.btnEditGame.Text = "Edit Game";
            this.btnEditGame.UseVisualStyleBackColor = true;
            // 
            // lblLeaderboard
            // 
            this.lblLeaderboard.AutoSize = true;
            this.lblLeaderboard.Location = new System.Drawing.Point(12, 259);
            this.lblLeaderboard.Name = "lblLeaderboard";
            this.lblLeaderboard.Size = new System.Drawing.Size(146, 25);
            this.lblLeaderboard.TabIndex = 14;
            this.lblLeaderboard.Text = "Leaderboard :";
            // 
            // btnShowLog
            // 
            this.btnShowLog.Location = new System.Drawing.Point(409, 6);
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.Size = new System.Drawing.Size(142, 33);
            this.btnShowLog.TabIndex = 15;
            this.btnShowLog.Text = "Show Log";
            this.btnShowLog.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 757);
            this.Controls.Add(this.btnShowLog);
            this.Controls.Add(this.lblLeaderboard);
            this.Controls.Add(this.btnEditGame);
            this.Controls.Add(this.btnAddAchievement);
            this.Controls.Add(this.btnAddKill);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblKiller);
            this.Controls.Add(this.lblAchievement);
            this.Controls.Add(this.cboBoxPlayer);
            this.Controls.Add(this.cboBoxAchievement);
            this.Controls.Add(this.cboBoxTarget);
            this.Controls.Add(this.cboBoxKiller);
            this.Controls.Add(this.cboBoxGame);
            this.Controls.Add(this.currentGameLbl);
            this.Name = "Form1";
            this.Text = "Ninja";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentGameLbl;
        private System.Windows.Forms.ComboBox cboBoxGame;
        private System.Windows.Forms.ComboBox cboBoxKiller;
        private System.Windows.Forms.ComboBox cboBoxTarget;
        private System.Windows.Forms.ComboBox cboBoxAchievement;
        private System.Windows.Forms.ComboBox cboBoxPlayer;
        private System.Windows.Forms.Label lblAchievement;
        private System.Windows.Forms.Label lblKiller;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAddKill;
        private System.Windows.Forms.Button btnAddAchievement;
        private System.Windows.Forms.Button btnEditGame;
        private System.Windows.Forms.Label lblLeaderboard;
        private System.Windows.Forms.Button btnShowLog;
    }
}

