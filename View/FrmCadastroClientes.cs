using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
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

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                _clienteController.Salvar(cliente);
            }
            else
            {
                cliente.Id = Convert.ToInt32(txtCodigo.Text);
                _clienteController.Atualizar(cliente);
            }



        }

        public bool ValidarDados(Clientes cliente)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
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
            else
            {
                if (rdbFisica.Checked)
                {
                    // Verifica se CPF é válido!
                    if (!EhCpfValido(txtCpfCnpj.Text))
                    {
                        ExibirMensagem("CPF inválido.");
                        txtCpfCnpj.Focus();
                        return false;
                    }
                }
                else
                {
                    //Verifica se CNPJ é válido!
                    if (!EhCnpjValido(txtCpfCnpj.Text))
                    {
                        ExibirMensagem("CNPJ inválido.");
                        txtCpfCnpj.Focus();
                        return false;
                    }
                }
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
            if (string.IsNullOrWhiteSpace(txtBairro.Text))
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

        private void rdbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblCpfCnpj.Text = "CNPJ";
        }

        private void rdbFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblCpfCnpj.Text = "CPF";
        }

        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCelular.ReadOnly = false;
            pnlTipoPessoa.Enabled = true;
            txtCpfCnpj.ReadOnly = false;
            txtCep.ReadOnly = false;
            txtEndereco.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtBairro.ReadOnly = false;
            txtComplemento.ReadOnly = false;
            txtCidade.ReadOnly = false;
            cbxEstado.Enabled = true;
            pnlSituacao.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            rdbFisica.Checked = true;
            txtCpfCnpj.Clear();
            txtCep.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            cbxEstado.Text = "";
            rdbAtivo.Checked = true;
        }

        public void DesabilitarCampos()
        {
            LimparCampos();

            txtNome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtCelular.ReadOnly = true;
            pnlTipoPessoa.Enabled = false;
            txtCpfCnpj.ReadOnly = true;
            txtCep.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtNumero.ReadOnly = true;
            txtBairro.ReadOnly = true;
            txtComplemento.ReadOnly = true;
            txtCidade.ReadOnly = true;
            cbxEstado.Enabled = false;
            pnlSituacao.Enabled = false;

            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        // Método auxiliar para validação de CPF
        private static bool EhCpfValido(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "").Trim();
            if (cpf.Length != 11 || !cpf.All(char.IsDigit))
                return false;

            // Elimina CPFs com todos os dígitos iguais
            if (new string(cpf[0], cpf.Length) == cpf)
                return false;

            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            int digito = resto < 2 ? 0 : 11 - resto;
            tempCpf += digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            digito = resto < 2 ? 0 : 11 - resto;

            return cpf.EndsWith(tempCpf.Substring(9, 1) + digito.ToString());
        }

        // Método auxiliar para validação de CNPJ
        private static bool EhCnpjValido(string cnpj)
        {
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Trim();
            if (cnpj.Length != 14 || !cnpj.All(char.IsDigit))
                return false;

            // Elimina CNPJs com todos os dígitos iguais
            if (new string(cnpj[0], cnpj.Length) == cnpj)
                return false;

            int[] multiplicador1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            int digito = resto < 2 ? 0 : 11 - resto;
            tempCnpj += digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            digito = resto < 2 ? 0 : 11 - resto;

            return cnpj.EndsWith(tempCnpj.Substring(12, 1) + digito.ToString());
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void dgvClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaSelecionada = dgvClientes.Rows[e.RowIndex];

                txtCodigo.Text = linhaSelecionada.Cells["Id"].Value.ToString();
                txtNome.Text = linhaSelecionada.Cells["Nome"].Value.ToString();
                txtEmail.Text = linhaSelecionada.Cells["Email"].Value.ToString();
                txtCpfCnpj.Text = linhaSelecionada.Cells["Cpf_Cnpj"].Value.ToString();
                //if (linhaSelecionada.Cells["TipoPessoa"].Value.ToString() == "F")
                //    rdbFisica.Checked = true;
                //else
                //    rdbJuridica.Checked = true;
                rdbFisica.Checked = linhaSelecionada.Cells["TipoPessoa"].Value.ToString() == "F";
                rdbJuridica.Checked = linhaSelecionada.Cells["TipoPessoa"].Value.ToString() == "J";
                txtTelefone.Text = linhaSelecionada.Cells["Telefone"].Value.ToString();
                txtCelular.Text = linhaSelecionada.Cells["Celular"].Value.ToString();
                txtCep.Text = linhaSelecionada.Cells["Cep"].Value.ToString();
                txtEndereco.Text = linhaSelecionada.Cells["Endereco"].Value.ToString();
                txtNumero.Text = linhaSelecionada.Cells["Numero"].Value.ToString();
                txtComplemento.Text = linhaSelecionada.Cells["Complemento"].Value.ToString();
                txtBairro.Text = linhaSelecionada.Cells["Bairro"].Value.ToString();
                txtCidade.Text = linhaSelecionada.Cells["Cidade"].Value.ToString();
                cbxEstado.Text = linhaSelecionada.Cells["Estado"].Value.ToString();
                //if (Convert.ToBoolean(linhaSelecionada.Cells["Ativo"].Value))
                //    rdbAtivo.Checked = true;
                //else
                //    rdbInativo.Checked = true;
                rdbAtivo.Checked = Convert.ToBoolean(linhaSelecionada.Cells["Ativo"].Value);
                rdbInativo.Checked = !Convert.ToBoolean(linhaSelecionada.Cells["Ativo"].Value);

                btnNovo.Enabled = false;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnEditar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                ExibirMensagem("Nenhum cliente selecionado para exclusão.");
                return;
            }
            else
            {
                DialogResult resultado = MessageBox.Show($"Deseja Excluir este Cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtCodigo.Text);
                    _clienteController.Excluir(id);
                }
            }
        }

        private async Task BuscarEnderecoPorCep(string cep)
        {
            try
            {
                cep = cep.Replace("-", "").Trim();
                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";

                    var response = await client.GetAsync(url);

                    if(response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();

                        dynamic? dadosEndereco = JsonConvert.DeserializeObject(json);

                        txtEndereco.Text = dadosEndereco?.logradouro;
                        txtBairro.Text = dadosEndereco?.bairro;
                        txtCidade.Text = dadosEndereco?.localidade;
                        cbxEstado.Text = dadosEndereco?.uf;
                        txtNumero.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                ExibirMensagem($"Erro ao buscar o endereço: {ex.Message}");
            }
        }

        private async void txtCep_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCep.Text))
            { 
                await BuscarEnderecoPorCep(txtCep.Text);
            }
        }
    }
}
