namespace ANS_Library_Management_System
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.txtUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSecurityAnswer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btnConfirm = new DevComponents.DotNetBar.ButtonX();
            this.txtSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.Border.Class = "TextBoxBorder";
            this.txtUsername.Location = new System.Drawing.Point(148, 77);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(271, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // txtSecurityAnswer
            // 
            // 
            // 
            // 
            this.txtSecurityAnswer.Border.Class = "TextBoxBorder";
            this.txtSecurityAnswer.Location = new System.Drawing.Point(148, 142);
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(271, 20);
            this.txtSecurityAnswer.TabIndex = 7;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(19, 73);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Username:";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(18, 107);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(113, 23);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "Security Question :";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(19, 138);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(100, 23);
            this.labelX4.TabIndex = 10;
            this.labelX4.Text = "Security Answer :";
            // 
            // btnConfirm
            // 
            this.btnConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConfirm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(337, 190);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 31);
            this.btnConfirm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtSecurityQuestion
            // 
            this.txtSecurityQuestion.FormattingEnabled = true;
            this.txtSecurityQuestion.Items.AddRange(new object[] {
            "What is the first and last name of your first boyfriend or girlfriend?",
            "Which phone number do you remember most from your childhood?",
            "What was your favorite place to visit as a child?",
            "Who is your favorite actor, musician, or artist?",
            "What is the name of your favorite pet?",
            "In what city were you born?",
            "What high school did you attend?",
            "What is the name of your first school?",
            "What is your favorite movie?",
            "What is your mother\'s maiden name?",
            "What street did you grow up on?",
            "What was the make of your first car?",
            "When is your anniversary?",
            "What is your favorite color?",
            "What is your father\'s middle name?",
            "What is the name of your first grade teacher?",
            "What was your high school mascot?",
            "Which is your favorite web browser?",
            "what is your favorite website",
            "what is your favorite forum",
            "what is your favorite online platform",
            "what is your favorite social media website"});
            this.txtSecurityQuestion.Location = new System.Drawing.Point(148, 107);
            this.txtSecurityQuestion.Name = "txtSecurityQuestion";
            this.txtSecurityQuestion.Size = new System.Drawing.Size(271, 21);
            this.txtSecurityQuestion.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Snow;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(12, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Forgot password?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(13, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Please confirm to continue.";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = global::ANS_Library_Management_System.Properties.Resources.bg_userform;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 263);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSecurityQuestion);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtSecurityAnswer);
            this.Controls.Add(this.txtUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPassword";
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.Controls.TextBoxX txtUsername;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSecurityAnswer;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX btnConfirm;
        private System.Windows.Forms.ComboBox txtSecurityQuestion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}