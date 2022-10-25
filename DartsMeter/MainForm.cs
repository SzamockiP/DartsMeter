using System;
using System.Drawing;
using System.Windows.Forms;

namespace DartsMeter
{
    public partial class MainForm : Form
    {

        public class Game // class of game round
        {
            public int playerOneScore = 501;
            public int playerTwoScore = 501;
            public int currentPlayerOneScore = 501;
            public int currentPlayerTwoScore = 501;

            public int tourScorePlayerOne = 0;
            public int tourScorePlayerTwo = 0;

            int playerOneThrows = 0;
            int playerTwoThrows = 0;
            int playerOneThrowSum = 0;
            int playerTwoThrowSum = 0;
            public int averageScorePlayerOne = 0;
            public int averageScorePlayerTwo = 0;

            bool playerOneTurn = true;  // bool to know whitch player takes move in current tour

            byte throws = 0;

            public int playerThrow(string throwValue, Label LBL_playerOne, Label LBL_playerTwo)
            {
                // declaration of variables and assigning values to them
                byte points;
                byte multiplier;

                switch (throwValue.Substring(0, 6))
                {
                    case "single": multiplier = 1; break;
                    case "double": multiplier = 2; break;
                    case "triple": multiplier = 3; break;

                    default: multiplier = 0; break;
                }

                

                points = byte.Parse(throwValue.Substring(7));

                // reset tour points counter
                if (throws == 0)
                {
                    if(playerOneTurn)
                        tourScorePlayerOne = 0;
                    else
                        tourScorePlayerTwo = 0;
                }

                throws++;  // add throw to counter

                if (playerOneTurn)
                {
                    playerOneThrows++;
                    playerOneThrowSum += (points * multiplier);

                    int calculatedScore = (currentPlayerOneScore - (points * multiplier));
                    
                    if (calculatedScore < 0 || calculatedScore == 1)  // overshoot
                    {
                        playerOneTurn = !playerOneTurn;
                        throws = 0;
                        tourScorePlayerOne = 0;
                        currentPlayerOneScore = playerOneScore;
                        LBL_playerOne.Text = currentPlayerOneScore.ToString();

                        return 0;
                    }

                    else if (calculatedScore == 0 && multiplier == 2)
                    {
                        // remove points from player
                        currentPlayerOneScore = calculatedScore;
                        tourScorePlayerOne += (points * multiplier);
                        LBL_playerOne.Text = currentPlayerOneScore.ToString();

                        return 1;
                    }
                    
                    
                    // remove points from player
                    currentPlayerOneScore = calculatedScore;
                    tourScorePlayerOne += (points * multiplier);              
                    
                    LBL_playerOne.Text = currentPlayerOneScore.ToString();

                }
                else
                {
                    playerTwoThrows++;
                    playerTwoThrowSum += (points * multiplier);

                    int calculatedScore = (currentPlayerTwoScore - (points * multiplier));
                    
                    if (calculatedScore < 0 || calculatedScore == 1)  // overshoot
                    {
                        playerOneTurn = !playerOneTurn;
                        throws = 0;
                        tourScorePlayerTwo = 0;
                        currentPlayerTwoScore = playerTwoScore;
                        LBL_playerTwo.Text = currentPlayerTwoScore.ToString();

                        return 0;
                    }

                    else if (calculatedScore == 0 && multiplier == 2)
                    {
                        // remove points from player
                        currentPlayerTwoScore = calculatedScore;
                        tourScorePlayerTwo += (points * multiplier);
                        LBL_playerTwo.Text = currentPlayerTwoScore.ToString();

                        return 2;
                    }
                    
                    // remove points from player
                    currentPlayerTwoScore = calculatedScore;
                    tourScorePlayerTwo += (points * multiplier);
                
                    LBL_playerTwo.Text = currentPlayerTwoScore.ToString();

                }

                // Console.WriteLine(points.ToString() + multiplier.ToString());

                // after three throws change player and add points
                if (throws >= 3)
                {
                    playerOneScore = currentPlayerOneScore;
                    playerTwoScore = currentPlayerTwoScore;

                    playerOneTurn = !playerOneTurn;

                    throws = 0;
                }
                
                // if check to prevent division by zero
                if (playerOneThrows >= 1)
                    averageScorePlayerOne = (playerOneThrowSum / playerOneThrows);

                if (playerTwoThrows >= 1)
                    averageScorePlayerTwo = (playerTwoThrowSum / playerTwoThrows);
                return 0;
            }
        }


