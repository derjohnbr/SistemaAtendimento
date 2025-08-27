namespace SistemaAtendimento
{
    partial class FrmCadastroClientes
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
            grbDadosCliente = new GroupBox();
            lblEstado = new Label();
            cbxEstado = new ComboBox();
            pnlSituacao = new Panel();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            txtCidade = new TextBox();
            lblSituacao = new Label();
            txtComplemento = new TextBox();
            txtBairro = new TextBox();
            lblCidade = new Label();
            lblComplemento = new Label();
            lblBairro = new Label();
            txtNumero = new TextBox();
            txtEndereco = new TextBox();
            txtCep = new TextBox();
            lblNumero = new Label();
            lblEndereco = new Label();
            lblCep = new Label();
            txtCpfCnpj = new TextBox();
            lblCpfCnpj = new Label();
            pnlTipoPessoa = new Panel();
            rdbJuridica = new RadioButton();
            rdbFisica = new RadioButton();
            lblTipoPessoa = new Label();
            txtCelular = new TextBox();
            txtTelefone = new TextBox();
            lblCelular = new Label();
            lblTelefone = new Label();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            lblEmail = new Label();
            lblNome = new Label();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            btnNovo = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            lblPesquisar = new Label();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            grbListaClientes = new GroupBox();
            dgvClientes = new DataGridView();
            grbDadosCliente.SuspendLayout();
            pnlSituacao.SuspendLayout();
            pnlTipoPessoa.SuspendLayout();
            grbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // grbDadosCliente
            // 
            grbDadosCliente.Controls.Add(lblEstado);
            grbDadosCliente.Controls.Add(cbxEstado);
            grbDadosCliente.Controls.Add(pnlSituacao);
            grbDadosCliente.Controls.Add(txtCidade);
            grbDadosCliente.Controls.Add(lblSituacao);
            grbDadosCliente.Controls.Add(txtComplemento);
            grbDadosCliente.Controls.Add(txtBairro);
            grbDadosCliente.Controls.Add(lblCidade);
            grbDadosCliente.Controls.Add(lblComplemento);
            grbDadosCliente.Controls.Add(lblBairro);
            grbDadosCliente.Controls.Add(txtNumero);
            grbDadosCliente.Controls.Add(txtEndereco);
            grbDadosCliente.Controls.Add(txtCep);
            grbDadosCliente.Controls.Add(lblNumero);
            grbDadosCliente.Controls.Add(lblEndereco);
            grbDadosCliente.Controls.Add(lblCep);
            grbDadosCliente.Controls.Add(txtCpfCnpj);
            grbDadosCliente.Controls.Add(lblCpfCnpj);
            grbDadosCliente.Controls.Add(pnlTipoPessoa);
            grbDadosCliente.Controls.Add(lblTipoPessoa);
            grbDadosCliente.Controls.Add(txtCelular);
            grbDadosCliente.Controls.Add(txtTelefone);
            grbDadosCliente.Controls.Add(lblCelular);
            grbDadosCliente.Controls.Add(lblTelefone);
            grbDadosCliente.Controls.Add(txtEmail);
            grbDadosCliente.Controls.Add(txtNome);
            grbDadosCliente.Controls.Add(lblEmail);
            grbDadosCliente.Controls.Add(lblNome);
            grbDadosCliente.Controls.Add(lblCodigo);
            grbDadosCliente.Controls.Add(txtCodigo);
            grbDadosCliente.Location = new Point(12, 12);
            grbDadosCliente.Name = "grbDadosCliente";
            grbDadosCliente.Size = new Size(768, 320);
            grbDadosCliente.TabIndex = 0;
            grbDadosCliente.TabStop = false;
            grbDadosCliente.Text = "Dados do Cliente";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(15, 253);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 24;
            lblEstado.Text = "Estado";
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MS", "MT", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxEstado.Location = new Point(15, 271);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(193, 23);
            cbxEstado.TabIndex = 13;
            // 
            // pnlSituacao
            // 
            pnlSituacao.Controls.Add(rdbInativo);
            pnlSituacao.Controls.Add(rdbAtivo);
            pnlSituacao.Location = new Point(214, 266);
            pnlSituacao.Name = "pnlSituacao";
            pnlSituacao.Size = new Size(130, 36);
            pnlSituacao.TabIndex = 14;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(63, 8);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 1;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(3, 8);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 0;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(440, 214);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(308, 23);
            txtCidade.TabIndex = 12;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(217, 254);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 12;
            lblSituacao.Text = "Situação";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(217, 214);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(217, 23);
            txtComplemento.TabIndex = 11;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(15, 214);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(196, 23);
            txtBairro.TabIndex = 10;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(440, 196);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 22;
            lblCidade.Text = "Cidade";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(217, 196);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 21;
            lblComplemento.Text = "Complemento";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(15, 196);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 20;
            lblBairro.Text = "Bairro";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(498, 157);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(250, 23);
            txtNumero.TabIndex = 9;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(167, 157);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(325, 23);
            txtEndereco.TabIndex = 8;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(15, 157);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(146, 23);
            txtCep.TabIndex = 7;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(498, 139);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 16;
            lblNumero.Text = "Número";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(167, 139);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(56, 15);
            lblEndereco.TabIndex = 15;
            lblEndereco.Text = "Endereço";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(15, 139);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 14;
            lblCep.Text = "CEP";
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.Location = new Point(463, 93);
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.Size = new Size(285, 23);
            txtCpfCnpj.TabIndex = 6;
            // 
            // lblCpfCnpj
            // 
            lblCpfCnpj.AutoSize = true;
            lblCpfCnpj.Location = new Point(463, 75);
            lblCpfCnpj.Name = "lblCpfCnpj";
            lblCpfCnpj.Size = new Size(60, 15);
            lblCpfCnpj.TabIndex = 12;
            lblCpfCnpj.Text = "CPF/CNPJ";
            // 
            // pnlTipoPessoa
            // 
            pnlTipoPessoa.Controls.Add(rdbJuridica);
            pnlTipoPessoa.Controls.Add(rdbFisica);
            pnlTipoPessoa.Location = new Point(327, 87);
            pnlTipoPessoa.Name = "pnlTipoPessoa";
            pnlTipoPessoa.Size = new Size(130, 36);
            pnlTipoPessoa.TabIndex = 5;
            // 
            // rdbJuridica
            // 
            rdbJuridica.AutoSize = true;
            rdbJuridica.Location = new Point(63, 8);
            rdbJuridica.Name = "rdbJuridica";
            rdbJuridica.Size = new Size(65, 19);
            rdbJuridica.TabIndex = 1;
            rdbJuridica.TabStop = true;
            rdbJuridica.Text = "Jurídica";
            rdbJuridica.UseVisualStyleBackColor = true;
            // 
            // rdbFisica
            // 
            rdbFisica.AutoSize = true;
            rdbFisica.Location = new Point(3, 8);
            rdbFisica.Name = "rdbFisica";
            rdbFisica.Size = new Size(54, 19);
            rdbFisica.TabIndex = 0;
            rdbFisica.TabStop = true;
            rdbFisica.Text = "Física";
            rdbFisica.UseVisualStyleBackColor = true;
            // 
            // lblTipoPessoa
            // 
            lblTipoPessoa.AutoSize = true;
            lblTipoPessoa.Location = new Point(330, 75);
            lblTipoPessoa.Name = "lblTipoPessoa";
            lblTipoPessoa.Size = new Size(69, 15);
            lblTipoPessoa.TabIndex = 10;
            lblTipoPessoa.Text = "Tipo Pessoa";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(167, 93);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(154, 23);
            txtCelular.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(15, 93);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(146, 23);
            txtTelefone.TabIndex = 3;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(167, 75);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(44, 15);
            lblCelular.TabIndex = 7;
            lblCelular.Text = "Celular";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(15, 75);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(451, 37);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(297, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(121, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(324, 23);
            txtNome.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(451, 19);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "E-mail";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(121, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(15, 19);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(15, 37);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(12, 360);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 15;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(93, 360);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(174, 360);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(255, 360);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 18;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(336, 360);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(468, 342);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 6;
            lblPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(468, 360);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(231, 23);
            txtPesquisar.TabIndex = 20;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(705, 360);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 21;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // grbListaClientes
            // 
            grbListaClientes.Controls.Add(dgvClientes);
            grbListaClientes.Location = new Point(13, 411);
            grbListaClientes.Name = "grbListaClientes";
            grbListaClientes.Size = new Size(767, 232);
            grbListaClientes.TabIndex = 9;
            grbListaClientes.TabStop = false;
            grbListaClientes.Text = "Lista Clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(6, 22);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(755, 204);
            dgvClientes.TabIndex = 0;
            // 
            // FrmCadastroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 655);
            Controls.Add(grbListaClientes);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosCliente);
            Name = "FrmCadastroClientes";
            Text = "Cadastro de Clientes";
            Load += FrmCadastroClientes_Load;
            grbDadosCliente.ResumeLayout(false);
            grbDadosCliente.PerformLayout();
            pnlSituacao.ResumeLayout(false);
            pnlSituacao.PerformLayout();
            pnlTipoPessoa.ResumeLayout(false);
            pnlTipoPessoa.PerformLayout();
            grbListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbDadosCliente;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Label lblEmail;
        private Label lblNome;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private TextBox txtCelular;
        private TextBox txtTelefone;
        private Label lblCelular;
        private Label lblTelefone;
        private Panel pnlTipoPessoa;
        private RadioButton rdbFisica;
        private Label lblTipoPessoa;
        private RadioButton rdbJuridica;
        private TextBox txtCpfCnpj;
        private Label lblCpfCnpj;
        private TextBox txtCidade;
        private TextBox txtComplemento;
        private TextBox txtBairro;
        private Label lblCidade;
        private Label lblComplemento;
        private Label lblBairro;
        private TextBox txtNumero;
        private TextBox txtEndereco;
        private TextBox txtCep;
        private Label lblNumero;
        private Label lblEndereco;
        private Label lblCep;
        private Panel pnlSituacao;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private Label lblSituacao;
        private Label lblEstado;
        private ComboBox cbxEstado;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnCancelar;
        private Label lblPesquisar;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private GroupBox grbListaClientes;
        private DataGridView dgvClientes;
    }
}