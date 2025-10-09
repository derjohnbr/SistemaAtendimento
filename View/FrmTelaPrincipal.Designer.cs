namespace SistemaAtendimento
{
    partial class FrmTelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuTelaPrincipal = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            etapasToolStripMenuItem = new ToolStripMenuItem();
            situacaoAtendimento = new ToolStripMenuItem();
            atendimentosToolStripMenuItem = new ToolStripMenuItem();
            novoAtendimentoToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            btnConexao_Click = new Button();
            mnuTelaPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnuTelaPrincipal
            // 
            mnuTelaPrincipal.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, atendimentosToolStripMenuItem, sistemaToolStripMenuItem });
            mnuTelaPrincipal.Location = new Point(0, 0);
            mnuTelaPrincipal.Name = "mnuTelaPrincipal";
            mnuTelaPrincipal.Size = new Size(1240, 24);
            mnuTelaPrincipal.TabIndex = 0;
            mnuTelaPrincipal.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, usuáriosToolStripMenuItem, etapasToolStripMenuItem, situacaoAtendimento });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(197, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(197, 22);
            usuáriosToolStripMenuItem.Text = "Usuários";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // etapasToolStripMenuItem
            // 
            etapasToolStripMenuItem.Name = "etapasToolStripMenuItem";
            etapasToolStripMenuItem.Size = new Size(197, 22);
            etapasToolStripMenuItem.Text = "Etapas";
            etapasToolStripMenuItem.Click += etapasToolStripMenuItem_Click;
            // 
            // situacaoAtendimento
            // 
            situacaoAtendimento.Name = "situacaoAtendimento";
            situacaoAtendimento.Size = new Size(197, 22);
            situacaoAtendimento.Text = "Situação Atendimentos";
            situacaoAtendimento.Click += statusAtendimentosToolStripMenuItem_Click;
            // 
            // atendimentosToolStripMenuItem
            // 
            atendimentosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoAtendimentoToolStripMenuItem, consultasToolStripMenuItem });
            atendimentosToolStripMenuItem.Name = "atendimentosToolStripMenuItem";
            atendimentosToolStripMenuItem.Size = new Size(94, 20);
            atendimentosToolStripMenuItem.Text = "Atendimentos";
            // 
            // novoAtendimentoToolStripMenuItem
            // 
            novoAtendimentoToolStripMenuItem.Name = "novoAtendimentoToolStripMenuItem";
            novoAtendimentoToolStripMenuItem.Size = new Size(180, 22);
            novoAtendimentoToolStripMenuItem.Text = "Novo Atendimento";
            novoAtendimentoToolStripMenuItem.Click += novoAtendimentoToolStripMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(180, 22);
            consultasToolStripMenuItem.Text = "Consultas";
            consultasToolStripMenuItem.Click += consultasToolStripMenuItem_Click;
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(60, 20);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // btnConexao_Click
            // 
            btnConexao_Click.Location = new Point(1117, 768);
            btnConexao_Click.Name = "btnConexao_Click";
            btnConexao_Click.Size = new Size(111, 23);
            btnConexao_Click.TabIndex = 1;
            btnConexao_Click.Text = "Teste Conexão";
            btnConexao_Click.UseVisualStyleBackColor = true;
            btnConexao_Click.Click += btnConexao_Click_Click;
            // 
            // FrmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 800);
            Controls.Add(btnConexao_Click);
            Controls.Add(mnuTelaPrincipal);
            MainMenuStrip = mnuTelaPrincipal;
            Name = "FrmTelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Atendimento";
            mnuTelaPrincipal.ResumeLayout(false);
            mnuTelaPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuTelaPrincipal;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem etapasToolStripMenuItem;
        private ToolStripMenuItem situacaoAtendimento;
        private ToolStripMenuItem atendimentosToolStripMenuItem;
        private ToolStripMenuItem novoAtendimentoToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Button btnConexao_Click;
    }
}