        Bitmap bitmap;  // Declaring beatmap
        Game game;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Creating new bitmap
            bitmap = new Bitmap(Properties.Resources.tarcza_alfa,
                                new Size(PB_dartBoard.ClientSize.Width, PB_dartBoard.ClientSize.Height));
            
            // Creating instance of game
            // TODO: assign this to button that is menaging game
            game = new Game();
        }

        private void PB_dartBoard_MouseClick(object sender, MouseEventArgs e)
        {
            Color color = bitmap.GetPixel(e.X, e.Y);  // Gets pixel value from point where cursor is

            string throwValue;

            switch (color.A)  // switch is based on alpha value of pixel
            {
                case 255: throwValue = "single 20"; break;
                case 253: throwValue = "single 1"; break;
                case 250: throwValue = "single 18"; break;
                case 248: throwValue = "single 4"; break;
                case 246: throwValue = "single 13"; break;
                case 244: throwValue = "single 6"; break;
                case 242: throwValue = "single 10"; break;
                case 239: throwValue = "single 15"; break;
                case 237: throwValue = "single 2"; break;
                case 235: throwValue = "single 17"; break;
                case 233: throwValue = "single 3"; break;
                case 231: throwValue = "single 19"; break;
                case 229: throwValue = "single 7"; break;
                case 226: throwValue = "single 16"; break;
                case 224: throwValue = "single 8"; break;
                case 222: throwValue = "single 11"; break;
                case 220: throwValue = "single 14"; break;
                case 218: throwValue = "single 9"; break;
                case 216: throwValue = "single 12"; break;
                case 214: throwValue = "single 5"; break;
                case 212: throwValue = "double 20"; break;
                case 210: throwValue = "double 1"; break;
                case 208: throwValue = "double 18"; break;
                case 206: throwValue = "double 4"; break;
                case 204: throwValue = "double 13"; break;
                case 202: throwValue = "double 6"; break;
                case 200: throwValue = "double 10"; break;
                case 198: throwValue = "double 15"; break;
                case 196: throwValue = "double 2"; break;
                case 194: throwValue = "double 17"; break;
                case 192: throwValue = "double 3"; break;
                case 190: throwValue = "double 19"; break;
                case 188: throwValue = "double 7"; break;
                case 186: throwValue = "double 16"; break;
                case 184: throwValue = "double 8"; break;
                case 183: throwValue = "double 11"; break;
                case 181: throwValue = "double 14"; break;
                case 179: throwValue = "double 9"; break;
                case 177: throwValue = "double 12"; break;
                case 175: throwValue = "double 5"; break;
                case 173: throwValue = "triple 20"; break;
                case 171: throwValue = "triple 1"; break;
                case 170: throwValue = "triple 18"; break;
                case 168: throwValue = "triple 4"; break;
                case 166: throwValue = "triple 13"; break;
                case 164: throwValue = "triple 6 "; break;
                case 163: throwValue = "triple 10"; break;
                case 161: throwValue = "triple 15"; break;
                case 159: throwValue = "triple 2"; break;
                case 157: throwValue = "triple 17"; break;
                case 156: throwValue = "triple 3"; break;
                case 154: throwValue = "triple 19"; break;
                case 152: throwValue = "triple 7"; break;
                case 151: throwValue = "triple 16"; break;
                case 149: throwValue = "triple 8"; break;
                case 147: throwValue = "triple 11"; break;
                case 146: throwValue = "triple 14"; break;
                case 144: throwValue = "triple 9"; break;
                case 142: throwValue = "triple 12"; break;
                case 141: throwValue = "triple 5"; break;
                case 139: throwValue = "single 25"; break;
                case 138: throwValue = "double 25"; break;
                case 136: throwValue = "missed 0"; break;

                default: throwValue = "missed 0"; break;
            }

            int whoWon = game.playerThrow(throwValue, LBL_PointsPlayerOne, LBL_PointsPlayerTwo);
            LBL_tourPointsPlayerOne.Text = game.tourScorePlayerOne.ToString();
            LBL_tourPointsPlayerTwo.Text = game.tourScorePlayerTwo.ToString();
            LBL_averagePointsPlayerOne.Text = game.averageScorePlayerOne.ToString();
            LBL_averagePointsPlayerTwo.Text = game.averageScorePlayerTwo.ToString();
            if (whoWon == 1) Console.WriteLine("Wygral gracz 1");
            else if(whoWon == 2) Console.WriteLine("Wygral gracz 2");
        }
    }
}
