namespace Practica_8
{
    partial class btnCheckMagicSquare
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMatriz = new System.Windows.Forms.Panel();
            this.CheckMagicSquare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Practica 8";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(327, 86);
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(98, 22);
            this.numSize.TabIndex = 1;
            this.numSize.ValueChanged += new System.EventHandler(this.numSize_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tamaño de cuadro Magico:";
            // 
            // panelMatriz
            // 
            this.panelMatriz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMatriz.Location = new System.Drawing.Point(156, 114);
            this.panelMatriz.Name = "panelMatriz";
            this.panelMatriz.Size = new System.Drawing.Size(473, 361);
            this.panelMatriz.TabIndex = 3;
            this.panelMatriz.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMatriz_Paint);
            // 
            // CheckMagicSquare
            // 
            this.CheckMagicSquare.Location = new System.Drawing.Point(327, 497);
            this.CheckMagicSquare.Name = "CheckMagicSquare";
            this.CheckMagicSquare.Size = new System.Drawing.Size(140, 30);
            this.CheckMagicSquare.TabIndex = 4;
            this.CheckMagicSquare.Text = "Resolver";
            this.CheckMagicSquare.UseVisualStyleBackColor = true;
            this.CheckMagicSquare.Click += new System.EventHandler(this.CheckMagicSquare_Click);
            // 
            // btnCheckMagicSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.CheckMagicSquare);
            this.Controls.Add(this.panelMatriz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.label1);
            this.Name = "btnCheckMagicSquare";
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMatriz;
        private System.Windows.Forms.Button CheckMagicSquare;
    }
}

