namespace WinQrCodeCS
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGenera = new System.Windows.Forms.Button();
            this.textDecoder1 = new System.Windows.Forms.TextBox();
            this.textDecoder2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(281, 120);
            this.PictureBox1.TabIndex = 3;
            this.PictureBox1.TabStop = false;
            // 
            // btnGenera
            // 
            this.btnGenera.Location = new System.Drawing.Point(12, 159);
            this.btnGenera.Name = "btnGenera";
            this.btnGenera.Size = new System.Drawing.Size(75, 23);
            this.btnGenera.TabIndex = 2;
            this.btnGenera.Text = "Genera";
            this.btnGenera.UseVisualStyleBackColor = true;
            this.btnGenera.Click += new System.EventHandler(this.btnGenera_Click);
            // 
            // textDecoder1
            // 
            this.textDecoder1.Location = new System.Drawing.Point(106, 159);
            this.textDecoder1.Name = "textDecoder1";
            this.textDecoder1.Size = new System.Drawing.Size(274, 20);
            this.textDecoder1.TabIndex = 4;
            // 
            // textDecoder2
            // 
            this.textDecoder2.Location = new System.Drawing.Point(106, 185);
            this.textDecoder2.Name = "textDecoder2";
            this.textDecoder2.Size = new System.Drawing.Size(274, 20);
            this.textDecoder2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 209);
            this.Controls.Add(this.textDecoder2);
            this.Controls.Add(this.textDecoder1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.btnGenera);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esempio genera QRCode";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button btnGenera;
        private System.Windows.Forms.TextBox textDecoder1;
        private System.Windows.Forms.TextBox textDecoder2;
    }
}

