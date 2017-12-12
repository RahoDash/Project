namespace DiceGame {
    partial class DiceGameView {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDice = new System.Windows.Forms.NumericUpDown();
            this.nudFaces = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFaces)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choissiez le nombre de dés :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choissiez le nombre de faces :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudDice
            // 
            this.nudDice.Location = new System.Drawing.Point(192, 4);
            this.nudDice.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudDice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDice.Name = "nudDice";
            this.nudDice.Size = new System.Drawing.Size(54, 20);
            this.nudDice.TabIndex = 2;
            this.nudDice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudFaces
            // 
            this.nudFaces.Location = new System.Drawing.Point(193, 28);
            this.nudFaces.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudFaces.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudFaces.Name = "nudFaces";
            this.nudFaces.Size = new System.Drawing.Size(54, 20);
            this.nudFaces.TabIndex = 3;
            this.nudFaces.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "(1 - 9)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "(2 - 12)";
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(12, 56);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(307, 23);
            this.btnInit.TabIndex = 6;
            this.btnInit.Text = "Prendre les dés";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.BtnInit_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(12, 85);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(307, 23);
            this.btnRoll.TabIndex = 8;
            this.btnRoll.Text = "Lancer les dés !";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.BtnRoll_Click);
            // 
            // DiceGameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(331, 117);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudFaces);
            this.Controls.Add(this.nudDice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DiceGameView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDice;
        private System.Windows.Forms.NumericUpDown nudFaces;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnRoll;
    }
}

