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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.LBL_PointsPlayerOne = new System.Windows.Forms.Label();
            this.MNS_navBar = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zasadyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoliniaSamobójczaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LBL_PointsPlayerTwo = new System.Windows.Forms.Label();
            this.TXB_NamePlayerOne = new System.Windows.Forms.TextBox();
            this.TXB_NamePlayerTwo = new System.Windows.Forms.TextBox();
            this.graToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zacznijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozpocznijOdNowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_gameControl = new System.Windows.Forms.Button();
            this.GPB_playerOne = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_tourPointsPlayerOne = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBL_averagePointsPlayerOne = new System.Windows.Forms.Label();
            this.GPB_playerTwo = new System.Windows.Forms.GroupBox();
            this.LBL_averagePointsPlayerTwo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBL_tourPointsPlayerTwo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MNS_navBar.SuspendLayout();
            this.GPB_playerOne.SuspendLayout();
            this.GPB_playerTwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DartsMeter.Properties.Resources.tarcza_bezalfy;
            this.pictureBox1.Location = new System.Drawing.Point(400, 149);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // LBL_PointsPlayerOne
            // 
            this.LBL_PointsPlayerOne.Cursor = System.Windows.Forms.Cursors.No;
            this.LBL_PointsPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_PointsPlayerOne.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBL_PointsPlayerOne.Location = new System.Drawing.Point(400, 45);
            this.LBL_PointsPlayerOne.Name = "LBL_PointsPlayerOne";
            this.LBL_PointsPlayerOne.Size = new System.Drawing.Size(121, 100);
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
            this.MNS_navBar.Size = new System.Drawing.Size(1282, 30);
            this.MNS_navBar.TabIndex = 2;
            this.MNS_navBar.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wczytajToolStripMenuItem,
            this.zapiszToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // wczytajToolStripMenuItem
            // 
            this.wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            this.wczytajToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.wczytajToolStripMenuItem.Text = "Wczytaj";
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zasadyToolStripMenuItem,
            this.infoliniaSamobójczaToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // zasadyToolStripMenuItem
            // 
            this.zasadyToolStripMenuItem.Name = "zasadyToolStripMenuItem";
            this.zasadyToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.zasadyToolStripMenuItem.Text = "Zasady";
            // 
            // infoliniaSamobójczaToolStripMenuItem
            // 
            this.infoliniaSamobójczaToolStripMenuItem.Name = "infoliniaSamobójczaToolStripMenuItem";
            this.infoliniaSamobójczaToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.infoliniaSamobójczaToolStripMenuItem.Text = "Infolinia samobójcza";
            // 
            // LBL_PointsPlayerTwo
            // 
            this.LBL_PointsPlayerTwo.Cursor = System.Windows.Forms.Cursors.No;
            this.LBL_PointsPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_PointsPlayerTwo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBL_PointsPlayerTwo.Location = new System.Drawing.Point(791, 45);
            this.LBL_PointsPlayerTwo.Name = "LBL_PointsPlayerTwo";
            this.LBL_PointsPlayerTwo.Size = new System.Drawing.Size(121, 100);
            this.LBL_PointsPlayerTwo.TabIndex = 3;
            this.LBL_PointsPlayerTwo.Text = "501";
            this.LBL_PointsPlayerTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXB_NamePlayerOne
            // 
            this.TXB_NamePlayerOne.Location = new System.Drawing.Point(409, 31);
            this.TXB_NamePlayerOne.Name = "TXB_NamePlayerOne";
            this.TXB_NamePlayerOne.Size = new System.Drawing.Size(100, 22);
            this.TXB_NamePlayerOne.TabIndex = 4;
            // 
            // TXB_NamePlayerTwo
            // 
            this.TXB_NamePlayerTwo.Location = new System.Drawing.Point(800, 31);
            this.TXB_NamePlayerTwo.Name = "TXB_NamePlayerTwo";
            this.TXB_NamePlayerTwo.Size = new System.Drawing.Size(100, 22);
            this.TXB_NamePlayerTwo.TabIndex = 5;
            // 
            // graToolStripMenuItem
            // 
            this.graToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zacznijToolStripMenuItem,
            this.rozpocznijOdNowaToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.graToolStripMenuItem.Name = "graToolStripMenuItem";
            this.graToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.graToolStripMenuItem.Text = "Gra";
            // 
            // zacznijToolStripMenuItem
            // 
            this.zacznijToolStripMenuItem.Name = "zacznijToolStripMenuItem";
            this.zacznijToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.zacznijToolStripMenuItem.Text = "Zacznij";
            // 
            // rozpocznijOdNowaToolStripMenuItem
            // 
            this.rozpocznijOdNowaToolStripMenuItem.Name = "rozpocznijOdNowaToolStripMenuItem";
            this.rozpocznijOdNowaToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.rozpocznijOdNowaToolStripMenuItem.Text = "Rozpocznij od nowa";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            // 
            // BTN_gameControl
            // 
            this.BTN_gameControl.Location = new System.Drawing.Point(610, 96);
            this.BTN_gameControl.Name = "BTN_gameControl";
            this.BTN_gameControl.Size = new System.Drawing.Size(75, 23);
            this.BTN_gameControl.TabIndex = 6;
            this.BTN_gameControl.Text = "button1";
            this.BTN_gameControl.UseVisualStyleBackColor = true;
            // 
            // GPB_playerOne
            // 
            this.GPB_playerOne.Controls.Add(this.LBL_averagePointsPlayerOne);
            this.GPB_playerOne.Controls.Add(this.label4);
            this.GPB_playerOne.Controls.Add(this.LBL_tourPointsPlayerOne);
            this.GPB_playerOne.Controls.Add(this.label3);
            this.GPB_playerOne.Location = new System.Drawing.Point(13, 180);
            this.GPB_playerOne.Name = "GPB_playerOne";
            this.GPB_playerOne.Size = new System.Drawing.Size(326, 461);
            this.GPB_playerOne.TabIndex = 7;
            this.GPB_playerOne.TabStop = false;
            this.GPB_playerOne.Text = "Statystyki gracza1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ilość punktów zdobyuta przez gracza w ostattniej turze";
            // 
            // LBL_tourPointsPlayerOne
            // 
            this.LBL_tourPointsPlayerOne.AutoSize = true;
            this.LBL_tourPointsPlayerOne.Location = new System.Drawing.Point(49, 85);
            this.LBL_tourPointsPlayerOne.Name = "LBL_tourPointsPlayerOne";
            this.LBL_tourPointsPlayerOne.Size = new System.Drawing.Size(221, 16);
            this.LBL_tourPointsPlayerOne.TabIndex = 1;
            this.LBL_tourPointsPlayerOne.Text = "punkty sdobyte w ostatnich 3 rzutach";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Średnia punktów gracza w całym meczu";
            // 
            // LBL_averagePointsPlayerOne
            // 
            this.LBL_averagePointsPlayerOne.AutoSize = true;
            this.LBL_averagePointsPlayerOne.Location = new System.Drawing.Point(69, 216);
            this.LBL_averagePointsPlayerOne.Name = "LBL_averagePointsPlayerOne";
            this.LBL_averagePointsPlayerOne.Size = new System.Drawing.Size(182, 16);
            this.LBL_averagePointsPlayerOne.TabIndex = 3;
            this.LBL_averagePointsPlayerOne.Text = "tutaj się mają pojawić średnie";
            // 
            // GPB_playerTwo
            // 
            this.GPB_playerTwo.Controls.Add(this.LBL_averagePointsPlayerTwo);
            this.GPB_playerTwo.Controls.Add(this.label6);
            this.GPB_playerTwo.Controls.Add(this.LBL_tourPointsPlayerTwo);
            this.GPB_playerTwo.Controls.Add(this.label8);
            this.GPB_playerTwo.Location = new System.Drawing.Point(934, 180);
            this.GPB_playerTwo.Name = "GPB_playerTwo";
            this.GPB_playerTwo.Size = new System.Drawing.Size(326, 461);
            this.GPB_playerTwo.TabIndex = 8;
            this.GPB_playerTwo.TabStop = false;
            this.GPB_playerTwo.Text = "Statystyki gracza2";
            // 
            // LBL_averagePointsPlayerTwo
            // 
            this.LBL_averagePointsPlayerTwo.AutoSize = true;
            this.LBL_averagePointsPlayerTwo.Location = new System.Drawing.Point(69, 216);
            this.LBL_averagePointsPlayerTwo.Name = "LBL_averagePointsPlayerTwo";
            this.LBL_averagePointsPlayerTwo.Size = new System.Drawing.Size(182, 16);
            this.LBL_averagePointsPlayerTwo.TabIndex = 3;
            this.LBL_averagePointsPlayerTwo.Text = "tutaj się mają pojawić średnie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Średnia punktów gracza w całym meczu";
            // 
            // LBL_tourPointsPlayerTwo
            // 
            this.LBL_tourPointsPlayerTwo.AutoSize = true;
            this.LBL_tourPointsPlayerTwo.Location = new System.Drawing.Point(49, 85);
            this.LBL_tourPointsPlayerTwo.Name = "LBL_tourPointsPlayerTwo";
            this.LBL_tourPointsPlayerTwo.Size = new System.Drawing.Size(221, 16);
            this.LBL_tourPointsPlayerTwo.TabIndex = 1;
            this.LBL_tourPointsPlayerTwo.Text = "punkty sdobyte w ostatnich 3 rzutach";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(323, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ilość punktów zdobyuta przez gracza w ostattniej turze";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.GPB_playerTwo);
            this.Controls.Add(this.GPB_playerOne);
            this.Controls.Add(this.BTN_gameControl);
            this.Controls.Add(this.TXB_NamePlayerTwo);
            this.Controls.Add(this.TXB_NamePlayerOne);
            this.Controls.Add(this.LBL_PointsPlayerTwo);
            this.Controls.Add(this.LBL_PointsPlayerOne);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MNS_navBar);
            this.MainMenuStrip = this.MNS_navBar;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "DartsMeter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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

        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_averagePointsPlayerOne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBL_tourPointsPlayerOne;
        private System.Windows.Forms.GroupBox GPB_playerTwo;
        private System.Windows.Forms.Label LBL_averagePointsPlayerTwo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBL_tourPointsPlayerTwo;
        private System.Windows.Forms.Label label8;
    }
}

