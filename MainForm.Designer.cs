namespace XpDragodinde
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numCharLvl = new System.Windows.Forms.NumericUpDown();
            this.numDesiredLvl = new System.Windows.Forms.NumericUpDown();
            this.numXpSolo = new System.Windows.Forms.NumericUpDown();
            this.numChallenge = new System.Windows.Forms.NumericUpDown();
            this.btnResetChallenge = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblXpPercent = new System.Windows.Forms.Label();
            this.lblUseSpell = new System.Windows.Forms.Label();
            this.lblUseChallenge = new System.Windows.Forms.Label();
            this.lblReachedLvl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCharLvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesiredLvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXpSolo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChallenge)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Niveau personnage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Niveau dinde désiré";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Experience solo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "% à donner à la dinde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sort de capture";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Challenge";
            // 
            // numCharLvl
            // 
            this.numCharLvl.Location = new System.Drawing.Point(129, 7);
            this.numCharLvl.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numCharLvl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCharLvl.Name = "numCharLvl";
            this.numCharLvl.Size = new System.Drawing.Size(71, 20);
            this.numCharLvl.TabIndex = 6;
            this.numCharLvl.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // numDesiredLvl
            // 
            this.numDesiredLvl.Location = new System.Drawing.Point(129, 33);
            this.numDesiredLvl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDesiredLvl.Name = "numDesiredLvl";
            this.numDesiredLvl.Size = new System.Drawing.Size(71, 20);
            this.numDesiredLvl.TabIndex = 7;
            this.numDesiredLvl.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numXpSolo
            // 
            this.numXpSolo.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numXpSolo.Location = new System.Drawing.Point(129, 58);
            this.numXpSolo.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numXpSolo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numXpSolo.Name = "numXpSolo";
            this.numXpSolo.Size = new System.Drawing.Size(71, 20);
            this.numXpSolo.TabIndex = 8;
            this.numXpSolo.ThousandsSeparator = true;
            this.numXpSolo.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // numChallenge
            // 
            this.numChallenge.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numChallenge.Location = new System.Drawing.Point(129, 84);
            this.numChallenge.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numChallenge.Name = "numChallenge";
            this.numChallenge.Size = new System.Drawing.Size(71, 20);
            this.numChallenge.TabIndex = 9;
            // 
            // btnResetChallenge
            // 
            this.btnResetChallenge.Location = new System.Drawing.Point(103, 84);
            this.btnResetChallenge.Name = "btnResetChallenge";
            this.btnResetChallenge.Size = new System.Drawing.Size(20, 20);
            this.btnResetChallenge.TabIndex = 10;
            this.btnResetChallenge.Text = "X";
            this.btnResetChallenge.UseVisualStyleBackColor = true;
            this.btnResetChallenge.Click += new System.EventHandler(this.btnResetChallenge_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Challenge";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Niveau atteint";
            // 
            // lblXpPercent
            // 
            this.lblXpPercent.AutoSize = true;
            this.lblXpPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXpPercent.ForeColor = System.Drawing.Color.White;
            this.lblXpPercent.Location = new System.Drawing.Point(126, 135);
            this.lblXpPercent.Name = "lblXpPercent";
            this.lblXpPercent.Size = new System.Drawing.Size(11, 13);
            this.lblXpPercent.TabIndex = 13;
            this.lblXpPercent.Text = "-";
            // 
            // lblUseSpell
            // 
            this.lblUseSpell.AutoSize = true;
            this.lblUseSpell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseSpell.ForeColor = System.Drawing.Color.White;
            this.lblUseSpell.Location = new System.Drawing.Point(126, 159);
            this.lblUseSpell.Name = "lblUseSpell";
            this.lblUseSpell.Size = new System.Drawing.Size(11, 13);
            this.lblUseSpell.TabIndex = 14;
            this.lblUseSpell.Text = "-";
            // 
            // lblUseChallenge
            // 
            this.lblUseChallenge.AutoSize = true;
            this.lblUseChallenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseChallenge.ForeColor = System.Drawing.Color.White;
            this.lblUseChallenge.Location = new System.Drawing.Point(126, 183);
            this.lblUseChallenge.Name = "lblUseChallenge";
            this.lblUseChallenge.Size = new System.Drawing.Size(11, 13);
            this.lblUseChallenge.TabIndex = 15;
            this.lblUseChallenge.Text = "-";
            // 
            // lblReachedLvl
            // 
            this.lblReachedLvl.AutoSize = true;
            this.lblReachedLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReachedLvl.ForeColor = System.Drawing.Color.White;
            this.lblReachedLvl.Location = new System.Drawing.Point(126, 207);
            this.lblReachedLvl.Name = "lblReachedLvl";
            this.lblReachedLvl.Size = new System.Drawing.Size(11, 13);
            this.lblReachedLvl.TabIndex = 16;
            this.lblReachedLvl.Text = "-";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(208, 233);
            this.Controls.Add(this.lblReachedLvl);
            this.Controls.Add(this.lblUseChallenge);
            this.Controls.Add(this.lblUseSpell);
            this.Controls.Add(this.lblXpPercent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnResetChallenge);
            this.Controls.Add(this.numChallenge);
            this.Controls.Add(this.numXpSolo);
            this.Controls.Add(this.numDesiredLvl);
            this.Controls.Add(this.numCharLvl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Xp Dragodinde";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.numCharLvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesiredLvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXpSolo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChallenge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numCharLvl;
        private System.Windows.Forms.NumericUpDown numDesiredLvl;
        private System.Windows.Forms.NumericUpDown numXpSolo;
        private System.Windows.Forms.NumericUpDown numChallenge;
        private System.Windows.Forms.Button btnResetChallenge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblXpPercent;
        private System.Windows.Forms.Label lblUseSpell;
        private System.Windows.Forms.Label lblUseChallenge;
        private System.Windows.Forms.Label lblReachedLvl;
    }
}

