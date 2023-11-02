namespace ClickTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clickTesterButton = new System.Windows.Forms.Button();
            this.clickTestTimer = new System.Windows.Forms.TextBox();
            this.secondsSelector = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.secondsSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // clickTesterButton
            // 
            this.clickTesterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickTesterButton.Location = new System.Drawing.Point(12, 86);
            this.clickTesterButton.Name = "clickTesterButton";
            this.clickTesterButton.Size = new System.Drawing.Size(776, 352);
            this.clickTesterButton.TabIndex = 0;
            this.clickTesterButton.Text = "Cliquez pour commencer";
            this.clickTesterButton.UseVisualStyleBackColor = true;
            this.clickTesterButton.Click += new System.EventHandler(this.clickTesterButton_Click);
            // 
            // clickTestTimer
            // 
            this.clickTestTimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clickTestTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickTestTimer.Location = new System.Drawing.Point(284, 36);
            this.clickTestTimer.Name = "clickTestTimer";
            this.clickTestTimer.ReadOnly = true;
            this.clickTestTimer.Size = new System.Drawing.Size(254, 31);
            this.clickTestTimer.TabIndex = 1;
            this.clickTestTimer.Text = "10s";
            this.clickTestTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secondsSelector
            // 
            this.secondsSelector.Location = new System.Drawing.Point(12, 36);
            this.secondsSelector.Name = "secondsSelector";
            this.secondsSelector.Size = new System.Drawing.Size(74, 20);
            this.secondsSelector.TabIndex = 2;
            this.secondsSelector.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.secondsSelector.ValueChanged += new System.EventHandler(this.secondsSelector_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de secondes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondsSelector);
            this.Controls.Add(this.clickTestTimer);
            this.Controls.Add(this.clickTesterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ClickTest";
            ((System.ComponentModel.ISupportInitialize)(this.secondsSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickTesterButton;
        private System.Windows.Forms.TextBox clickTestTimer;
        private System.Windows.Forms.NumericUpDown secondsSelector;
        private System.Windows.Forms.Label label1;
    }
}

