namespace DiceGame
{
    partial class DieView
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
            this.LblDieView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblDieView
            // 
            this.LblDieView.BackColor = System.Drawing.SystemColors.Highlight;
            this.LblDieView.Font = new System.Drawing.Font("Raleway", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDieView.Location = new System.Drawing.Point(12, 9);
            this.LblDieView.Name = "LblDieView";
            this.LblDieView.Size = new System.Drawing.Size(160, 98);
            this.LblDieView.TabIndex = 0;
            this.LblDieView.Text = "0";
            this.LblDieView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DieView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(184, 116);
            this.Controls.Add(this.LblDieView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DieView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DieView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DieView_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblDieView;
    }
}