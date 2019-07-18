namespace Assignment4
{
    partial class StartForm
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
            this.components = new System.ComponentModel.Container();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.SplashPictureBox = new System.Windows.Forms.PictureBox();
            this.SplashTextBox = new System.Windows.Forms.Label();
            this.SplashProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.SplashPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 3000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // SplashPictureBox
            // 
            this.SplashPictureBox.Image = global::Assignment4.Properties.Resources.delish_pineapple_bun_burger_pin_1_lf;
            this.SplashPictureBox.Location = new System.Drawing.Point(-8, 3);
            this.SplashPictureBox.Name = "SplashPictureBox";
            this.SplashPictureBox.Size = new System.Drawing.Size(313, 367);
            this.SplashPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SplashPictureBox.TabIndex = 0;
            this.SplashPictureBox.TabStop = false;
            // 
            // SplashTextBox
            // 
            this.SplashTextBox.AutoSize = true;
            this.SplashTextBox.Location = new System.Drawing.Point(65, 338);
            this.SplashTextBox.Name = "SplashTextBox";
            this.SplashTextBox.Size = new System.Drawing.Size(181, 32);
            this.SplashTextBox.TabIndex = 1;
            this.SplashTextBox.Text = "BMI Calulator";
            // 
            // SplashProgressBar
            // 
            this.SplashProgressBar.Location = new System.Drawing.Point(38, 397);
            this.SplashProgressBar.MarqueeAnimationSpeed = 20;
            this.SplashProgressBar.Name = "SplashProgressBar";
            this.SplashProgressBar.Size = new System.Drawing.Size(229, 32);
            this.SplashProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.SplashProgressBar.TabIndex = 2;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.ControlBox = false;
            this.Controls.Add(this.SplashProgressBar);
            this.Controls.Add(this.SplashTextBox);
            this.Controls.Add(this.SplashPictureBox);
            this.Font = new System.Drawing.Font("Arial", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SplashPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.PictureBox SplashPictureBox;
        private System.Windows.Forms.Label SplashTextBox;
        private System.Windows.Forms.ProgressBar SplashProgressBar;
    }
}