namespace Guessing
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.A = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.A.Location = new System.Drawing.Point(59, 112);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(121, 116);
            this.A.TabIndex = 0;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // D
            // 
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.D.Location = new System.Drawing.Point(604, 112);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(121, 116);
            this.D.TabIndex = 1;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.C.Location = new System.Drawing.Point(432, 112);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(121, 116);
            this.C.TabIndex = 2;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.button4.Location = new System.Drawing.Point(241, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 116);
            this.button4.TabIndex = 3;
            this.button4.Text = "B";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(101, 287);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(606, 81);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.C);
            this.Controls.Add(this.D);
            this.Controls.Add(this.A);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

