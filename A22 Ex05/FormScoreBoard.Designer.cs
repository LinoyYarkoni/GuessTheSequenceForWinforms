
namespace UserInterface
{
    partial class FormScoreBoard
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
            this.labelNumberOfTurns = new System.Windows.Forms.Label();
            this.labelTurnsPlayed = new System.Windows.Forms.Label();
            this.labelWinOrLose = new System.Windows.Forms.Label();
            this.textBoxScores = new System.Windows.Forms.TextBox();
            this.listBoxScores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelNumberOfTurns
            // 
            this.labelNumberOfTurns.AutoSize = true;
            this.labelNumberOfTurns.Location = new System.Drawing.Point(13, 13);
            this.labelNumberOfTurns.Name = "labelNumberOfTurns";
            this.labelNumberOfTurns.Size = new System.Drawing.Size(34, 13);
            this.labelNumberOfTurns.TabIndex = 0;
            this.labelNumberOfTurns.Text = "Turns";
            // 
            // labelTurnsPlayed
            // 
            this.labelTurnsPlayed.AutoSize = true;
            this.labelTurnsPlayed.Location = new System.Drawing.Point(98, 13);
            this.labelTurnsPlayed.Name = "labelTurnsPlayed";
            this.labelTurnsPlayed.Size = new System.Drawing.Size(69, 13);
            this.labelTurnsPlayed.TabIndex = 1;
            this.labelTurnsPlayed.Text = "Turns Played";
            // 
            // labelWinOrLose
            // 
            this.labelWinOrLose.AutoSize = true;
            this.labelWinOrLose.Location = new System.Drawing.Point(208, 13);
            this.labelWinOrLose.Name = "labelWinOrLose";
            this.labelWinOrLose.Size = new System.Drawing.Size(82, 13);
            this.labelWinOrLose.TabIndex = 2;
            this.labelWinOrLose.Text = "Winner or Loser";
            // 
            // textBoxScores
            // 
            this.textBoxScores.Location = new System.Drawing.Point(16, 40);
            this.textBoxScores.Multiline = true;
            this.textBoxScores.Name = "textBoxScores";
            this.textBoxScores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxScores.Size = new System.Drawing.Size(274, 20);
            this.textBoxScores.TabIndex = 3;
            // 
            // listBoxScores
            // 
            this.listBoxScores.FormattingEnabled = true;
            this.listBoxScores.Location = new System.Drawing.Point(16, 77);
            this.listBoxScores.Name = "listBoxScores";
            this.listBoxScores.Size = new System.Drawing.Size(274, 173);
            this.listBoxScores.TabIndex = 4;
            // 
            // FormScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 471);
            this.Controls.Add(this.listBoxScores);
            this.Controls.Add(this.textBoxScores);
            this.Controls.Add(this.labelWinOrLose);
            this.Controls.Add(this.labelTurnsPlayed);
            this.Controls.Add(this.labelNumberOfTurns);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormScoreBoard";
            this.Text = "Score Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumberOfTurns;
        private System.Windows.Forms.Label labelTurnsPlayed;
        private System.Windows.Forms.Label labelWinOrLose;
        private System.Windows.Forms.TextBox textBoxScores;
        private System.Windows.Forms.ListBox listBoxScores;
    }
}