namespace SistemaAtendimento.View
{
    partial class FrmAntendimento
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAntendimento));
            lblCodigoAtendimento = new Label();
            txtCodigoAtendimento = new TextBox();
            grbDadosCliente = new GroupBox();
            btnCancelar = new Button();
            imlIcones = new ImageList(components);
            btnNovo = new Button();
            btnFinalizar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            txtObservacaoAtendimento = new TextBox();
            cbxSituacaoAtendimento = new ComboBox();
            dtpAberturaAtendimento = new DateTimePicker();
            cbxNomeCliente = new ComboBox();
            txtCodigoCliente = new TextBox();
            lblObservacaoAtendimento = new Label();
            lblSituacaoAtendimento = new Label();
            lblAbertura = new Label();
            lblNomeCliente = new Label();
            lblCodigoCliente = new Label();
            grbEtapasAtendimento = new GroupBox();
            dgvEtapasAtendimento = new DataGridView();
            btnExcluirEtapa = new Button();
            btnAdicionarEtapa = new Button();
            txtEtapaObservacao = new TextBox();
            cbxEtapaAtendimento = new ComboBox();
            lblEtapaObservacao = new Label();
            lblEtapaAtendimento = new Label();
            btnPesquisarAtendimento = new Button();
            grbDadosCliente.SuspendLayout();
            grbEtapasAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtapasAtendimento).BeginInit();
            SuspendLayout();
            // 
            // lblCodigoAtendimento
            // 
            lblCodigoAtendimento.AutoSize = true;
            lblCodigoAtendimento.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigoAtendimento.Location = new Point(535, 16);
            lblCodigoAtendimento.Name = "lblCodigoAtendimento";
            lblCodigoAtendimento.Size = new Size(171, 32);
            lblCodigoAtendimento.TabIndex = 0;
            lblCodigoAtendimento.Text = "Atendimento:";
            // 
            // txtCodigoAtendimento
            // 
            txtCodigoAtendimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigoAtendimento.Location = new Point(712, 16);
            txtCodigoAtendimento.Name = "txtCodigoAtendimento";
            txtCodigoAtendimento.Size = new Size(131, 29);
            txtCodigoAtendimento.TabIndex = 1;
            // 
            // grbDadosCliente
            // 
            grbDadosCliente.Controls.Add(btnCancelar);
            grbDadosCliente.Controls.Add(btnNovo);
            grbDadosCliente.Controls.Add(btnFinalizar);
            grbDadosCliente.Controls.Add(btnExcluir);
            grbDadosCliente.Controls.Add(btnEditar);
            grbDadosCliente.Controls.Add(btnSalvar);
            grbDadosCliente.Controls.Add(txtObservacaoAtendimento);
            grbDadosCliente.Controls.Add(cbxSituacaoAtendimento);
            grbDadosCliente.Controls.Add(dtpAberturaAtendimento);
            grbDadosCliente.Controls.Add(cbxNomeCliente);
            grbDadosCliente.Controls.Add(txtCodigoCliente);
            grbDadosCliente.Controls.Add(lblObservacaoAtendimento);
            grbDadosCliente.Controls.Add(lblSituacaoAtendimento);
            grbDadosCliente.Controls.Add(lblAbertura);
            grbDadosCliente.Controls.Add(lblNomeCliente);
            grbDadosCliente.Controls.Add(lblCodigoCliente);
            grbDadosCliente.Location = new Point(12, 58);
            grbDadosCliente.Name = "grbDadosCliente";
            grbDadosCliente.Size = new Size(881, 230);
            grbDadosCliente.TabIndex = 2;
            grbDadosCliente.TabStop = false;
            grbDadosCliente.Text = "Dados do Cliente";
            // 
            // btnCancelar
            // 
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageKey = "icone-cancelar.png";
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(439, 183);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 34);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // imlIcones
            // 
            imlIcones.ColorDepth = ColorDepth.Depth32Bit;
            imlIcones.ImageStream = (ImageListStreamer)resources.GetObject("imlIcones.ImageStream");
            imlIcones.TransparentColor = Color.Transparent;
            imlIcones.Images.SetKeyName(0, "icone-cancelar.png");
            imlIcones.Images.SetKeyName(1, "icone-editar.png");
            imlIcones.Images.SetKeyName(2, "icone-excluir.png");
            imlIcones.Images.SetKeyName(3, "icone-novo.png");
            imlIcones.Images.SetKeyName(4, "icone-pesquisar.png");
            imlIcones.Images.SetKeyName(5, "icone-salvar.png");
            imlIcones.Images.SetKeyName(6, "Finish Flag.png");
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageKey = "icone-novo.png";
            btnNovo.ImageList = imlIcones;
            btnNovo.Location = new Point(15, 183);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(100, 34);
            btnNovo.TabIndex = 14;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            btnFinalizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizar.ImageKey = "Finish Flag.png";
            btnFinalizar.ImageList = imlIcones;
            btnFinalizar.Location = new Point(775, 183);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(100, 34);
            btnFinalizar.TabIndex = 13;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageKey = "icone-excluir.png";
            btnExcluir.ImageList = imlIcones;
            btnExcluir.Location = new Point(333, 183);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(100, 34);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageKey = "icone-editar.png";
            btnEditar.ImageList = imlIcones;
            btnEditar.Location = new Point(121, 183);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 34);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageKey = "icone-salvar.png";
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(227, 183);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 34);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtObservacaoAtendimento
            // 
            txtObservacaoAtendimento.Location = new Point(227, 101);
            txtObservacaoAtendimento.Multiline = true;
            txtObservacaoAtendimento.Name = "txtObservacaoAtendimento";
            txtObservacaoAtendimento.Size = new Size(648, 76);
            txtObservacaoAtendimento.TabIndex = 6;
            // 
            // cbxSituacaoAtendimento
            // 
            cbxSituacaoAtendimento.FormattingEnabled = true;
            cbxSituacaoAtendimento.Location = new Point(15, 101);
            cbxSituacaoAtendimento.Name = "cbxSituacaoAtendimento";
            cbxSituacaoAtendimento.Size = new Size(206, 23);
            cbxSituacaoAtendimento.TabIndex = 5;
            // 
            // dtpAberturaAtendimento
            // 
            dtpAberturaAtendimento.Location = new Point(652, 45);
            dtpAberturaAtendimento.Name = "dtpAberturaAtendimento";
            dtpAberturaAtendimento.Size = new Size(223, 23);
            dtpAberturaAtendimento.TabIndex = 4;
            // 
            // cbxNomeCliente
            // 
            cbxNomeCliente.FormattingEnabled = true;
            cbxNomeCliente.Location = new Point(121, 45);
            cbxNomeCliente.Name = "cbxNomeCliente";
            cbxNomeCliente.Size = new Size(525, 23);
            cbxNomeCliente.TabIndex = 3;
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(15, 45);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.Size = new Size(100, 23);
            txtCodigoCliente.TabIndex = 2;
            // 
            // lblObservacaoAtendimento
            // 
            lblObservacaoAtendimento.AutoSize = true;
            lblObservacaoAtendimento.Location = new Point(227, 83);
            lblObservacaoAtendimento.Name = "lblObservacaoAtendimento";
            lblObservacaoAtendimento.Size = new Size(74, 15);
            lblObservacaoAtendimento.TabIndex = 4;
            lblObservacaoAtendimento.Text = "Observações";
            // 
            // lblSituacaoAtendimento
            // 
            lblSituacaoAtendimento.AutoSize = true;
            lblSituacaoAtendimento.Location = new Point(15, 83);
            lblSituacaoAtendimento.Name = "lblSituacaoAtendimento";
            lblSituacaoAtendimento.Size = new Size(142, 15);
            lblSituacaoAtendimento.TabIndex = 3;
            lblSituacaoAtendimento.Text = "Situação do Atendimento";
            // 
            // lblAbertura
            // 
            lblAbertura.AutoSize = true;
            lblAbertura.Location = new Point(652, 23);
            lblAbertura.Name = "lblAbertura";
            lblAbertura.Size = new Size(80, 15);
            lblAbertura.TabIndex = 2;
            lblAbertura.Text = "Data Abertura";
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(121, 27);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(40, 15);
            lblNomeCliente.TabIndex = 1;
            lblNomeCliente.Text = "Nome";
            // 
            // lblCodigoCliente
            // 
            lblCodigoCliente.AutoSize = true;
            lblCodigoCliente.Location = new Point(15, 27);
            lblCodigoCliente.Name = "lblCodigoCliente";
            lblCodigoCliente.Size = new Size(72, 15);
            lblCodigoCliente.TabIndex = 0;
            lblCodigoCliente.Text = "Cod. Cliente";
            // 
            // grbEtapasAtendimento
            // 
            grbEtapasAtendimento.Controls.Add(dgvEtapasAtendimento);
            grbEtapasAtendimento.Controls.Add(btnExcluirEtapa);
            grbEtapasAtendimento.Controls.Add(btnAdicionarEtapa);
            grbEtapasAtendimento.Controls.Add(txtEtapaObservacao);
            grbEtapasAtendimento.Controls.Add(cbxEtapaAtendimento);
            grbEtapasAtendimento.Controls.Add(lblEtapaObservacao);
            grbEtapasAtendimento.Controls.Add(lblEtapaAtendimento);
            grbEtapasAtendimento.Location = new Point(12, 308);
            grbEtapasAtendimento.Name = "grbEtapasAtendimento";
            grbEtapasAtendimento.Size = new Size(881, 270);
            grbEtapasAtendimento.TabIndex = 3;
            grbEtapasAtendimento.TabStop = false;
            grbEtapasAtendimento.Text = "Etapas do Atendimento";
            // 
            // dgvEtapasAtendimento
            // 
            dgvEtapasAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEtapasAtendimento.Location = new Point(292, 31);
            dgvEtapasAtendimento.Name = "dgvEtapasAtendimento";
            dgvEtapasAtendimento.Size = new Size(583, 224);
            dgvEtapasAtendimento.TabIndex = 6;
            // 
            // btnExcluirEtapa
            // 
            btnExcluirEtapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirEtapa.ImageKey = "icone-cancelar.png";
            btnExcluirEtapa.ImageList = imlIcones;
            btnExcluirEtapa.Location = new Point(157, 223);
            btnExcluirEtapa.Name = "btnExcluirEtapa";
            btnExcluirEtapa.Size = new Size(129, 32);
            btnExcluirEtapa.TabIndex = 5;
            btnExcluirEtapa.Text = "Excluir Etapa";
            btnExcluirEtapa.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarEtapa
            // 
            btnAdicionarEtapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionarEtapa.ImageKey = "icone-novo.png";
            btnAdicionarEtapa.ImageList = imlIcones;
            btnAdicionarEtapa.Location = new Point(15, 223);
            btnAdicionarEtapa.Name = "btnAdicionarEtapa";
            btnAdicionarEtapa.Size = new Size(136, 32);
            btnAdicionarEtapa.TabIndex = 4;
            btnAdicionarEtapa.Text = "Adicionar Etapa";
            btnAdicionarEtapa.UseVisualStyleBackColor = true;
            // 
            // txtEtapaObservacao
            // 
            txtEtapaObservacao.Location = new Point(15, 102);
            txtEtapaObservacao.Multiline = true;
            txtEtapaObservacao.Name = "txtEtapaObservacao";
            txtEtapaObservacao.Size = new Size(271, 102);
            txtEtapaObservacao.TabIndex = 2;
            // 
            // cbxEtapaAtendimento
            // 
            cbxEtapaAtendimento.FormattingEnabled = true;
            cbxEtapaAtendimento.Location = new Point(15, 49);
            cbxEtapaAtendimento.Name = "cbxEtapaAtendimento";
            cbxEtapaAtendimento.Size = new Size(271, 23);
            cbxEtapaAtendimento.TabIndex = 1;
            // 
            // lblEtapaObservacao
            // 
            lblEtapaObservacao.AutoSize = true;
            lblEtapaObservacao.Location = new Point(15, 84);
            lblEtapaObservacao.Name = "lblEtapaObservacao";
            lblEtapaObservacao.Size = new Size(74, 15);
            lblEtapaObservacao.TabIndex = 1;
            lblEtapaObservacao.Text = "Observações";
            // 
            // lblEtapaAtendimento
            // 
            lblEtapaAtendimento.AutoSize = true;
            lblEtapaAtendimento.Location = new Point(15, 31);
            lblEtapaAtendimento.Name = "lblEtapaAtendimento";
            lblEtapaAtendimento.Size = new Size(126, 15);
            lblEtapaAtendimento.TabIndex = 0;
            lblEtapaAtendimento.Text = "Etapa do Atendimento";
            // 
            // btnPesquisarAtendimento
            // 
            btnPesquisarAtendimento.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisarAtendimento.ImageKey = "icone-pesquisar.png";
            btnPesquisarAtendimento.ImageList = imlIcones;
            btnPesquisarAtendimento.Location = new Point(12, 11);
            btnPesquisarAtendimento.Name = "btnPesquisarAtendimento";
            btnPesquisarAtendimento.Size = new Size(188, 34);
            btnPesquisarAtendimento.TabIndex = 12;
            btnPesquisarAtendimento.Text = "Pesquisar Atendimento";
            btnPesquisarAtendimento.UseVisualStyleBackColor = true;
            // 
            // FrmAntendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 581);
            Controls.Add(btnPesquisarAtendimento);
            Controls.Add(grbEtapasAtendimento);
            Controls.Add(grbDadosCliente);
            Controls.Add(txtCodigoAtendimento);
            Controls.Add(lblCodigoAtendimento);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAntendimento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atendimento";
            grbDadosCliente.ResumeLayout(false);
            grbDadosCliente.PerformLayout();
            grbEtapasAtendimento.ResumeLayout(false);
            grbEtapasAtendimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtapasAtendimento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigoAtendimento;
        private TextBox txtCodigoAtendimento;
        private GroupBox grbDadosCliente;
        private ComboBox cbxNomeCliente;
        private TextBox txtCodigoCliente;
        private Label lblObservacaoAtendimento;
        private Label lblSituacaoAtendimento;
        private Label lblAbertura;
        private Label lblNomeCliente;
        private Label lblCodigoCliente;
        private GroupBox grbEtapasAtendimento;
        private Button btnEditar;
        private Button btnSalvar;
        private TextBox txtObservacaoAtendimento;
        private ComboBox cbxSituacaoAtendimento;
        private DateTimePicker dtpAberturaAtendimento;
        private TextBox txtEtapaObservacao;
        private ComboBox cbxEtapaAtendimento;
        private Label lblEtapaObservacao;
        private Label lblEtapaAtendimento;
        private DataGridView dgvEtapasAtendimento;
        private Button btnExcluirEtapa;
        private Button btnAdicionarEtapa;
        private ImageList imlIcones;
        private Button btnPesquisarAtendimento;
        private Button btnNovo;
        private Button btnFinalizar;
        private Button btnExcluir;
        private Button btnCancelar;
    }
}