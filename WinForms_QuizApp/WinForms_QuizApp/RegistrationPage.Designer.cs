namespace WinForms_QuizApp
{
    partial class RegistrationPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RegistrationLabel = new Label();
            enterFirstNameLabel = new Label();
            enterSurnameLabel = new Label();
            firstNameTextBox = new TextBox();
            surnameTextBox = new TextBox();
            closeButton = new Button();
            RegisterButton = new Button();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            enterPasswordLabel = new Label();
            enterEmailLabel = new Label();
            usernameTextBox = new TextBox();
            enterUsernameLabel = new Label();
            goBackButton = new Button();
            SuspendLayout();
            // 
            // RegistrationLabel
            // 
            RegistrationLabel.AutoSize = true;
            RegistrationLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegistrationLabel.Location = new Point(246, 39);
            RegistrationLabel.Name = "RegistrationLabel";
            RegistrationLabel.Size = new Size(281, 65);
            RegistrationLabel.TabIndex = 0;
            RegistrationLabel.Text = "Registration";
            RegistrationLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // enterFirstNameLabel
            // 
            enterFirstNameLabel.AutoSize = true;
            enterFirstNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enterFirstNameLabel.Location = new Point(77, 200);
            enterFirstNameLabel.Name = "enterFirstNameLabel";
            enterFirstNameLabel.Size = new Size(115, 25);
            enterFirstNameLabel.TabIndex = 1;
            enterFirstNameLabel.Text = "Enter Name:";
            // 
            // enterSurnameLabel
            // 
            enterSurnameLabel.AutoSize = true;
            enterSurnameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enterSurnameLabel.Location = new Point(77, 250);
            enterSurnameLabel.Name = "enterSurnameLabel";
            enterSurnameLabel.Size = new Size(140, 25);
            enterSurnameLabel.TabIndex = 2;
            enterSurnameLabel.Text = "Enter Surname:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(233, 200);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(200, 23);
            firstNameTextBox.TabIndex = 5;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(233, 250);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(200, 23);
            surnameTextBox.TabIndex = 6;
            // 
            // closeButton
            // 
            closeButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeButton.Location = new Point(557, 320);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(130, 38);
            closeButton.TabIndex = 7;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.Font = new Font("Segoe UI", 14.25F);
            RegisterButton.Location = new Point(557, 150);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(130, 38);
            RegisterButton.TabIndex = 8;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(233, 300);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(200, 23);
            emailTextBox.TabIndex = 9;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(233, 350);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(200, 23);
            passwordTextBox.TabIndex = 10;
            // 
            // enterPasswordLabel
            // 
            enterPasswordLabel.AutoSize = true;
            enterPasswordLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enterPasswordLabel.Location = new Point(77, 350);
            enterPasswordLabel.Name = "enterPasswordLabel";
            enterPasswordLabel.Size = new Size(144, 25);
            enterPasswordLabel.TabIndex = 11;
            enterPasswordLabel.Text = "Enter Password:";
            // 
            // enterEmailLabel
            // 
            enterEmailLabel.AutoSize = true;
            enterEmailLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enterEmailLabel.Location = new Point(77, 300);
            enterEmailLabel.Name = "enterEmailLabel";
            enterEmailLabel.Size = new Size(111, 25);
            enterEmailLabel.TabIndex = 12;
            enterEmailLabel.Text = "Enter Email:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(233, 150);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(200, 23);
            usernameTextBox.TabIndex = 13;
            // 
            // enterUsernameLabel
            // 
            enterUsernameLabel.AutoSize = true;
            enterUsernameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enterUsernameLabel.Location = new Point(77, 150);
            enterUsernameLabel.Name = "enterUsernameLabel";
            enterUsernameLabel.Size = new Size(150, 25);
            enterUsernameLabel.TabIndex = 14;
            enterUsernameLabel.Text = "Enter Username:";
            // 
            // goBackButton
            // 
            goBackButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goBackButton.Location = new Point(557, 235);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(130, 38);
            goBackButton.TabIndex = 15;
            goBackButton.Text = "Back";
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Click += goBackButton_Click;
            // 
            // RegistrationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(goBackButton);
            Controls.Add(enterUsernameLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(enterEmailLabel);
            Controls.Add(enterPasswordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(RegisterButton);
            Controls.Add(closeButton);
            Controls.Add(surnameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(enterSurnameLabel);
            Controls.Add(enterFirstNameLabel);
            Controls.Add(RegistrationLabel);
            Name = "RegistrationPage";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RegistrationLabel;
        private Label enterFirstNameLabel;
        private Label enterSurnameLabel;
        private TextBox firstNameTextBox;
        private TextBox surnameTextBox;
        private Button closeButton;
        private Button RegisterButton;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private Label enterPasswordLabel;
        private Label enterEmailLabel;
        private TextBox usernameTextBox;
        private Label enterUsernameLabel;
        private Button goBackButton;
    }
}
