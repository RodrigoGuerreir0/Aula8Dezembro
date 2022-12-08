namespace Aula8Dezembro
{
    partial class Form2
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
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.inputTexto = new System.Windows.Forms.TextBox();
            this.Tela = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Location = new System.Drawing.Point(453, 12);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(92, 39);
            this.botaoLimpar.TabIndex = 0;
            this.botaoLimpar.Text = "Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            this.botaoLimpar.UseWaitCursor = true;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // inputTexto
            // 
            this.inputTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTexto.ImeMode = System.Windows.Forms.ImeMode.On;
            this.inputTexto.Location = new System.Drawing.Point(13, 12);
            this.inputTexto.Name = "inputTexto";
            this.inputTexto.Size = new System.Drawing.Size(115, 22);
            this.inputTexto.TabIndex = 1;
            this.inputTexto.UseWaitCursor = true;
            this.inputTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // Tela
            // 
            this.Tela.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Tela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tela.Location = new System.Drawing.Point(12, 50);
            this.Tela.MaxLength = 90000;
            this.Tela.Multiline = true;
            this.Tela.Name = "Tela";
            this.Tela.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tela.Size = new System.Drawing.Size(411, 354);
            this.Tela.TabIndex = 2;
            this.Tela.UseWaitCursor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(557, 435);
            this.Controls.Add(this.Tela);
            this.Controls.Add(this.inputTexto);
            this.Controls.Add(this.botaoLimpar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.TextBox inputTexto;
        private System.Windows.Forms.TextBox Tela;
    }
}