namespace DashboardMultiViews
{
    partial class DashboardView
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
            this.lblLevel = new System.Windows.Forms.Label();
            this.trbLevel = new System.Windows.Forms.TrackBar();
            this.chbNotif = new System.Windows.Forms.CheckBox();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.lblStatu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLevel
            // 
            this.lblLevel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(93, 9);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(100, 42);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "0";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trbLevel
            // 
            this.trbLevel.LargeChange = 1;
            this.trbLevel.Location = new System.Drawing.Point(12, 54);
            this.trbLevel.Maximum = 100;
            this.trbLevel.Name = "trbLevel";
            this.trbLevel.Size = new System.Drawing.Size(260, 45);
            this.trbLevel.TabIndex = 1;
            this.trbLevel.Scroll += new System.EventHandler(this.TrbLevel_Scroll);
            // 
            // chbNotif
            // 
            this.chbNotif.AutoSize = true;
            this.chbNotif.Checked = true;
            this.chbNotif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbNotif.Location = new System.Drawing.Point(12, 106);
            this.chbNotif.Name = "chbNotif";
            this.chbNotif.Size = new System.Drawing.Size(58, 17);
            this.chbNotif.TabIndex = 2;
            this.chbNotif.Text = "enable";
            this.chbNotif.UseVisualStyleBackColor = true;
            this.chbNotif.Click += new System.EventHandler(this.ChbNotif_Click);
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Location = new System.Drawing.Point(9, 150);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(43, 13);
            this.lblStatusText.TabIndex = 3;
            this.lblStatusText.Text = "Status :";
            // 
            // lblStatu
            // 
            this.lblStatu.AutoSize = true;
            this.lblStatu.Location = new System.Drawing.Point(58, 150);
            this.lblStatu.Name = "lblStatu";
            this.lblStatu.Size = new System.Drawing.Size(33, 13);
            this.lblStatu.TabIndex = 4;
            this.lblStatu.Text = "None";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(284, 187);
            this.Controls.Add(this.lblStatu);
            this.Controls.Add(this.lblStatusText);
            this.Controls.Add(this.chbNotif);
            this.Controls.Add(this.trbLevel);
            this.Controls.Add(this.lblLevel);
            this.Name = "DashboardView";
            this.Text = "DashboardView";
            ((System.ComponentModel.ISupportInitialize)(this.trbLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.TrackBar trbLevel;
        private System.Windows.Forms.CheckBox chbNotif;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.Label lblStatu;
    }
}