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
            this.debugLabel1 = new System.Windows.Forms.Label();
            this.playerBabyImageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // debugLabel1
            // 
            this.debugLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.debugLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.debugLabel1.Location = new System.Drawing.Point(226, 75);
            this.debugLabel1.Name = "debugLabel1";
            this.debugLabel1.Size = new System.Drawing.Size(127, 54);
            this.debugLabel1.TabIndex = 0;
            this.debugLabel1.Text = "debugLabel1";
            this.debugLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerBabyImageLabel
            // 
            this.playerBabyImageLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerBabyImageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerBabyImageLabel.Location = new System.Drawing.Point(171, 236);
            this.playerBabyImageLabel.Name = "playerBabyImageLabel";
            this.playerBabyImageLabel.Size = new System.Drawing.Size(127, 54);
            this.playerBabyImageLabel.TabIndex = 1;
            this.playerBabyImageLabel.Text = "label1";
            this.playerBabyImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playerBabyImageLabel);
            this.Controls.Add(this.debugLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label debugLabel1;
        private System.Windows.Forms.Label playerBabyImageLabel;
    }
}

