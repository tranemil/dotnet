using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainterForm
{
    public partial class PainterForm : Form
    {
        private int BrushSize { get; set; }
        private SolidBrush BrushColor { get; set; }
        bool ShouldPaint { get; set; } = false;
        public PainterForm()
        {
            InitializeComponent();
        }

        private void ButtonType_CheckChanged(object sender, EventArgs e)
        {
            if (radioButtonRed.Checked)
                BrushColor = new SolidBrush(Color.Red);
            else if (radioButtonBlue.Checked)
                BrushColor = new SolidBrush(Color.Blue);
            else if (radioButtonBlack.Checked)
                BrushColor = new SolidBrush(Color.Black);
            else if (radioButtonGreen.Checked)
                BrushColor = new SolidBrush(Color.Green);
        }

        private void SizeButton_CheckChanged(object sender, EventArgs e)
        {
            BrushSize = 0;
            if (radioButtonSmall.Checked)
                BrushSize = 5;
            else if (radioButtonMedium.Checked)
                BrushSize = 10;
            else if (radioButtonLarge.Checked)
                BrushSize = 20;
        }

        private void CanvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (ShouldPaint)
            {
                using (Graphics graphics = CanvasPanel.CreateGraphics())
                {
                    if (BrushSize == 0)
                    {
                        ShouldPaint = false;
                        MessageBox.Show("Pick a brush size");
                    }
                    try
                    {
                        graphics.FillEllipse(BrushColor, e.X, e.Y, BrushSize, BrushSize);
                    }
                    catch (ArgumentNullException)
                    {
                        ShouldPaint = false;
                        MessageBox.Show("Pick a brush color");
                    }
                }
            }
        }

        private void CanvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ShouldPaint = true;
        }

        private void CanvasPanel_MouseUp(object sender, MouseEventArgs e)
        {
            ShouldPaint = false;
        }
    }
}
