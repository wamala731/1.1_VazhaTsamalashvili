using WinForms_QuizApp_Domain.Entities;

namespace WinForms_QuizApp
{
    partial class MainMenu
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
            AdminMenuLabel = new Label();
            impExpQuestionsLabel = new Label();
            impExpPlayersLabel = new Label();
            ImportQuestionsFiles = new Button();
            ImportPlayersFiles = new Button();
            ExportQuestionsFiles = new Button();
            ExportPlayersFiles = new Button();
            StartButton = new Button();
            ShowAdminMenuButton = new Button();
            LetsPlayLabel = new Label();
            GoBackButton = new Button();
            SuspendLayout();
            // 
            // AdminMenuLabel
            // 
            AdminMenuLabel.AutoSize = true;
            AdminMenuLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminMenuLabel.Location = new Point(237, 41);
            AdminMenuLabel.Name = "AdminMenuLabel";
            AdminMenuLabel.Size = new Size(315, 65);
            AdminMenuLabel.TabIndex = 3;
            AdminMenuLabel.Text = "Admin Menu \r\n";
            AdminMenuLabel.TextAlign = ContentAlignment.TopCenter;
            AdminMenuLabel.Visible = false;
            // 
            // impExpQuestionsLabel
            // 
            impExpQuestionsLabel.AutoSize = true;
            impExpQuestionsLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            impExpQuestionsLabel.Location = new Point(102, 139);
            impExpQuestionsLabel.Name = "impExpQuestionsLabel";
            impExpQuestionsLabel.Size = new Size(183, 47);
            impExpQuestionsLabel.TabIndex = 4;
            impExpQuestionsLabel.Text = "Questions:";
            impExpQuestionsLabel.TextAlign = ContentAlignment.TopCenter;
            impExpQuestionsLabel.Visible = false;
            // 
            // impExpPlayersLabel
            // 
            impExpPlayersLabel.AutoSize = true;
            impExpPlayersLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            impExpPlayersLabel.Location = new Point(149, 253);
            impExpPlayersLabel.Name = "impExpPlayersLabel";
            impExpPlayersLabel.Size = new Size(136, 47);
            impExpPlayersLabel.TabIndex = 5;
            impExpPlayersLabel.Text = "Players:";
            impExpPlayersLabel.TextAlign = ContentAlignment.TopCenter;
            impExpPlayersLabel.Visible = false;
            // 
            // ImportQuestionsFiles
            // 
            ImportQuestionsFiles.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ImportQuestionsFiles.Location = new Point(291, 139);
            ImportQuestionsFiles.Name = "ImportQuestionsFiles";
            ImportQuestionsFiles.Size = new Size(161, 56);
            ImportQuestionsFiles.TabIndex = 8;
            ImportQuestionsFiles.Text = "Import Files";
            ImportQuestionsFiles.UseVisualStyleBackColor = true;
            ImportQuestionsFiles.Visible = false;
            ImportQuestionsFiles.Click += ImportQuestions_Click;
            // 
            // ImportPlayersFiles
            // 
            ImportPlayersFiles.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ImportPlayersFiles.Location = new Point(291, 249);
            ImportPlayersFiles.Name = "ImportPlayersFiles";
            ImportPlayersFiles.Size = new Size(161, 56);
            ImportPlayersFiles.TabIndex = 9;
            ImportPlayersFiles.Text = "Import Files";
            ImportPlayersFiles.UseVisualStyleBackColor = true;
            ImportPlayersFiles.Visible = false;
            ImportPlayersFiles.Click += ImportPlayersFiles_Click;
            // 
            // ExportQuestionsFiles
            // 
            ExportQuestionsFiles.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExportQuestionsFiles.Location = new Point(462, 139);
            ExportQuestionsFiles.Name = "ExportQuestionsFiles";
            ExportQuestionsFiles.Size = new Size(161, 56);
            ExportQuestionsFiles.TabIndex = 10;
            ExportQuestionsFiles.Text = "Export Files";
            ExportQuestionsFiles.UseVisualStyleBackColor = true;
            ExportQuestionsFiles.Visible = false;
            ExportQuestionsFiles.Click += ExportQuestionsFiles_Click;
            // 
            // ExportPlayersFiles
            // 
            ExportPlayersFiles.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExportPlayersFiles.Location = new Point(462, 249);
            ExportPlayersFiles.Name = "ExportPlayersFiles";
            ExportPlayersFiles.Size = new Size(161, 56);
            ExportPlayersFiles.TabIndex = 11;
            ExportPlayersFiles.Text = "Export Files";
            ExportPlayersFiles.UseVisualStyleBackColor = true;
            ExportPlayersFiles.Visible = false;
            ExportPlayersFiles.Click += ExportPlayersFiles_Click;
            // 
            // StartButton
            // 
            StartButton.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartButton.Location = new Point(261, 187);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(280, 63);
            StartButton.TabIndex = 12;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // ShowAdminMenuButton
            // 
            ShowAdminMenuButton.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowAdminMenuButton.Location = new Point(261, 256);
            ShowAdminMenuButton.Name = "ShowAdminMenuButton";
            ShowAdminMenuButton.Size = new Size(280, 63);
            ShowAdminMenuButton.TabIndex = 13;
            ShowAdminMenuButton.Text = "Admin Menu";
            ShowAdminMenuButton.UseVisualStyleBackColor = true;
            ShowAdminMenuButton.Click += ShowAdminMenuButton_Click;
            // 
            // LetsPlayLabel
            // 
            LetsPlayLabel.AutoSize = true;
            LetsPlayLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LetsPlayLabel.Location = new Point(76, 41);
            LetsPlayLabel.Name = "LetsPlayLabel";
            LetsPlayLabel.Size = new Size(666, 65);
            LetsPlayLabel.TabIndex = 14;
            LetsPlayLabel.Text = "Let's Play the Who Wants 20K!";
            LetsPlayLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // GoBackButton
            // 
            GoBackButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GoBackButton.Location = new Point(566, 359);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(161, 56);
            GoBackButton.TabIndex = 15;
            GoBackButton.Text = "Go Back";
            GoBackButton.UseVisualStyleBackColor = true;
            GoBackButton.Visible = false;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GoBackButton);
            Controls.Add(LetsPlayLabel);
            Controls.Add(ShowAdminMenuButton);
            Controls.Add(StartButton);
            Controls.Add(ExportPlayersFiles);
            Controls.Add(ExportQuestionsFiles);
            Controls.Add(ImportPlayersFiles);
            Controls.Add(ImportQuestionsFiles);
            Controls.Add(impExpPlayersLabel);
            Controls.Add(impExpQuestionsLabel);
            Controls.Add(AdminMenuLabel);
            Name = "MainMenu";
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AdminMenuLabel;
        private Label impExpQuestionsLabel;
        private Label impExpPlayersLabel;
        private Button ImportQuestionsFiles;
        private Button ImportPlayersFiles;
        private Button ExportQuestionsFiles;
        private Button ExportPlayersFiles;
        private Button StartButton;
        private Button ShowAdminMenuButton;
        private Label LetsPlayLabel;
        private Button GoBackButton;
    }
}