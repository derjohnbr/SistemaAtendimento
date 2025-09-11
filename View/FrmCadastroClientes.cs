using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAtendimento.Controller;
using SistemaAtendimento.Model;

namespace SistemaAtendimento
{
    public partial class FrmCadastroClientes : Form
    {
        private ClienteController _clienteController;
        public FrmCadastroClientes()
        {
            InitializeComponent();
            _clienteController = new ClienteController(this);
        }

        private void FrmCadastroClientes_Load(object sender, EventArgs e)
        {
            _clienteController.ListarClientes();

            dgvClientes.Columns["Id"].HeaderText = "Código";
            dgvClientes.Columns["Nome"].HeaderText = "Nome Completo";
            dgvClientes.Columns["Email"].HeaderText = "E-mail";
            dgvClientes.Columns["Cpf_Cnpj"].HeaderText = "CPF / CNPJ";
            dgvClientes.Columns["TipoPessoa"].HeaderText = "Tipo Pessoa";
            dgvClientes.Columns["Telefone"].HeaderText = "Telefone";
            dgvClientes.Columns["Celular"].HeaderText = "Celular";
            dgvClientes.Columns["Cep"].HeaderText = "CEP";
            dgvClientes.Columns["Endereco"].HeaderText = "Endereço";
            dgvClientes.Columns["Numero"].HeaderText = "Número";
            dgvClientes.Columns["Complemento"].HeaderText = "Complemento";
            dgvClientes.Columns["Bairro"].HeaderText = "Bairro";
            dgvClientes.Columns["Cidade"].HeaderText = "Cidade";
            dgvClientes.Columns["Estado"].HeaderText = "Estado";
            dgvClientes.Columns["Ativo"].HeaderText = "Ativo";

            // Preenche o grid com ajuste automático
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Ajuste individual:
            dgvClientes.Columns["Id"].Width = 60;
            dgvClientes.Columns["Nome"].Width = 200;
            dgvClientes.Columns["Email"].Width = 200;
            dgvClientes.Columns["Cpf_Cnpj"].Width = 100;
            dgvClientes.Columns["TipoPessoa"].Width = 80;
            dgvClientes.Columns["Telefone"].Width = 100;
            dgvClientes.Columns["Celular"].Width = 100;
            dgvClientes.Columns["Cep"].Width = 80;
            dgvClientes.Columns["Endereco"].Width = 150;
            dgvClientes.Columns["Numero"].Width = 60;
            dgvClientes.Columns["Complemento"].Width = 100;
            dgvClientes.Columns["Bairro"].Width = 120;
            dgvClientes.Columns["Cidade"].Width = 120;
            dgvClientes.Columns["Estado"].Width = 50;
            dgvClientes.Columns["Ativo"].Width = 60;
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public void ExibirClientes(List<Clientes> clientes)
        {
            dgvClientes.DataSource = clientes;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes 
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Cpf_Cnpj = txtCpfCnpj.Text,
                TipoPessoa = rdbFisica.Checked ? "F" : "J",
                Telefone = txtTelefone.Text,
                Celular = txtCelular.Text,
                Cep = txtCep.Text,
                Endereco = txtEndereco.Text,
                Numero = txtNumero.Text,
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Estado = cbxEstado.Text,
                Ativo = rdbAtivo.Checked,
            };

            if (!ValidarDados(cliente))
                return;

            _clienteController.Salvar(cliente);
        }

        public bool ValidarDados(Clientes cliente)
        {
            if(string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O campo Nome é obrigatório.");
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ExibirMensagem("O campo E-mail é obrigatório.");
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCpfCnpj.Text))
            {
                //if (rdbFisica.Checked)
                //    ExibirMensagem("O campo CPF é obrigatório.");
                //else
                //    ExibirMensagem("O campo CNPJ é obrigatório.");

                //Usando Operador Ternário não poder usar Comandos apenas retorna valor                
                ExibirMensagem((rdbFisica.Checked) ? "O campo CPF é obrigatório." : "O campo CNPJ é obrigatório.");

                txtCpfCnpj.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCep.Text))
            {
                ExibirMensagem("O campo CEP é obrigatório.");
                txtCep.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                ExibirMensagem("O campo Endereço é obrigatório.");
                txtEndereco.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                ExibirMensagem("O campo Número é obrigatório.");
                txtNumero.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace (txtBairro.Text)) 
            {
                ExibirMensagem("O campo Bairro é obrigatório.");
                txtBairro.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                ExibirMensagem("O campo Cidade é obrigatório.");
                txtCidade.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbxEstado.Text))
            {
                ExibirMensagem("O campo Estado é obrigatório.");
                cbxEstado.Focus();
                return false;
            }


            return true;
        }
    }
}
