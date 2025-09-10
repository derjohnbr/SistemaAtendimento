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
            dgvClientes.Columns["TipoPessoa"].Width = 70;
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
    }
}
