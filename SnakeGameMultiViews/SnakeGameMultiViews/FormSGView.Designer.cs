namespace SnakeGameMultiViews
{
    partial class SGView
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxGameArea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGameArea
            // 
            this.pictureBoxGameArea.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxGameArea.Name = "pictureBoxGameArea";
            this.pictureBoxGameArea.Size = new System.Drawing.Size(401, 401);
            this.pictureBoxGameArea.TabIndex = 0;
            this.pictureBoxGameArea.TabStop = false;
            // 
            // SGView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 430);
            this.Controls.Add(this.pictureBoxGameArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.Name = "SGView";
            this.Text = "SnakeGame";
            this.Load += new System.EventHandler(this.SGView_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SGView_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameArea)).EndInit();
            this.ResumeLayout(false);
            // 
            // SGView
            // 
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SGView_FormClosing);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGameArea;
    }
}

