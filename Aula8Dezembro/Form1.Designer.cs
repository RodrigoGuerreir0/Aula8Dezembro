namespace Aula8Dezembro
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
            this.armazenamentoDeTexto = new System.Windows.Forms.TextBox();
            this.menssagemInicial = new System.Windows.Forms.Label();
            this.botaoEnviar = new System.Windows.Forms.Button();
            this.menssagemFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // armazenamentoDeTexto
            // 
            this.armazenamentoDeTexto.Location = new System.Drawing.Point(23, 55);
            this.armazenamentoDeTexto.Name = "armazenamentoDeTexto";
            this.armazenamentoDeTexto.Size = new System.Drawing.Size(100, 20);
            this.armazenamentoDeTexto.TabIndex = 0;
            this.armazenamentoDeTexto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menssagemInicial
            // 
            this.menssagemInicial.AutoSize = true;
            this.menssagemInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menssagemInicial.Location = new System.Drawing.Point(20, 21);
            this.menssagemInicial.Name = "menssagemInicial";
            this.menssagemInicial.Size = new System.Drawing.Size(131, 18);
            this.menssagemInicial.TabIndex = 1;
            this.menssagemInicial.Text = "Digite um nome:";
            this.menssagemInicial.Click += new System.EventHandler(this.menssagem1_Click);
            // 
            // botaoEnviar
            // 
            this.botaoEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoEnviar.Location = new System.Drawing.Point(23, 81);
            this.botaoEnviar.Name = "botaoEnviar";
            this.botaoEnviar.Size = new System.Drawing.Size(75, 23);
            this.botaoEnviar.TabIndex = 2;
            this.botaoEnviar.Text = "Enviar";
            this.botaoEnviar.UseVisualStyleBackColor = true;
            this.botaoEnviar.Click += new System.EventHandler(this.botao1_Click);
            // 
            // menssagemFinal
            // 
            this.menssagemFinal.AutoSize = true;
            this.menssagemFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menssagemFinal.Location = new System.Drawing.Point(20, 119);
            this.menssagemFinal.Name = "menssagemFinal";
            this.menssagemFinal.Size = new System.Drawing.Size(166, 18);
            this.menssagemFinal.TabIndex = 3;
            this.menssagemFinal.Text = "O nome digitado foi: ";
            this.menssagemFinal.Click += new System.EventHandler(this.menssagem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menssagemFinal);
            this.Controls.Add(this.botaoEnviar);
            this.Controls.Add(this.menssagemInicial);
            this.Controls.Add(this.armazenamentoDeTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox armazenamentoDeTexto;
        private System.Windows.Forms.Label menssagemInicial;
        private System.Windows.Forms.Button botaoEnviar;
        private System.Windows.Forms.Label menssagemFinal;
    }
}

