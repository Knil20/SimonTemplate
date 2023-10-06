namespace SimonSays
{
    partial class GameScreenHard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.greenButton2 = new System.Windows.Forms.Button();
            this.redButton2 = new System.Windows.Forms.Button();
            this.yellowButton2 = new System.Windows.Forms.Button();
            this.blueButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greenButton2
            // 
            this.greenButton2.BackColor = System.Drawing.Color.ForestGreen;
            this.greenButton2.Location = new System.Drawing.Point(40, 37);
            this.greenButton2.Name = "greenButton2";
            this.greenButton2.Size = new System.Drawing.Size(110, 110);
            this.greenButton2.TabIndex = 1;
            this.greenButton2.UseVisualStyleBackColor = false;
            // 
            // redButton2
            // 
            this.redButton2.BackColor = System.Drawing.Color.DarkRed;
            this.redButton2.Location = new System.Drawing.Point(156, 37);
            this.redButton2.Name = "redButton2";
            this.redButton2.Size = new System.Drawing.Size(110, 110);
            this.redButton2.TabIndex = 2;
            this.redButton2.UseVisualStyleBackColor = false;
            // 
            // yellowButton2
            // 
            this.yellowButton2.BackColor = System.Drawing.Color.Goldenrod;
            this.yellowButton2.Location = new System.Drawing.Point(40, 153);
            this.yellowButton2.Name = "yellowButton2";
            this.yellowButton2.Size = new System.Drawing.Size(110, 110);
            this.yellowButton2.TabIndex = 4;
            this.yellowButton2.UseVisualStyleBackColor = false;
            // 
            // blueButton2
            // 
            this.blueButton2.BackColor = System.Drawing.Color.DarkBlue;
            this.blueButton2.Location = new System.Drawing.Point(156, 153);
            this.blueButton2.Name = "blueButton2";
            this.blueButton2.Size = new System.Drawing.Size(110, 110);
            this.blueButton2.TabIndex = 5;
            this.blueButton2.UseVisualStyleBackColor = false;
            // 
            // GameScreenHard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.blueButton2);
            this.Controls.Add(this.yellowButton2);
            this.Controls.Add(this.redButton2);
            this.Controls.Add(this.greenButton2);
            this.Name = "GameScreenHard";
            this.Size = new System.Drawing.Size(301, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button greenButton2;
        private System.Windows.Forms.Button redButton2;
        private System.Windows.Forms.Button yellowButton2;
        private System.Windows.Forms.Button blueButton2;
    }
}
