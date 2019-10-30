using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingForm
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        public Form1()
        {
            InitializeComponent();
        }

        static Random number = new Random();

        public static int GenerateNumber(int min, int max)
        {
            return number.Next(min, max + 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            correctAnswer = GenerateNumber(1, 1000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int guess = int.Parse(guessTextBox.Text);

                if (guess == correctAnswer)
                {
                    BackColor = Color.Green;
                    guessLabel.Text = "Congratulations";
                    MessageBox.Show("Correct!");
                    this.guessTextBox.Enabled = false;
                    playAgainButton.Visible = true;
                    guessButton.Enabled = false;
                }
                else if (guess > correctAnswer)
                {
                    guessLabel.Text = "Too high";
                }
                else
                {
                    guessLabel.Text = "Too low";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter your guess");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            correctAnswer = GenerateNumber(1, 1000);
            guessTextBox.Enabled = true;
            playAgainButton.Visible = false;
            guessButton.Enabled = true;
            BackColor = Color.White;
            guessLabel.Text = "Please enter your guess";
            guessTextBox.Clear();
        }

        private void guessTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
