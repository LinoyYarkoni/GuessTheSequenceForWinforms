namespace Logic
{
    public partial class FormGame
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
            this.m_ButtonFirstResult = new System.Windows.Forms.Button();
            this.m_ButtonSecondResult = new System.Windows.Forms.Button();
            this.m_ButtonThirdResult = new System.Windows.Forms.Button();
            this.m_ButtonForthResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_ButtonFirstResult
            // 
            this.m_ButtonFirstResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_ButtonFirstResult.Enabled = false;
            this.m_ButtonFirstResult.FlatAppearance.BorderSize = 0;
            this.m_ButtonFirstResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_ButtonFirstResult.Location = new System.Drawing.Point(12, 12);
            this.m_ButtonFirstResult.Name = "m_ButtonFirstResult";
            this.m_ButtonFirstResult.Size = new System.Drawing.Size(52, 46);
            this.m_ButtonFirstResult.TabIndex = 0;
            this.m_ButtonFirstResult.UseVisualStyleBackColor = false;
            // 
            // m_ButtonSecondResult
            // 
            this.m_ButtonSecondResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_ButtonSecondResult.Enabled = false;
            this.m_ButtonSecondResult.FlatAppearance.BorderSize = 0;
            this.m_ButtonSecondResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_ButtonSecondResult.Location = new System.Drawing.Point(70, 12);
            this.m_ButtonSecondResult.Name = "m_ButtonSecondResult";
            this.m_ButtonSecondResult.Size = new System.Drawing.Size(52, 46);
            this.m_ButtonSecondResult.TabIndex = 1;
            this.m_ButtonSecondResult.UseVisualStyleBackColor = false;
            // 
            // m_ButtonThirdResult
            // 
            this.m_ButtonThirdResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_ButtonThirdResult.Enabled = false;
            this.m_ButtonThirdResult.FlatAppearance.BorderSize = 0;
            this.m_ButtonThirdResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_ButtonThirdResult.Location = new System.Drawing.Point(128, 12);
            this.m_ButtonThirdResult.Name = "m_ButtonThirdResult";
            this.m_ButtonThirdResult.Size = new System.Drawing.Size(52, 46);
            this.m_ButtonThirdResult.TabIndex = 2;
            this.m_ButtonThirdResult.UseVisualStyleBackColor = false;
            // 
            // m_ButtonForthResult
            // 
            this.m_ButtonForthResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_ButtonForthResult.Enabled = false;
            this.m_ButtonForthResult.FlatAppearance.BorderSize = 0;
            this.m_ButtonForthResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_ButtonForthResult.Location = new System.Drawing.Point(186, 12);
            this.m_ButtonForthResult.Name = "m_ButtonForthResult";
            this.m_ButtonForthResult.Size = new System.Drawing.Size(52, 46);
            this.m_ButtonForthResult.TabIndex = 3;
            this.m_ButtonForthResult.UseVisualStyleBackColor = false;
            // 
            // FormGame
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.m_ButtonForthResult);
            this.Controls.Add(this.m_ButtonThirdResult);
            this.Controls.Add(this.m_ButtonSecondResult);
            this.Controls.Add(this.m_ButtonFirstResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bool Pgia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_ButtonFirstResult;
        private System.Windows.Forms.Button m_ButtonSecondResult;
        private System.Windows.Forms.Button m_ButtonThirdResult;
        private System.Windows.Forms.Button m_ButtonForthResult;
      }
}