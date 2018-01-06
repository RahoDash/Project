namespace SnakeGameMultiViews
{
    partial class FormInitViews
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
            this.NumUDViews = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDViews)).BeginInit();
            this.SuspendLayout();
            // 
            // NumUDViews
            // 
            this.NumUDViews.Location = new System.Drawing.Point(116, 12);
            this.NumUDViews.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumUDViews.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUDViews.Name = "NumUDViews";
            this.NumUDViews.Size = new System.Drawing.Size(120, 20);
            this.NumUDViews.TabIndex = 0;
            this.NumUDViews.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of view(s) :";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 43);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(224, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // FormInitViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 87);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumUDViews);
            this.Name = "FormInitViews";
            this.Text = "FormInitViews";
            ((System.ComponentModel.ISupportInitialize)(this.NumUDViews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumUDViews;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
    }
}