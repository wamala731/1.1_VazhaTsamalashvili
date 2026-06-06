namespace WinForms_QuizApp
{
    partial class WelcomePage
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
            WelcomeLabel = new Label();
            goToLogInPageButton = new Button();
            goToRegistrationPageButton = new Button();
            closeButton = new Button();
            letsStartButton = new Button();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new Point(69, 69);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(643, 65);
            WelcomeLabel.TabIndex = 1;
            WelcomeLabel.Text = "Welcome to Who Wants 20 K";
            WelcomeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // goToLogInPageButton
            // 
            goToLogInPageButton.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goToLogInPageButton.Location = new Point(116, 282);
            goToLogInPageButton.Name = "goToLogInPageButton";
            goToLogInPageButton.Size = new Size(170, 63);
            goToLogInPageButton.TabIndex = 2;
            goToLogInPageButton.Text = "Log In";
            goToLogInPageButton.UseVisualStyleBackColor = true;
            goToLogInPageButton.Visible = false;
            goToLogInPageButton.Click += goToLogInPageButton_Click;
            // 
            // goToRegistrationPageButton
            // 
            goToRegistrationPageButton.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goToRegistrationPageButton.Location = new Point(510, 282);
            goToRegistrationPageButton.Name = "goToRegistrationPageButton";
            goToRegistrationPageButton.Size = new Size(170, 63);
            goToRegistrationPageButton.TabIndex = 3;
            goToRegistrationPageButton.Text = "Register";
            goToRegistrationPageButton.UseVisualStyleBackColor = true;
            goToRegistrationPageButton.Visible = false;
            goToRegistrationPageButton.Click += button2_Click;
            // 
            // closeButton
            // 
            closeButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeButton.Location = new Point(335, 300);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(130, 38);
            closeButton.TabIndex = 8;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Visible = false;
            closeButton.Click += closeButton_Click;
            // 
            // letsStartButton
            // 
            letsStartButton.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            letsStartButton.Location = new Point(302, 282);
            letsStartButton.Name = "letsStartButton";
            letsStartButton.Size = new Size(189, 63);
            letsStartButton.TabIndex = 9;
            letsStartButton.Text = "Let's Start";
            letsStartButton.UseVisualStyleBackColor = true;
            letsStartButton.Click += letsStartButton_Click;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(letsStartButton);
            Controls.Add(closeButton);
            Controls.Add(goToRegistrationPageButton);
            Controls.Add(goToLogInPageButton);
            Controls.Add(WelcomeLabel);
            Name = "WelcomePage";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeLabel;
        private Button goToLogInPageButton;
        private Button goToRegistrationPageButton;
        private Button closeButton;
        private Button letsStartButton;
    }
}