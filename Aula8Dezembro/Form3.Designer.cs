namespace Aula8Dezembro
{
    partial class Form3
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
            this.InputNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelIdade = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.InputIdade = new System.Windows.Forms.TextBox();
            this.InputEmail = new System.Windows.Forms.TextBox();
            this.BotaoEnviar = new System.Windows.Forms.Button();
            this.labelMenssagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputNome
            // 
            this.InputNome.Location = new System.Drawing.Point(48, 92);
            this.InputNome.Name = "InputNome";
            this.InputNome.Size = new System.Drawing.Size(100, 20);
            this.InputNome.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(45, 63);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(53, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome: ";
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdade.Location = new System.Drawing.Point(48, 129);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(47, 20);
            this.labelIdade.TabIndex = 2;
            this.labelIdade.Text = "Idade:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(50, 192);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 20);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email:";
            // 
            // InputIdade
            // 
            this.InputIdade.Location = new System.Drawing.Point(48, 158);
            this.InputIdade.Name = "InputIdade";
            this.InputIdade.Size = new System.Drawing.Size(100, 20);
            this.InputIdade.TabIndex = 4;
            // 
            // InputEmail
            // 
            this.InputEmail.Location = new System.Drawing.Point(48, 225);
            this.InputEmail.Name = "InputEmail";
            this.InputEmail.Size = new System.Drawing.Size(100, 20);
            this.InputEmail.TabIndex = 5;
            // 
            // BotaoEnviar
            // 
            this.BotaoEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BotaoEnviar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoEnviar.Location = new System.Drawing.Point(49, 281);
            this.BotaoEnviar.Name = "BotaoEnviar";
            this.BotaoEnviar.Size = new System.Drawing.Size(64, 29);
            this.BotaoEnviar.TabIndex = 6;
            this.BotaoEnviar.Text = "Enviar";
            this.BotaoEnviar.UseVisualStyleBackColor = false;
            this.BotaoEnviar.Click += new System.EventHandler(this.BotaoEnviar_Click);
            // 
            // labelMenssagem
            // 
            this.labelMenssagem.AutoSize = true;
            this.labelMenssagem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenssagem.Location = new System.Drawing.Point(267, 154);
            this.labelMenssagem.Name = "labelMenssagem";
            this.labelMenssagem.Size = new System.Drawing.Size(0, 22);
            this.labelMenssagem.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMenssagem);
            this.Controls.Add(this.BotaoEnviar);
            this.Controls.Add(this.InputEmail);
            this.Controls.Add(this.InputIdade);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.InputNome);
            this.Controls.Add(this.labelNome);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox InputIdade;
        private System.Windows.Forms.TextBox InputEmail;
        private System.Windows.Forms.Button BotaoEnviar;
        private System.Windows.Forms.Label labelMenssagem;
    }
}