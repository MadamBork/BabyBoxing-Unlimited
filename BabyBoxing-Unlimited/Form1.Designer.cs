namespace BabyBoxing_Unlimited
{
    partial class Form1
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
            this.debugLabel1 = new System.Windows.Forms.Label();
            this.playerBabyImageLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerTitlescreenEnter = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // debugLabel1
            // 
            this.debugLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.debugLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.debugLabel1.Location = new System.Drawing.Point(281, 136);
            this.debugLabel1.Name = "debugLabel1";
            this.debugLabel1.Size = new System.Drawing.Size(127, 54);
            this.debugLabel1.TabIndex = 0;
            this.debugLabel1.Text = "debugLabel1";
            this.debugLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.debugLabel1.Click += new System.EventHandler(this.debugLabel1_Click);
            // 
            // playerBabyImageLabel
            // 
            this.playerBabyImageLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerBabyImageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerBabyImageLabel.Location = new System.Drawing.Point(25, 49);
            this.playerBabyImageLabel.Name = "playerBabyImageLabel";
            this.playerBabyImageLabel.Size = new System.Drawing.Size(167, 107);
            this.playerBabyImageLabel.TabIndex = 1;
            this.playerBabyImageLabel.Text = "label1";
            this.playerBabyImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.tick);
            // 
            // timerTitlescreenEnter
            // 
            this.timerTitlescreenEnter.Interval = 2000;
            this.timerTitlescreenEnter.Tick += new System.EventHandler(this.timerTitlescreenEnter_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playerBabyImageLabel);
            this.Controls.Add(this.debugLabel1);
            this.Name = "Form1";
            this.Text = " ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label debugLabel1;
        private System.Windows.Forms.Label playerBabyImageLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerTitlescreenEnter;
    }
}

