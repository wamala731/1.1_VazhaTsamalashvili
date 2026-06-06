namespace WinForms_QuizApp
{
    partial class LogInPage
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
            RegistrationLabel = new Label();
            enterUsernameLabel = new Label();
            label1 = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            LogInButton = new Button();
            goBackButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // RegistrationLabel
            // 
            RegistrationLabel.AutoSize = true;
            RegistrationLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegistrationLabel.Location = new Point(320, 48);
            RegistrationLabel.Name = "RegistrationLabel";
            RegistrationLabel.Size = new Size(160, 65);
            RegistrationLabel.TabIndex = 1;
            RegistrationLabel.Text = "Log In";
            RegistrationLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // enterUsernameLabel
            // 
            enterUsernameLabel.AutoSize = true;
            enterUsernameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enterUsernameLabel.Location = new Point(83, 158);
            enterUsernameLabel.Name = "enterUsernameLabel";
            enterUsernameLabel.Size = new Size(210, 37);
            enterUsernameLabel.TabIndex = 15;
            enterUsernameLabel.Text = "Enter Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 222);
            label1.Name = "label1";
            label1.Size = new Size(202, 37);
            label1.TabIndex = 16;
            label1.Text = "Enter Password:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(299, 172);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(227, 23);
            usernameTextBox.TabIndex = 17;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(299, 236);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(227, 23);
            passwordTextBox.TabIndex = 18;
            // 
            // LogInButton
            // 
            LogInButton.Font = new Font("Segoe UI", 14.25F);
            LogInButton.Location = new Point(105, 331);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(130, 38);
            LogInButton.TabIndex = 19;
            LogInButton.Text = "Log In";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // goBackButton
            // 
            goBackButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goBackButton.Location = new Point(335, 331);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(130, 38);
            goBackButton.TabIndex = 20;
            goBackButton.Text = "Back";
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Click += goBackButton_Click;
            // 
            // closeButton
            // 
            closeButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeButton.Location = new Point(571, 331);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(130, 38);
            closeButton.TabIndex = 21;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // LogInPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeButton);
            Controls.Add(goBackButton);
            Controls.Add(LogInButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(label1);
            Controls.Add(enterUsernameLabel);
            Controls.Add(RegistrationLabel);
            Name = "LogInPage";
            Text = "LogInPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RegistrationLabel;
        private Label enterUsernameLabel;
        private Label label1;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button LogInButton;
        private Button goBackButton;
        private Button closeButton;
    }
}