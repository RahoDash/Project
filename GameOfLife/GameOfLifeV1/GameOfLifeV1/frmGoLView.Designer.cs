namespace GameOfLifeV1 {
  partial class frmGoLView {
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
      this.components = new System.ComponentModel.Container();
      this.btnStep = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.btnTimerStartStop = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.pnlCellsArea = new System.Windows.Forms.Panel();
      this.btnRandom = new System.Windows.Forms.Button();
      this.tbCycle = new System.Windows.Forms.TrackBar();
      this.label1 = new System.Windows.Forms.Label();
      this.nudNbColumns = new System.Windows.Forms.NumericUpDown();
      this.nudNbRows = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.tbCycle)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudNbColumns)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudNbRows)).BeginInit();
      this.SuspendLayout();
      // 
      // btnStep
      // 
      this.btnStep.Location = new System.Drawing.Point(12, 12);
      this.btnStep.Name = "btnStep";
      this.btnStep.Size = new System.Drawing.Size(75, 23);
      this.btnStep.TabIndex = 1;
      this.btnStep.Text = "Step";
      this.btnStep.UseVisualStyleBackColor = true;
      this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // btnTimerStartStop
      // 
      this.btnTimerStartStop.Location = new System.Drawing.Point(93, 12);
      this.btnTimerStartStop.Name = "btnTimerStartStop";
      this.btnTimerStartStop.Size = new System.Drawing.Size(75, 23);
      this.btnTimerStartStop.TabIndex = 2;
      this.btnTimerStartStop.Text = "Start/Stop";
      this.btnTimerStartStop.UseVisualStyleBackColor = true;
      this.btnTimerStartStop.Click += new System.EventHandler(this.btnTimerStartStop_Click);
      // 
      // btnClear
      // 
      this.btnClear.Location = new System.Drawing.Point(255, 12);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(75, 23);
      this.btnClear.TabIndex = 0;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // pnlCellsArea
      // 
      this.pnlCellsArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlCellsArea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.pnlCellsArea.Location = new System.Drawing.Point(12, 63);
      this.pnlCellsArea.Name = "pnlCellsArea";
      this.pnlCellsArea.Size = new System.Drawing.Size(706, 534);
      this.pnlCellsArea.TabIndex = 0;
      this.pnlCellsArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCellsArea_Paint);
      this.pnlCellsArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCellsArea_MouseClick);
      this.pnlCellsArea.Resize += new System.EventHandler(this.pnlCellsArea_Resize);
      // 
      // btnRandom
      // 
      this.btnRandom.Location = new System.Drawing.Point(174, 12);
      this.btnRandom.Name = "btnRandom";
      this.btnRandom.Size = new System.Drawing.Size(75, 23);
      this.btnRandom.TabIndex = 3;
      this.btnRandom.Text = "Random";
      this.btnRandom.UseVisualStyleBackColor = true;
      this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
      // 
      // tbCycle
      // 
      this.tbCycle.Location = new System.Drawing.Point(336, 12);
      this.tbCycle.Minimum = 1;
      this.tbCycle.Name = "tbCycle";
      this.tbCycle.Size = new System.Drawing.Size(126, 45);
      this.tbCycle.TabIndex = 4;
      this.tbCycle.Value = 1;
      this.tbCycle.Scroll += new System.EventHandler(this.tbCycle_Scroll);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(376, 44);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Speed";
      // 
      // nudNbColumns
      // 
      this.nudNbColumns.Location = new System.Drawing.Point(532, 12);
      this.nudNbColumns.Name = "nudNbColumns";
      this.nudNbColumns.Size = new System.Drawing.Size(49, 20);
      this.nudNbColumns.TabIndex = 6;
      this.nudNbColumns.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
      this.nudNbColumns.ValueChanged += new System.EventHandler(this.nudGeneric_ValueChanged);
      // 
      // nudNbRows
      // 
      this.nudNbRows.Location = new System.Drawing.Point(656, 12);
      this.nudNbRows.Name = "nudNbRows";
      this.nudNbRows.Size = new System.Drawing.Size(49, 20);
      this.nudNbRows.TabIndex = 7;
      this.nudNbRows.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
      this.nudNbRows.ValueChanged += new System.EventHandler(this.nudGeneric_ValueChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(483, 17);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(43, 13);
      this.label2.TabIndex = 9;
      this.label2.Text = "Nb cols";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(604, 17);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(46, 13);
      this.label3.TabIndex = 10;
      this.label3.Text = "Nb rows";
      // 
      // frmGoLView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(730, 613);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.nudNbRows);
      this.Controls.Add(this.nudNbColumns);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnStep);
      this.Controls.Add(this.tbCycle);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.btnRandom);
      this.Controls.Add(this.btnTimerStartStop);
      this.Controls.Add(this.pnlCellsArea);
      this.Name = "frmGoLView";
      this.Text = "Game of Life";
      this.Load += new System.EventHandler(this.frmGoLView_Load);
      ((System.ComponentModel.ISupportInitialize)(this.tbCycle)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudNbColumns)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudNbRows)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnStep;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button btnTimerStartStop;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Panel pnlCellsArea;
    private System.Windows.Forms.Button btnRandom;
    private System.Windows.Forms.TrackBar tbCycle;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown nudNbColumns;
    private System.Windows.Forms.NumericUpDown nudNbRows;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
  }
}

