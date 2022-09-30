namespace UserInterface
{
    public partial class FormColors
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
            if(disposing && (components != null))
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
            this.m_ButtonPink = new System.Windows.Forms.Button();
            this.m_ButtonRed = new System.Windows.Forms.Button();
            this.m_ButtonGreen = new System.Windows.Forms.Button();
            this.m_ButtonLightBlue = new System.Windows.Forms.Button();
            this.m_ButtonDarkBlue = new System.Windows.Forms.Button();
            this.m_ButtonYellow = new System.Windows.Forms.Button();
            this.m_ButtonBrown = new System.Windows.Forms.Button();
            this.m_ButtonWhite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_ButtonPink
            // 
            this.m_ButtonPink.BackColor = System.Drawing.Color.Pink;
            this.m_ButtonPink.FlatAppearance.BorderSize = 0;
            this.m_ButtonPink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_ButtonPink.Location = new System.Drawing.Point(12, 12);
            this.m_ButtonPink.Name = "m_ButtonPink";
            this.m_ButtonPink.Size = new System.Drawing.Size(52, 46);
            this.m_ButtonPink.TabIndex = 0;
            this.m_ButtonPink.Tag = 'A';
            this.m_ButtonPink.UseVisualStyleBackColor = false;
            this.m_ButtonPink.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // m_ButtonRed
            // 
            this.m_ButtonRed.BackColor = System.Drawing.Color.Red;
            this.m_ButtonRed.FlatAppearance.BorderSize = 0;
            this.m_ButtonRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_ButtonRed.Location = new System.Drawing.Point(70, 12);
            this.m_ButtonRed.Name = "m_ButtonRed";
            this.m_ButtonRed.Size = new System.Drawing.Size(52, 46);
            this.m_ButtonRed.TabIndex = 1;
            this.m_ButtonRed.Tag = 'B';
            this.m_ButtonRed.UseVisualStyleBackColor = false;
            this.m_ButtonRed.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // m_ButtonGreen
            // 
            this.m_ButtonGreen.BackColor = System.Drawing.Color.Lime;
            this.m_ButtonGreen.FlatAppearance.BorderSize = 0;
            this.m_ButtonGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_ButtonGreen.Location = new System.Drawing.Point(128, 12);
            this.m_ButtonGreen.Name = "m_ButtonGreen";
            this.m_ButtonGreen.Size = new System.Drawing.Size(52, 46);
            this.m_ButtonGreen.TabIndex = 2;
            this.m_ButtonGreen.Tag = 'C';
            this.m_ButtonGreen.UseVisualStyleBackColor = false;
            this.m_ButtonGreen.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // m_ButtonLightBlue
            // 
            this.m_ButtonLightBlue.BackColor = System.Drawing.Color.Aqua;
            this.m_ButtonLightBlue.FlatAppearance.BorderSize = 0;
            this.m_ButtonLightBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_ButtonLightBlue.Location = new System.Drawing.Point(186, 12);
            this.m_ButtonLightBlue.Name = "m_ButtonLightBlue";
            this.m_ButtonLightBlue.Size = new System.Drawing.Size(52, 46);
            this.m_ButtonLightBlue.TabIndex = 3;
            this.m_ButtonLightBlue.Tag = 'D';
            this.m_ButtonLightBlue.UseVisualStyleBackColor = false;
            this.m_ButtonLightBlue.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // m_ButtonDarkBlue
            // 
            this.m_ButtonDarkBlue.BackColor = System.Drawing.Color.Blue;
            this.m_ButtonDarkBlue.FlatAppearance.BorderSize = 0;
            this.m_ButtonDarkBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_ButtonDarkBlue.Location = new System.Drawing.Point(12, 64);
            this.m_ButtonDarkBlue.Name = "m_ButtonDarkBlue";
            this.m_ButtonDarkBlue.Size = new System.Drawing.Size(52, 46);
            this.m_ButtonDarkBlue.TabIndex = 4;
            this.m_ButtonDarkBlue.Tag = 'E';
            this.m_ButtonDarkBlue.UseVisualStyleBackColor = false;
            this.m_ButtonDarkBlue.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // m_ButtonYellow
            // 
            this.m_ButtonYellow.BackColor = System.Drawing.Color.Yellow;
            this.m_ButtonYellow.FlatAppearance.BorderSize = 0;
            this.m_ButtonYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_ButtonYellow.Location = new System.Drawing.Point(70, 64);
            this.m_ButtonYellow.Name = "m_ButtonYellow";
            this.m_ButtonYellow.Size = new System.Drawing.Size(52, 46);
            this.m_ButtonYellow.TabIndex = 5;
            this.m_ButtonYellow.Tag = 'F';
            this.m_ButtonYellow.UseVisualStyleBackColor = false;
            this.m_ButtonYellow.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // m_ButtonBrown
            // 
            this.m_ButtonBrown.BackColor = System.Drawing.Color.SaddleBrown;
            this.m_ButtonBrown.FlatAppearance.BorderSize = 0;
            this.m_ButtonBrown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_ButtonBrown.Location = new System.Drawing.Point(128, 64);
            this.m_ButtonBrown.Name = "m_ButtonBrown";
            this.m_ButtonBrown.Size = new System.Drawing.Size(52, 46);
            this.m_ButtonBrown.TabIndex = 6;
            this.m_ButtonBrown.Tag = 'G';
            this.m_ButtonBrown.UseVisualStyleBackColor = false;
            this.m_ButtonBrown.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // m_ButtonWhite
            // 
            this.m_ButtonWhite.BackColor = System.Drawing.Color.White;
            this.m_ButtonWhite.FlatAppearance.BorderSize = 0;
            this.m_ButtonWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_ButtonWhite.Location = new System.Drawing.Point(186, 64);
            this.m_ButtonWhite.Name = "m_ButtonWhite";
            this.m_ButtonWhite.Size = new System.Drawing.Size(52, 46);
            this.m_ButtonWhite.TabIndex = 7;
            this.m_ButtonWhite.Tag = 'H';
            this.m_ButtonWhite.UseVisualStyleBackColor = false;
            this.m_ButtonWhite.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // FormColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 125);
            this.Controls.Add(this.m_ButtonWhite);
            this.Controls.Add(this.m_ButtonBrown);
            this.Controls.Add(this.m_ButtonYellow);
            this.Controls.Add(this.m_ButtonDarkBlue);
            this.Controls.Add(this.m_ButtonLightBlue);
            this.Controls.Add(this.m_ButtonGreen);
            this.Controls.Add(this.m_ButtonRed);
            this.Controls.Add(this.m_ButtonPink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormColors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pick A Color:";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button m_ButtonPink;
        private System.Windows.Forms.Button m_ButtonRed;
        private System.Windows.Forms.Button m_ButtonGreen;
        private System.Windows.Forms.Button m_ButtonLightBlue;
        private System.Windows.Forms.Button m_ButtonDarkBlue;
        private System.Windows.Forms.Button m_ButtonYellow;
        private System.Windows.Forms.Button m_ButtonBrown;
        private System.Windows.Forms.Button m_ButtonWhite;
    }
}