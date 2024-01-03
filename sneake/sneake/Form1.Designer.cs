namespace sneake
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            game = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)game).BeginInit();
            SuspendLayout();
            // 
            // game
            // 
            game.BackColor = Color.White;
            game.Location = new Point(81, 21);
            game.Name = "game";
            game.Size = new Size(500, 500);
            game.TabIndex = 0;
            game.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(580, 20);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Total:99";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 567);
            Controls.Add(label1);
            Controls.Add(game);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)game).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox game;
        private Label label1;
    }
}