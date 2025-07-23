namespace EMISSAO_NOTAS
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirNotaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirOrçamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDeNotasEmitidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarEmpresaToolStripMenuItem,
            this.cadastrarCarroToolStripMenuItem,
            this.emitirNotaFiscalToolStripMenuItem,
            this.emitirOrçamentoToolStripMenuItem,
            this.históricoDeNotasEmitidasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarEmpresaToolStripMenuItem
            // 
            this.cadastrarEmpresaToolStripMenuItem.Name = "cadastrarEmpresaToolStripMenuItem";
            this.cadastrarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.cadastrarEmpresaToolStripMenuItem.Text = "Cadastrar Empresa";
            // 
            // cadastrarCarroToolStripMenuItem
            // 
            this.cadastrarCarroToolStripMenuItem.Name = "cadastrarCarroToolStripMenuItem";
            this.cadastrarCarroToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.cadastrarCarroToolStripMenuItem.Text = "Cadastrar Carro";
            // 
            // emitirNotaFiscalToolStripMenuItem
            // 
            this.emitirNotaFiscalToolStripMenuItem.Name = "emitirNotaFiscalToolStripMenuItem";
            this.emitirNotaFiscalToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.emitirNotaFiscalToolStripMenuItem.Text = "Emitir Nota Fiscal ";
            // 
            // emitirOrçamentoToolStripMenuItem
            // 
            this.emitirOrçamentoToolStripMenuItem.Name = "emitirOrçamentoToolStripMenuItem";
            this.emitirOrçamentoToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.emitirOrçamentoToolStripMenuItem.Text = "Emitir Orçamento";
            // 
            // históricoDeNotasEmitidasToolStripMenuItem
            // 
            this.históricoDeNotasEmitidasToolStripMenuItem.Name = "históricoDeNotasEmitidasToolStripMenuItem";
            this.históricoDeNotasEmitidasToolStripMenuItem.Size = new System.Drawing.Size(165, 20);
            this.históricoDeNotasEmitidasToolStripMenuItem.Text = "Histórico de Notas Emitidas";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 290);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirNotaFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirOrçamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoDeNotasEmitidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}