namespace NumberGuessingForm
{
    partial class Form1
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
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.guessLabel = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guessTextBox
            // 
            this.guessTextBox.Location = new System.Drawing.Point(285, 45);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(100, 20);
            this.guessTextBox.TabIndex = 0;
            this.guessTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guessTextBox_KeyDown);
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Location = new System.Drawing.Point(168, 94);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(120, 13);
            this.guessLabel.TabIndex = 1;
            this.guessLabel.Text = "Please enter your guess";
            // 
            // guessButton
            // 
            this.guessButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guessButton.Location = new System.Drawing.Point(0, 163);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(466, 23);
            this.guessButton.TabIndex = 2;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "I have a number between 1-1000";
            // 
            // playAgainButton
            // 
            this.playAgainButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playAgainButton.Location = new System.Drawing.Point(0, 140);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(466, 23);
            this.playAgainButton.TabIndex = 5;
            this.playAgainButton.Text = "Play again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Visible = false;
            this.playAgainButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Can you guess the number?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 186);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.guessTextBox);
            this.Name = "Form1";
            this.Text = "Number guessing game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Label label1;
    }
}

