namespace UserInterface
{
    public partial class FormLogin
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
            System.Windows.Forms.Button buttonStart;
            this.buttonNumberOfGuesses = new System.Windows.Forms.Button();
            buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new System.Drawing.Point(260, 111);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new System.Drawing.Size(75, 23);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonNumberOfGuesses
            // 
            this.buttonNumberOfGuesses.Location = new System.Drawing.Point(55, 12);
            this.buttonNumberOfGuesses.Name = "buttonNumberOfGuesses";
            this.buttonNumberOfGuesses.Size = new System.Drawing.Size(244, 24);
            this.buttonNumberOfGuesses.TabIndex = 0;
            this.buttonNumberOfGuesses.Text = "Number of chances: 4";
            this.buttonNumberOfGuesses.UseVisualStyleBackColor = true;
            this.buttonNumberOfGuesses.Click += new System.EventHandler(this.buttonNumberOfChances_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 146);
            this.ControlBox = false;
            this.Controls.Add(buttonStart);
            this.Controls.Add(this.buttonNumberOfGuesses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess The Sequence";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNumberOfGuesses;
    }
}
