namespace AloMundo
{
    partial class FrmTexto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BntTexto = new System.Windows.Forms.Button();
            this.TxtTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BntTexto
            // 
            this.BntTexto.Location = new System.Drawing.Point(212, 36);
            this.BntTexto.Name = "BntTexto";
            this.BntTexto.Size = new System.Drawing.Size(75, 23);
            this.BntTexto.TabIndex = 0;
            this.BntTexto.Text = "Texto";
            this.BntTexto.UseVisualStyleBackColor = true;
            this.BntTexto.Click += new System.EventHandler(this.BntTexto_Click);
            // 
            // TxtTexto
            // 
            this.TxtTexto.Location = new System.Drawing.Point(27, 36);
            this.TxtTexto.Name = "TxtTexto";
            this.TxtTexto.Size = new System.Drawing.Size(138, 20);
            this.TxtTexto.TabIndex = 1;
            // 
            // FrmTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 104);
            this.Controls.Add(this.TxtTexto);
            this.Controls.Add(this.BntTexto);
            this.Name = "FrmTexto";
            this.Text = "Alo Mundo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BntTexto;
        private System.Windows.Forms.TextBox TxtTexto;
    }
}

