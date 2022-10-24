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
            this.PB_dartBoard = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PB_dartBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_dartBoard
            // 
            this.PB_dartBoard.BackColor = System.Drawing.Color.Transparent;
            this.PB_dartBoard.Image = global::DartsMeter.Properties.Resources.tarcza_bezalfy;
            this.PB_dartBoard.Location = new System.Drawing.Point(281, 147);
            this.PB_dartBoard.Name = "PB_dartBoard";
            this.PB_dartBoard.Size = new System.Drawing.Size(400, 400);
            this.PB_dartBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_dartBoard.TabIndex = 0;
            this.PB_dartBoard.TabStop = false;
            this.PB_dartBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PB_dartBoard_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.PB_dartBoard);
            this.Name = "MainForm";
            this.Text = "DartsMeter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_dartBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_dartBoard;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

