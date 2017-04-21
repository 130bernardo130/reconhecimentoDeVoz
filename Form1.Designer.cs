namespace reconhecimentoDeVoz
{
    partial class Form1
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
            this.Ouvir = new System.Windows.Forms.Button();
            this.texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ouvir
            // 
            this.Ouvir.Location = new System.Drawing.Point(76, 49);
            this.Ouvir.Name = "Ouvir";
            this.Ouvir.Size = new System.Drawing.Size(75, 29);
            this.Ouvir.TabIndex = 0;
            this.Ouvir.Text = "Ouvir";
            this.Ouvir.UseVisualStyleBackColor = true;
            this.Ouvir.Click += new System.EventHandler(this.button1_Click);
            // 
            // texto
            // 
            this.texto.Location = new System.Drawing.Point(12, 96);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(202, 20);
            this.texto.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 156);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.Ouvir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ouvir;
        private System.Windows.Forms.TextBox texto;
    }
}

