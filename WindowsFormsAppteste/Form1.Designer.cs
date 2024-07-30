namespace WindowsFormsAppteste
{
    partial class Form1
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
            this.botao1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.caixausu1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.caixausu2 = new System.Windows.Forms.TextBox();
            this.botao3 = new System.Windows.Forms.Button();
            this.botao2 = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.resul = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botao1
            // 
            this.botao1.Location = new System.Drawing.Point(310, 410);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(156, 95);
            this.botao1.TabIndex = 1;
            this.botao1.Text = "somar";
            this.botao1.UseVisualStyleBackColor = true;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.CausesValidation = false;
            this.label1.Location = new System.Drawing.Point(307, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "número 1";
            // 
            // caixausu1
            // 
            this.caixausu1.Location = new System.Drawing.Point(422, 198);
            this.caixausu1.MaxLength = 2500;
            this.caixausu1.Multiline = true;
            this.caixausu1.Name = "caixausu1";
            this.caixausu1.Size = new System.Drawing.Size(441, 20);
            this.caixausu1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.CausesValidation = false;
            this.label2.Location = new System.Drawing.Point(307, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "número 2";
            // 
            // caixausu2
            // 
            this.caixausu2.Location = new System.Drawing.Point(422, 260);
            this.caixausu2.MaxLength = 2500;
            this.caixausu2.Multiline = true;
            this.caixausu2.Name = "caixausu2";
            this.caixausu2.Size = new System.Drawing.Size(441, 20);
            this.caixausu2.TabIndex = 5;
            // 
            // botao3
            // 
            this.botao3.Location = new System.Drawing.Point(717, 410);
            this.botao3.Name = "botao3";
            this.botao3.Size = new System.Drawing.Size(146, 95);
            this.botao3.TabIndex = 6;
            this.botao3.Text = "fechar";
            this.botao3.UseVisualStyleBackColor = true;
            this.botao3.Click += new System.EventHandler(this.botao3_Click);
            // 
            // botao2
            // 
            this.botao2.Location = new System.Drawing.Point(505, 410);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(176, 95);
            this.botao2.TabIndex = 7;
            this.botao2.Text = "limpar";
            this.botao2.UseVisualStyleBackColor = true;
            this.botao2.Click += new System.EventHandler(this.botao2_Click);
            // 
            // resultado
            // 
            this.resultado.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.resultado.CausesValidation = false;
            this.resultado.Location = new System.Drawing.Point(307, 611);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(98, 23);
            this.resultado.TabIndex = 8;
            this.resultado.Text = "resultado";
            // 
            // resul
            // 
            this.resul.Location = new System.Drawing.Point(472, 594);
            this.resul.MaxLength = 2500;
            this.resul.Multiline = true;
            this.resul.Name = "resul";
            this.resul.Size = new System.Drawing.Size(99, 40);
            this.resul.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 927);
            this.Controls.Add(this.resul);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.botao3);
            this.Controls.Add(this.caixausu2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caixausu1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botao1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox caixausu1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox caixausu2;
        private System.Windows.Forms.Button botao3;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.TextBox resul;
    }
}

