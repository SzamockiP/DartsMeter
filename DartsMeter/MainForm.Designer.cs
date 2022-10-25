namespace DartsMeter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PB_dartBoard = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.LBL_PointsPlayerOne = new System.Windows.Forms.Label();
            this.MNS_navBar = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zasadyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoliniaSamobójczaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zacznijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozpocznijOdNowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LBL_PointsPlayerTwo = new System.Windows.Forms.Label();
            this.TXB_NamePlayerOne = new System.Windows.Forms.TextBox();
            this.TXB_NamePlayerTwo = new System.Windows.Forms.TextBox();
            this.BTN_gameControl = new System.Windows.Forms.Button();
            this.GPB_playerOne = new System.Windows.Forms.GroupBox();
            this.LBL_averagePointsPlayerOne = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBL_tourPointsPlayerOne = new System.Windows.Forms.Label();
            this.GPB_playerTwo = new System.Windows.Forms.GroupBox();
            this.LBL_averagePointsPlayerTwo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBL_tourPointsPlayerTwo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_dartBoard)).BeginInit();
            this.MNS_navBar.SuspendLayout();
            this.GPB_playerOne.SuspendLayout();
            this.GPB_playerTwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB_dartBoard
            // 
            this.PB_dartBoard.BackColor = System.Drawing.Color.Transparent;
            this.PB_dartBoard.Cursor = System.Windows.Forms.Cursors.Cross;
            this.PB_dartBoard.Image = global::DartsMeter.Properties.Resources.tarcza_bezalfy;
            this.PB_dartBoard.Location = new System.Drawing.Point(339, 153);
            this.PB_dartBoard.Margin = new System.Windows.Forms.Padding(4);
            this.PB_dartBoard.Name = "PB_dartBoard";
            this.PB_dartBoard.Size = new System.Drawing.Size(500, 500);
            this.PB_dartBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_dartBoard.TabIndex = 0;
            this.PB_dartBoard.TabStop = false;
            this.PB_dartBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PB_dartBoard_MouseClick);
            // 
            // LBL_PointsPlayerOne
            // 
            this.LBL_PointsPlayerOne.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_PointsPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_PointsPlayerOne.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LBL_PointsPlayerOne.Location = new System.Drawing.Point(345, 76);
            this.LBL_PointsPlayerOne.Name = "LBL_PointsPlayerOne";
            this.LBL_PointsPlayerOne.Size = new System.Drawing.Size(150, 100);
            this.LBL_PointsPlayerOne.TabIndex = 1;
            this.LBL_PointsPlayerOne.Text = "501";
            this.LBL_PointsPlayerOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MNS_navBar
            // 
            this.MNS_navBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MNS_navBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.pomocToolStripMenuItem,
            this.graToolStripMenuItem});
            this.MNS_navBar.Location = new System.Drawing.Point(0, 0);
            this.MNS_navBar.Name = "MNS_navBar";
            this.MNS_navBar.Size = new System.Drawing.Size(1157, 24);
            this.MNS_navBar.TabIndex = 2;
            this.MNS_navBar.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wczytajToolStripMenuItem,
            this.zapiszToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // wczytajToolStripMenuItem
            // 
            this.wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            this.wczytajToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.wczytajToolStripMenuItem.Text = "Wczytaj";
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zasadyToolStripMenuItem,
            this.infoliniaSamobójczaToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // zasadyToolStripMenuItem
            // 
            this.zasadyToolStripMenuItem.Name = "zasadyToolStripMenuItem";
            this.zasadyToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.zasadyToolStripMenuItem.Text = "Zasady";
            // 
            // infoliniaSamobójczaToolStripMenuItem
            // 
            this.infoliniaSamobójczaToolStripMenuItem.Name = "infoliniaSamobójczaToolStripMenuItem";
            this.infoliniaSamobójczaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.infoliniaSamobójczaToolStripMenuItem.Text = "Infolinia samobójcza";
            // 
            // graToolStripMenuItem
            // 
            this.graToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zacznijToolStripMenuItem,
            this.rozpocznijOdNowaToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.graToolStripMenuItem.Name = "graToolStripMenuItem";
            this.graToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.graToolStripMenuItem.Text = "Gra";
            // 
            // zacznijToolStripMenuItem
            // 
            this.zacznijToolStripMenuItem.Name = "zacznijToolStripMenuItem";
            this.zacznijToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zacznijToolStripMenuItem.Text = "Zacznij";
            // 
            // rozpocznijOdNowaToolStripMenuItem
            // 
            this.rozpocznijOdNowaToolStripMenuItem.Name = "rozpocznijOdNowaToolStripMenuItem";
            this.rozpocznijOdNowaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rozpocznijOdNowaToolStripMenuItem.Text = "Rozpocznij od nowa";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            // 
            // LBL_PointsPlayerTwo
            // 
            this.LBL_PointsPlayerTwo.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_PointsPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_PointsPlayerTwo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LBL_PointsPlayerTwo.Location = new System.Drawing.Point(680, 76);
            this.LBL_PointsPlayerTwo.Name = "LBL_PointsPlayerTwo";
            this.LBL_PointsPlayerTwo.Size = new System.Drawing.Size(150, 100);
            this.LBL_PointsPlayerTwo.TabIndex = 3;
            this.LBL_PointsPlayerTwo.Text = "501";
            this.LBL_PointsPlayerTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXB_NamePlayerOne
            // 
            this.TXB_NamePlayerOne.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.TXB_NamePlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TXB_NamePlayerOne.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TXB_NamePlayerOne.Location = new System.Drawing.Point(339, 36);
            this.TXB_NamePlayerOne.Name = "TXB_NamePlayerOne";
            this.TXB_NamePlayerOne.Size = new System.Drawing.Size(170, 37);
            this.TXB_NamePlayerOne.TabIndex = 4;
            this.TXB_NamePlayerOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXB_NamePlayerTwo
            // 
            this.TXB_NamePlayerTwo.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.TXB_NamePlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TXB_NamePlayerTwo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TXB_NamePlayerTwo.Location = new System.Drawing.Point(669, 36);
            this.TXB_NamePlayerTwo.Name = "TXB_NamePlayerTwo";
            this.TXB_NamePlayerTwo.Size = new System.Drawing.Size(170, 37);
            this.TXB_NamePlayerTwo.TabIndex = 5;
            this.TXB_NamePlayerTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_gameControl
            // 
            this.BTN_gameControl.BackColor = System.Drawing.Color.Crimson;
            this.BTN_gameControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTN_gameControl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTN_gameControl.Location = new System.Drawing.Point(523, 96);
            this.BTN_gameControl.Name = "BTN_gameControl";
            this.BTN_gameControl.Size = new System.Drawing.Size(130, 50);
            this.BTN_gameControl.TabIndex = 6;
            this.BTN_gameControl.Text = "button1";
            this.BTN_gameControl.UseVisualStyleBackColor = false;
            // 
            // GPB_playerOne
            // 
            this.GPB_playerOne.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.GPB_playerOne.Controls.Add(this.label1);
            this.GPB_playerOne.Controls.Add(this.LBL_averagePointsPlayerOne);
            this.GPB_playerOne.Controls.Add(this.label4);
            this.GPB_playerOne.Controls.Add(this.LBL_tourPointsPlayerOne);
            this.GPB_playerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GPB_playerOne.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GPB_playerOne.Location = new System.Drawing.Point(49, 197);
            this.GPB_playerOne.Name = "GPB_playerOne";
            this.GPB_playerOne.Size = new System.Drawing.Size(267, 322);
            this.GPB_playerOne.TabIndex = 7;
            this.GPB_playerOne.TabStop = false;
            this.GPB_playerOne.Text = "Statystyki gracza1";
            // 
            // LBL_averagePointsPlayerOne
            // 
            this.LBL_averagePointsPlayerOne.AutoSize = true;
            this.LBL_averagePointsPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_averagePointsPlayerOne.Location = new System.Drawing.Point(65, 206);
            this.LBL_averagePointsPlayerOne.Name = "LBL_averagePointsPlayerOne";
            this.LBL_averagePointsPlayerOne.Size = new System.Drawing.Size(151, 108);
            this.LBL_averagePointsPlayerOne.TabIndex = 3;
            this.LBL_averagePointsPlayerOne.Text = "30";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(6, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Średnia punktów gracza";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_tourPointsPlayerOne
            // 
            this.LBL_tourPointsPlayerOne.AutoSize = true;
            this.LBL_tourPointsPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_tourPointsPlayerOne.Location = new System.Drawing.Point(65, 72);
            this.LBL_tourPointsPlayerOne.Name = "LBL_tourPointsPlayerOne";
            this.LBL_tourPointsPlayerOne.Size = new System.Drawing.Size(151, 108);
            this.LBL_tourPointsPlayerOne.TabIndex = 1;
            this.LBL_tourPointsPlayerOne.Text = "46";
            // 
            // GPB_playerTwo
            // 
            this.GPB_playerTwo.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.GPB_playerTwo.Controls.Add(this.LBL_averagePointsPlayerTwo);
            this.GPB_playerTwo.Controls.Add(this.label6);
            this.GPB_playerTwo.Controls.Add(this.LBL_tourPointsPlayerTwo);
            this.GPB_playerTwo.Controls.Add(this.label8);
            this.GPB_playerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GPB_playerTwo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GPB_playerTwo.Location = new System.Drawing.Point(862, 197);
            this.GPB_playerTwo.Name = "GPB_playerTwo";
            this.GPB_playerTwo.Size = new System.Drawing.Size(267, 322);
            this.GPB_playerTwo.TabIndex = 8;
            this.GPB_playerTwo.TabStop = false;
            this.GPB_playerTwo.Text = "Statystyki gracza2";
            // 
            // LBL_averagePointsPlayerTwo
            // 
            this.LBL_averagePointsPlayerTwo.AutoSize = true;
            this.LBL_averagePointsPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_averagePointsPlayerTwo.Location = new System.Drawing.Point(65, 206);
            this.LBL_averagePointsPlayerTwo.Name = "LBL_averagePointsPlayerTwo";
            this.LBL_averagePointsPlayerTwo.Size = new System.Drawing.Size(151, 108);
            this.LBL_averagePointsPlayerTwo.TabIndex = 3;
            this.LBL_averagePointsPlayerTwo.Text = "25";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(11, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "Średnia punktów gracza ";
            // 
            // LBL_tourPointsPlayerTwo
            // 
            this.LBL_tourPointsPlayerTwo.AutoSize = true;
            this.LBL_tourPointsPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_tourPointsPlayerTwo.Location = new System.Drawing.Point(65, 69);
            this.LBL_tourPointsPlayerTwo.Name = "LBL_tourPointsPlayerTwo";
            this.LBL_tourPointsPlayerTwo.Size = new System.Drawing.Size(151, 108);
            this.LBL_tourPointsPlayerTwo.TabIndex = 1;
            this.LBL_tourPointsPlayerTwo.Text = "34";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(11, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Punkty w ostatniej turze";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Punkty w ostatniej turze";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1157, 657);
            this.Controls.Add(this.GPB_playerTwo);
            this.Controls.Add(this.GPB_playerOne);
            this.Controls.Add(this.BTN_gameControl);
            this.Controls.Add(this.TXB_NamePlayerTwo);
            this.Controls.Add(this.TXB_NamePlayerOne);
            this.Controls.Add(this.LBL_PointsPlayerTwo);
            this.Controls.Add(this.LBL_PointsPlayerOne);
            this.Controls.Add(this.PB_dartBoard);
            this.Controls.Add(this.MNS_navBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MNS_navBar;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "DartsMeter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_dartBoard)).EndInit();
            this.MNS_navBar.ResumeLayout(false);
            this.MNS_navBar.PerformLayout();
            this.GPB_playerOne.ResumeLayout(false);
            this.GPB_playerOne.PerformLayout();
            this.GPB_playerTwo.ResumeLayout(false);
            this.GPB_playerTwo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_dartBoard;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label LBL_PointsPlayerOne;
        private System.Windows.Forms.MenuStrip MNS_navBar;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zasadyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoliniaSamobójczaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zacznijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozpocznijOdNowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.Label LBL_PointsPlayerTwo;
        private System.Windows.Forms.TextBox TXB_NamePlayerOne;
        private System.Windows.Forms.TextBox TXB_NamePlayerTwo;
        private System.Windows.Forms.Button BTN_gameControl;
        private System.Windows.Forms.GroupBox GPB_playerOne;
        private System.Windows.Forms.Label LBL_averagePointsPlayerOne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBL_tourPointsPlayerOne;
        private System.Windows.Forms.GroupBox GPB_playerTwo;
        private System.Windows.Forms.Label LBL_averagePointsPlayerTwo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBL_tourPointsPlayerTwo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}

