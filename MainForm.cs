using System;
using System.Drawing;
using System.Windows.Forms;

namespace LightsOut
{
    public partial class MainForm : Form
    {
        private LightsOutGame lightsOutGame;
        private const int GridOffset = 25;
        private const int GridLength = 200;
        private int CellLength;

        public MainForm()
        {
            InitializeComponent();
            this.lightsOutGame = new LightsOutGame();
            this.CellLength = GridLength / lightsOutGame.GridSize;
            this.lightsOutGame.NewGame();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGameButton_Click(sender, e);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int r = 0; r < this.lightsOutGame.GridSize; r++)
            {
                for (int c = 0; c < this.lightsOutGame.GridSize; c++)
                {
                    Brush brush;
                    Pen pen;
                    if (this.lightsOutGame.GetGridValue(r, c))
                    {
                        pen = Pens.Black;
                        brush = Brushes.White;
                    }
                    else
                    {
                        pen = Pens.White;
                        brush = Brushes.Black;
                    }
                    int x = c * CellLength + GridOffset;
                    int y = r * CellLength + GridOffset;
                    g.DrawRectangle(pen, x, y, CellLength, CellLength);
                    g.FillRectangle(brush, x + 1, y + 1, CellLength - 1, CellLength - 1);
                }
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X < GridOffset || e.X > CellLength * this.lightsOutGame.GridSize + GridOffset ||
            e.Y < GridOffset || e.Y > CellLength * this.lightsOutGame.GridSize + GridOffset)
                return;
            int r = (e.Y - GridOffset) / CellLength;
            int c = (e.X - GridOffset) / CellLength;

            this.lightsOutGame.Move(r, c);

            this.Invalidate();
            if (this.lightsOutGame.IsGameOver())
            {
                MessageBox.Show(this, "Congratulations! You've won!", "Lights Out!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            this.lightsOutGame.NewGame();
            this.Invalidate();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutBox = new AboutForm();
            aboutBox.ShowDialog(this);
        }
    }
}
