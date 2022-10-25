using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DartsMeter
{
    public partial class MainForm : Form
    {
        // class of whole game
        public class Game 
        {
            public bool refreshDrawing = false;
            public bool gameFinished = false;
            public byte winningPlayer = 0;
            public string playerOneName = "Player one";
            public string playerTwoName = "Player two";

            public int playerOneScore = 501;
            public int playerTwoScore = 501;
            public int currentPlayerOneScore = 501;
            public int currentPlayerTwoScore = 501;

            public int tourScorePlayerOne = 0;
            public int tourScorePlayerTwo = 0;

            public int playerOneThrows = 0;
            public int playerTwoThrows = 0;
            public int playerOneThrowSum = 0;
            public int playerTwoThrowSum = 0;
            public int averageScorePlayerOne = 0;
            public int averageScorePlayerTwo = 0;

            public bool playerOneTurn = true;  // bool to know whitch player takes move in current tour

            public byte throws = 0;

            public int playerThrow(string throwValue, Label LBL_playerOne, Label LBL_playerTwo)
            {
                if (gameFinished) return winningPlayer;
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
                        refreshDrawing = true;

                        return 0;
                    }

                    else if (calculatedScore == 0 && multiplier == 2)  // winning condition
                    {
                        // remove points from player
                        currentPlayerOneScore = calculatedScore;
                        tourScorePlayerOne += (points * multiplier);
                        LBL_playerOne.Text = currentPlayerOneScore.ToString();

                        refreshDrawing = true;
                        winningPlayer = 1;
                        gameFinished = true;
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
                        refreshDrawing = true;
                        return 0;
                    }

                    else if (calculatedScore == 0 && multiplier == 2)  // winning condition
                    {
                        // remove points from player
                        currentPlayerTwoScore = calculatedScore;
                        tourScorePlayerTwo += (points * multiplier);
                        LBL_playerTwo.Text = currentPlayerTwoScore.ToString();

                        refreshDrawing = true;
                        winningPlayer = 2;
                        gameFinished = true;
                        return 2;
                    }
                    
                    // remove points from player
                    currentPlayerTwoScore = calculatedScore;
                    tourScorePlayerTwo += (points * multiplier);
                
                    LBL_playerTwo.Text = currentPlayerTwoScore.ToString();

                }

                // after three throws change player and add points
                if (throws >= 3)
                {
                    playerOneScore = currentPlayerOneScore;
                    playerTwoScore = currentPlayerTwoScore;

                    playerOneTurn = !playerOneTurn;

                    throws = 0;
                    refreshDrawing = true;
                }
                
                // if check to prevent division by zero
                if (playerOneThrows >= 1)
                    averageScorePlayerOne = (playerOneThrowSum / playerOneThrows);

                if (playerTwoThrows >= 1)
                    averageScorePlayerTwo = (playerTwoThrowSum / playerTwoThrows);
                return 0;
            }
        }

        // declaring important variables
        Bitmap bitmap;
        Game game;

        bool PB_dartBoard_MouseClick_Enabled = false;

        // constructor of MainForm
        public MainForm()
        {
            InitializeComponent();
        }

        // load function
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Creating new bitmap
            bitmap = new Bitmap(Properties.Resources.tarcza_alfa,
                                new Size(PB_dartBoard.ClientSize.Width, PB_dartBoard.ClientSize.Height));

            resetUI();
            TXB_NamePlayerOne.Text = "Player 1";
            TXB_NamePlayerTwo.Text = "Player 2";
        }

        // function runs when dart is clicked
        private void PB_dartBoard_MouseClick(object sender, MouseEventArgs e)
        {
            if (!PB_dartBoard_MouseClick_Enabled) return;
            if (game.refreshDrawing == true)
            {
                PB_dartBoard.Refresh();
                game.refreshDrawing = false;
            }
            Color color = bitmap.GetPixel(e.X, e.Y);  // Gets pixel value from point where cursor is

            if (!game.gameFinished)
            {
                using (Graphics g = PB_dartBoard.CreateGraphics())
                {
                    var pen = new Pen(Color.DeepSkyBlue, 4);
                    g.DrawEllipse(pen, e.X - 5, e.Y - 5, 5, 5);

                    pen.Dispose();
                }
            }
            else
                PB_dartBoard.Refresh();
            
            

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

            
            // sets points from game data to labels
            LBL_tourPointsPlayerOne.Text = game.tourScorePlayerOne.ToString();
            LBL_tourPointsPlayerTwo.Text = game.tourScorePlayerTwo.ToString();
            LBL_averagePointsPlayerOne.Text = game.averageScorePlayerOne.ToString();
            LBL_averagePointsPlayerTwo.Text = game.averageScorePlayerTwo.ToString();

            // if game finishes, it shows it
            if (whoWon == 1)
            {
                string message = "Wygrał " + game.playerOneName + "!";
                string title = "Koniec gry";
                MessageBox.Show(message, title);
            }
            else if (whoWon == 2)
            {
                string message = "Wygrał " + game.playerTwoName + "!";
                string title = "Koniec gry";
                MessageBox.Show(message, title);
            }
        }

        // loads data from file
        private void wczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // if game does not exists, make one
            if(!(game != null))
            {
                game = new Game();
                PB_dartBoard_MouseClick_Enabled = true;
                BTN_gameControl.Text = "Zakończ";
                TXB_NamePlayerOne.Enabled = false;
                TXB_NamePlayerTwo.Enabled = false;
            }

            // open dialog to choose which file to read
            OpenFileDialog dialogWindow = new OpenFileDialog();
            dialogWindow.Title = "Open Text File";
            dialogWindow.Filter = "TXT files|*.txt";
            dialogWindow.InitialDirectory = @"C:\";
            if (dialogWindow.ShowDialog() == DialogResult.OK)
            {
                try  // inputs data
                {
                    string filename = dialogWindow.FileName;

                    string[] filelines = File.ReadAllLines(filename);

                    // game data
                    game.gameFinished = bool.Parse(filelines[0]);
                    game.winningPlayer = byte.Parse(filelines[1]);
                    game.playerOneName = filelines[2];
                    game.playerTwoName = filelines[3];

                    game.playerOneScore = int.Parse(filelines[4]);
                    game.playerTwoScore = int.Parse(filelines[5]);
                    game.currentPlayerOneScore = int.Parse(filelines[6]);
                    game.currentPlayerTwoScore = int.Parse(filelines[7]);

                    game.tourScorePlayerOne = int.Parse(filelines[8]);
                    game.tourScorePlayerTwo = int.Parse(filelines[9]);

                    game.playerOneThrows = int.Parse(filelines[10]);
                    game.playerTwoThrows = int.Parse(filelines[11]);
                    game.playerOneThrowSum = int.Parse(filelines[12]);
                    game.playerTwoThrowSum = int.Parse(filelines[13]);
                    game.averageScorePlayerOne = int.Parse(filelines[14]);
                    game.averageScorePlayerTwo = int.Parse(filelines[15]);

                    game.playerOneTurn = bool.Parse(filelines[16]);
                    game.throws = byte.Parse(filelines[17]);

                    // user interfrace data
                    LBL_PointsPlayerOne.Text = filelines[18];
                    LBL_PointsPlayerTwo.Text = filelines[19];
                    LBL_tourPointsPlayerOne.Text = filelines[20];
                    LBL_tourPointsPlayerTwo.Text = filelines[21];
                    LBL_averagePointsPlayerOne.Text = filelines[22];
                    LBL_averagePointsPlayerTwo.Text = filelines[23];
                    TXB_NamePlayerOne.Text = filelines[2];
                    TXB_NamePlayerTwo.Text = filelines[3];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // saves data to file

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // if game does not exists, make one
            if (!(game != null))
            {
                string message = "Nie można zapisać nierozpoczętej gry.";
                string title = "Błąd";
                MessageBox.Show(message, title);
                return;
            }

            // opens dialog to choose where to save the file
            SaveFileDialog save = new SaveFileDialog();

            save.FileName = "GameSave_DartMeter.txt";

            save.Filter = "Text File | *.txt";

            // writes data into the file
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                // game data
                writer.WriteLine(game.gameFinished.ToString());
                writer.WriteLine(game.winningPlayer.ToString());
                writer.WriteLine(game.playerOneName.ToString());
                writer.WriteLine(game.playerTwoName.ToString());

                writer.WriteLine(game.playerOneScore.ToString());
                writer.WriteLine(game.playerTwoScore.ToString());
                writer.WriteLine(game.currentPlayerOneScore.ToString());
                writer.WriteLine(game.currentPlayerTwoScore.ToString());

                writer.WriteLine(game.tourScorePlayerOne.ToString());
                writer.WriteLine(game.tourScorePlayerTwo.ToString());

                writer.WriteLine(game.playerOneThrows.ToString());
                writer.WriteLine(game.playerTwoThrows.ToString());
                writer.WriteLine(game.playerOneThrowSum.ToString());
                writer.WriteLine(game.playerTwoThrowSum.ToString());
                writer.WriteLine(game.averageScorePlayerOne.ToString());
                writer.WriteLine(game.averageScorePlayerTwo.ToString());

                writer.WriteLine(game.playerOneTurn.ToString());
                writer.WriteLine(game.throws.ToString());
                // user interfrace data
                writer.WriteLine(LBL_PointsPlayerOne.Text);
                writer.WriteLine(LBL_PointsPlayerTwo.Text);
                writer.WriteLine(LBL_tourPointsPlayerOne.Text);
                writer.WriteLine(LBL_tourPointsPlayerTwo.Text);
                writer.WriteLine(LBL_averagePointsPlayerOne.Text);
                writer.WriteLine(LBL_averagePointsPlayerTwo.Text);

                writer.Dispose();
                writer.Close();

            }
        }

        // displays rules
        private void zasadyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Najpopularniejsza, a zarazem najprostsza odmiana gry dart, czyli Dart 501." +
                "\nJak w każdej odmianie gry, podstawą jest rzucanie lotkami do tarczy. Powszechna jest ona wśród graczy zawodowych, jak i tych, którzy dopiero zaczynają przygodę z rzutkami." +
                "\nKażdy gracz zaczyna z wynikiem 501 punktów i na zmianę rzuca 3 rzutkami. Wynik za każdą turę jest obliczany i odejmowany od wyniku graczy." +
                "\nCelem rozgrywki jest bycie pierwszym graczem, który zejdzie do “zera”. Aby zakończyć rundę, trzeba trafić pole podwójne." +
                "\nGdyby graczowi nr 1 brakowało 32 pkt do zejścia do “zera”, musiałby on rzucić podwójne 16." +
                "\nW przypadku, w którym gracz przekroczy liczbę punktów potrzebnych do skończenia, jego punkty zostają takie same jak na początku tury.";
            string title = "Zasady";
            MessageBox.Show(message, title);
        }

        // please help me, im sitting on this project 8th hour right now
        private void infoliniaSamobójczaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Po tym projekcie nie wiem, czy da się nam jeszcze pomóc.";
            string title = "Infolinia samobójcza";
            MessageBox.Show(message, title);
        }

        // begin new game and enable board
        private void zacznijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetUI();
            game = new Game();
            game.playerOneName = TXB_NamePlayerOne.Text;
            game.playerTwoName = TXB_NamePlayerTwo.Text;
            PB_dartBoard_MouseClick_Enabled = true;
            TXB_NamePlayerOne.Enabled = false;
            TXB_NamePlayerTwo.Enabled = false;
            BTN_gameControl.Text = "Zakończ";
        }

        // finish the game and disable board
        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetUI();
            game = null;
            TXB_NamePlayerOne.Text = "Player 1";
            TXB_NamePlayerTwo.Text = "Player 2";
            PB_dartBoard_MouseClick_Enabled = false;
            TXB_NamePlayerOne.Enabled = true;
            TXB_NamePlayerTwo.Enabled = true;
            BTN_gameControl.Text = "Zacznij";
        }

        // does the same as two functions above, but with one button
        private void BTN_gameControl_Click(object sender, EventArgs e)
        {
            if (PB_dartBoard_MouseClick_Enabled)
            {
                resetUI();
                game = null;
                TXB_NamePlayerOne.Text = "Player 1";
                TXB_NamePlayerTwo.Text = "Player 2";
                PB_dartBoard_MouseClick_Enabled = false;
                TXB_NamePlayerOne.Enabled = true;
                TXB_NamePlayerTwo.Enabled = true;
                BTN_gameControl.Text = "Zacznij";
            }
            else
            {
                resetUI();
                game = new Game();
                game.playerOneName = TXB_NamePlayerOne.Text;
                game.playerTwoName = TXB_NamePlayerTwo.Text;
                PB_dartBoard_MouseClick_Enabled = true;
                TXB_NamePlayerOne.Enabled = false;
                TXB_NamePlayerTwo.Enabled = false;
                BTN_gameControl.Text = "Zakończ";
            }
        }

        // resets data in ui
        private void resetUI()
        {
            LBL_PointsPlayerOne.Text = "501";
            LBL_PointsPlayerTwo.Text = "501";
            LBL_tourPointsPlayerOne.Text = "0";
            LBL_tourPointsPlayerTwo.Text = "0";
            LBL_averagePointsPlayerOne.Text = "0";
            LBL_averagePointsPlayerTwo.Text = "0";
        }
    }
}
