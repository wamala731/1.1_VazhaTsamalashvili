namespace WinForms_QuizApp
{
    partial class GamePage
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
            QuestionTextLabel = new Label();
            answerButton1 = new Button();
            answerButton2 = new Button();
            answerButton3 = new Button();
            answerButton4 = new Button();
            showBalanceLabel = new Label();
            CashOutButton = new Button();
            callHelpsButton = new Button();
            SuspendLayout();
            // 
            // QuestionTextLabel
            // 
            QuestionTextLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuestionTextLabel.Location = new Point(83, 34);
            QuestionTextLabel.Name = "QuestionTextLabel";
            QuestionTextLabel.Size = new Size(638, 137);
            QuestionTextLabel.TabIndex = 0;
            QuestionTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // answerButton1
            // 
            answerButton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answerButton1.Location = new Point(83, 211);
            answerButton1.Name = "answerButton1";
            answerButton1.Size = new Size(311, 64);
            answerButton1.TabIndex = 1;
            answerButton1.Text = "button1";
            answerButton1.UseVisualStyleBackColor = true;
            answerButton1.Click += answerButton1_Click;
            // 
            // answerButton2
            // 
            answerButton2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answerButton2.Location = new Point(410, 211);
            answerButton2.Name = "answerButton2";
            answerButton2.Size = new Size(311, 64);
            answerButton2.TabIndex = 2;
            answerButton2.Text = "button2";
            answerButton2.UseVisualStyleBackColor = true;
            answerButton2.Click += answerButton2_Click;
            // 
            // answerButton3
            // 
            answerButton3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answerButton3.Location = new Point(83, 294);
            answerButton3.Name = "answerButton3";
            answerButton3.Size = new Size(311, 64);
            answerButton3.TabIndex = 3;
            answerButton3.Text = "button3";
            answerButton3.UseVisualStyleBackColor = true;
            answerButton3.Click += answerButton3_Click;
            // 
            // answerButton4
            // 
            answerButton4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answerButton4.Location = new Point(410, 294);
            answerButton4.Name = "answerButton4";
            answerButton4.Size = new Size(311, 64);
            answerButton4.TabIndex = 4;
            answerButton4.Text = "button4";
            answerButton4.UseVisualStyleBackColor = true;
            answerButton4.Click += answerButton4_Click;
            // 
            // showBalanceLabel
            // 
            showBalanceLabel.AutoSize = true;
            showBalanceLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showBalanceLabel.Location = new Point(83, 373);
            showBalanceLabel.Name = "showBalanceLabel";
            showBalanceLabel.Size = new Size(121, 37);
            showBalanceLabel.TabIndex = 5;
            showBalanceLabel.Text = "Balance: ";
            // 
            // CashOutButton
            // 
            CashOutButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CashOutButton.Location = new Point(565, 364);
            CashOutButton.Name = "CashOutButton";
            CashOutButton.Size = new Size(156, 46);
            CashOutButton.TabIndex = 7;
            CashOutButton.Text = "CashOut";
            CashOutButton.UseVisualStyleBackColor = true;
            CashOutButton.Visible = false;
            CashOutButton.Click += CashOutButton_Click;
            // 
            // callHelpsButton
            // 
            callHelpsButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            callHelpsButton.Location = new Point(323, 370);
            callHelpsButton.Name = "callHelpsButton";
            callHelpsButton.Size = new Size(156, 46);
            callHelpsButton.TabIndex = 8;
            callHelpsButton.Text = "Helps";
            callHelpsButton.UseVisualStyleBackColor = true;
            // 
            // GamePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(callHelpsButton);
            Controls.Add(CashOutButton);
            Controls.Add(showBalanceLabel);
            Controls.Add(answerButton4);
            Controls.Add(answerButton3);
            Controls.Add(answerButton2);
            Controls.Add(answerButton1);
            Controls.Add(QuestionTextLabel);
            Name = "GamePage";
            Text = "GamePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label QuestionTextLabel;
        private Button answerButton1;
        private Button answerButton2;
        private Button answerButton3;
        private Button answerButton4;
        private Label showBalanceLabel;
        private Button CashOutButton;
        private Button callHelpsButton;
    }
}