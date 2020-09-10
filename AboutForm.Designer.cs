namespace LightsOut
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.gameLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.bulb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bulb)).BeginInit();
            this.SuspendLayout();
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLabel.ForeColor = System.Drawing.Color.Red;
            this.gameLabel.Location = new System.Drawing.Point(85, 45);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(145, 34);
            this.gameLabel.TabIndex = 0;
            this.gameLabel.Text = "Lights Out!";
            this.gameLabel.Click += new System.EventHandler(this.gameLabel_Click);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(96, 92);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(112, 17);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "By Gus McCoy";
            this.authorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(63, 127);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(186, 13);
            this.instructionsLabel.TabIndex = 2;
            this.instructionsLabel.Text = "Turn all the lights out to win the game!";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(116, 166);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // bulb
            // 
            this.bulb.Image = ((System.Drawing.Image)(resources.GetObject("bulb.Image")));
            this.bulb.InitialImage = ((System.Drawing.Image)(resources.GetObject("bulb.InitialImage")));
            this.bulb.Location = new System.Drawing.Point(91, 12);
            this.bulb.Name = "bulb";
            this.bulb.Size = new System.Drawing.Size(164, 163);
            this.bulb.TabIndex = 4;
            this.bulb.TabStop = false;
            this.bulb.Click += new System.EventHandler(this.bulb_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 224);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.bulb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.bulb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.PictureBox bulb;
    }
}