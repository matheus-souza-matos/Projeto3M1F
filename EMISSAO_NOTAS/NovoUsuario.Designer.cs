namespace EMISSAO_NOTAS
{
    partial class NovoUsuario
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
            this.btnCadastrarNovoUsuario = new System.Windows.Forms.Button();
            this.txtSenhaNovoUsuario = new System.Windows.Forms.TextBox();
            this.txtNovoUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuarioNovo = new System.Windows.Forms.Label();
            this.lblSenhaNovoUsuario = new System.Windows.Forms.Label();
            this.txtIdUsuarioCadastrado = new System.Windows.Forms.TextBox();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrarNovoUsuario
            // 
            this.btnCadastrarNovoUsuario.Location = new System.Drawing.Point(162, 200);
            this.btnCadastrarNovoUsuario.Name = "btnCadastrarNovoUsuario";
            this.btnCadastrarNovoUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarNovoUsuario.TabIndex = 0;
            this.btnCadastrarNovoUsuario.Text = "Cadastrar";
            this.btnCadastrarNovoUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarNovoUsuario.Click += new System.EventHandler(this.btnCadastrarNovoUsuario_Click);
            // 
            // txtSenhaNovoUsuario
            // 
            this.txtSenhaNovoUsuario.Location = new System.Drawing.Point(76, 146);
            this.txtSenhaNovoUsuario.Name = "txtSenhaNovoUsuario";
            this.txtSenhaNovoUsuario.Size = new System.Drawing.Size(161, 20);
            this.txtSenhaNovoUsuario.TabIndex = 1;
            // 
            // txtNovoUsuario
            // 
            this.txtNovoUsuario.Location = new System.Drawing.Point(76, 85);
            this.txtNovoUsuario.Name = "txtNovoUsuario";
            this.txtNovoUsuario.Size = new System.Drawing.Size(161, 20);
            this.txtNovoUsuario.TabIndex = 2;
            // 
            // lblUsuarioNovo
            // 
            this.lblUsuarioNovo.AutoSize = true;
            this.lblUsuarioNovo.Location = new System.Drawing.Point(73, 69);
            this.lblUsuarioNovo.Name = "lblUsuarioNovo";
            this.lblUsuarioNovo.Size = new System.Drawing.Size(46, 13);
            this.lblUsuarioNovo.TabIndex = 3;
            this.lblUsuarioNovo.Text = "Usuário:";
            // 
            // lblSenhaNovoUsuario
            // 
            this.lblSenhaNovoUsuario.AutoSize = true;
            this.lblSenhaNovoUsuario.Location = new System.Drawing.Point(73, 130);
            this.lblSenhaNovoUsuario.Name = "lblSenhaNovoUsuario";
            this.lblSenhaNovoUsuario.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaNovoUsuario.TabIndex = 4;
            this.lblSenhaNovoUsuario.Text = "Senha:";
            // 
            // txtIdUsuarioCadastrado
            // 
            this.txtIdUsuarioCadastrado.Location = new System.Drawing.Point(186, 31);
            this.txtIdUsuarioCadastrado.Name = "txtIdUsuarioCadastrado";
            this.txtIdUsuarioCadastrado.Size = new System.Drawing.Size(51, 20);
            this.txtIdUsuarioCadastrado.TabIndex = 5;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(186, 12);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(21, 13);
            this.lblIdUsuario.TabIndex = 6;
            this.lblIdUsuario.Text = "ID:";
            // 
            // NovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 302);
            this.Controls.Add(this.lblIdUsuario);
            this.Controls.Add(this.txtIdUsuarioCadastrado);
            this.Controls.Add(this.lblSenhaNovoUsuario);
            this.Controls.Add(this.lblUsuarioNovo);
            this.Controls.Add(this.txtNovoUsuario);
            this.Controls.Add(this.txtSenhaNovoUsuario);
            this.Controls.Add(this.btnCadastrarNovoUsuario);
            this.Name = "NovoUsuario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NovoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarNovoUsuario;
        private System.Windows.Forms.TextBox txtSenhaNovoUsuario;
        private System.Windows.Forms.TextBox txtNovoUsuario;
        private System.Windows.Forms.Label lblUsuarioNovo;
        private System.Windows.Forms.Label lblSenhaNovoUsuario;
        private System.Windows.Forms.TextBox txtIdUsuarioCadastrado;
        private System.Windows.Forms.Label lblIdUsuario;
    }
}