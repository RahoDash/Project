namespace DownloadScanFromList
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstbTitle = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDlAll = new System.Windows.Forms.Button();
            this.BtnDlCh = new System.Windows.Forms.Button();
            this.cmbChapter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbTitle
            // 
            this.lstbTitle.FormattingEnabled = true;
            this.lstbTitle.Location = new System.Drawing.Point(12, 12);
            this.lstbTitle.Name = "lstbTitle";
            this.lstbTitle.Size = new System.Drawing.Size(251, 316);
            this.lstbTitle.TabIndex = 0;
            this.lstbTitle.SelectedIndexChanged += new System.EventHandler(this.lstbTitle_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(270, 252);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDlAll
            // 
            this.btnDlAll.Enabled = false;
            this.btnDlAll.Location = new System.Drawing.Point(270, 68);
            this.btnDlAll.Name = "btnDlAll";
            this.btnDlAll.Size = new System.Drawing.Size(250, 50);
            this.btnDlAll.TabIndex = 2;
            this.btnDlAll.Text = "Download all";
            this.btnDlAll.UseVisualStyleBackColor = true;
            this.btnDlAll.Click += new System.EventHandler(this.btnDlAll_Click);
            // 
            // BtnDlCh
            // 
            this.BtnDlCh.Enabled = false;
            this.BtnDlCh.Location = new System.Drawing.Point(270, 151);
            this.BtnDlCh.Name = "BtnDlCh";
            this.BtnDlCh.Size = new System.Drawing.Size(250, 50);
            this.BtnDlCh.TabIndex = 3;
            this.BtnDlCh.Text = "Download the chapter";
            this.BtnDlCh.UseVisualStyleBackColor = true;
            this.BtnDlCh.Click += new System.EventHandler(this.BtnDlCh_Click);
            // 
            // cmbChapter
            // 
            this.cmbChapter.FormattingEnabled = true;
            this.cmbChapter.Location = new System.Drawing.Point(270, 124);
            this.cmbChapter.Name = "cmbChapter";
            this.cmbChapter.Size = new System.Drawing.Size(250, 21);
            this.cmbChapter.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(270, 278);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(250, 50);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select folder where to save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbChapter);
            this.Controls.Add(this.BtnDlCh);
            this.Controls.Add(this.btnDlAll);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstbTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDlAll;
        private System.Windows.Forms.Button BtnDlCh;
        private System.Windows.Forms.ComboBox cmbChapter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button1;
    }
}

