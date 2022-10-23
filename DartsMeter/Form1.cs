using System;
using System.Drawing;
using System.Windows.Forms;

namespace DartsMeter
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;  // Declaring beatmap

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.Height);  // Creating new bitmap
            pictureBox1.DrawToBitmap(bitmap, pictureBox1.ClientRectangle);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Color color = bitmap.GetPixel(e.X, e.Y);  // Gets pixel value from point where cursor is
        }
    }
}
