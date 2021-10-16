namespace Snake_Game_WF
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
            this.labelScore = new System.Windows.Forms.Label();
            this.labelFood = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(17, 9);
            this.labelScore.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(132, 38);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "Score: 0";
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFood.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFood.Location = new System.Drawing.Point(338, 165);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(21, 19);
            this.labelFood.TabIndex = 1;
            this.labelFood.Text = "  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.labelFood);
            this.Controls.Add(this.labelScore);
            this.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelFood;
    }
}

