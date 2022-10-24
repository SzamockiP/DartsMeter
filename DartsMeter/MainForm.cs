using System;
using System.Drawing;
using System.Windows.Forms;

namespace DartsMeter
{
    public partial class MainForm : Form
    {
        Bitmap bitmap;  // Declaring beatmap

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Creating new bitmap
            bitmap = new Bitmap(Properties.Resources.tarcza_alfa,
                                new Size(PB_dartBoard.ClientSize.Width, PB_dartBoard.ClientSize.Height));  
        }

        private void PB_dartBoard_MouseClick(object sender, MouseEventArgs e)
        {
            Color color = bitmap.GetPixel(e.X, e.Y);  // Gets pixel value from point where cursor is

            // TODO: connect it with label counting points 
            Console.WriteLine(calculateCurrentPoint(color));
        }

        private string calculateCurrentPoint(Color color)  // Returns point value based on argb value
        {
            switch (color.A)  // switch is based on alpha value of pixel
            {
                case 255: return "single 20";
                case 253: return "single 1";
                case 250: return "single 18";
                case 248: return "single 4";
                case 246: return "single 13";
                case 244: return "single 6";
                case 242: return "single 10";
                case 239: return "single 15";
                case 237: return "single 2";
                case 235: return "single 17";
                case 233: return "single 3";
                case 231: return "single 19";
                case 229: return "single 7";
                case 226: return "single 16";
                case 224: return "single 8";
                case 222: return "single 11";
                case 220: return "single 14";
                case 218: return "single 9";
                case 216: return "single 12";
                case 214: return "single 5";
                case 212: return "double 20";
                case 210: return "double 1";
                case 208: return "double 18";
                case 206: return "double 4";
                case 204: return "double 13";
                case 202: return "double 6";
                case 200: return "double 10";
                case 198: return "double 15";
                case 196: return "double 2";
                case 194: return "double 17";
                case 192: return "double 3";
                case 190: return "double 19";
                case 188: return "double 7";
                case 186: return "double 16";
                case 184: return "double 8";
                case 183: return "double 11";
                case 181: return "double 14";
                case 179: return "double 9";
                case 177: return "double 12";
                case 175: return "double 5";
                case 173: return "triple 20";
                case 171: return "triple 1";
                case 170: return "triple 18";
                case 168: return "triple 4";
                case 166: return "triple 13";
                case 164: return "triple 6 ";
                case 163: return "triple 10";
                case 161: return "triple 15";
                case 159: return "triple 2";
                case 157: return "triple 17";
                case 156: return "triple 3";
                case 154: return "triple 19";
                case 152: return "triple 7";
                case 151: return "triple 16";
                case 149: return "triple 8";
                case 147: return "triple 11";
                case 146: return "triple 14";
                case 144: return "triple 9";
                case 142: return "triple 12";
                case 141: return "triple 5";
                case 139: return "single 25";
                case 138: return "double 25";
                case 136: return "miss 0";

                default: return "miss 0";
            }
        }
    }
}
