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

namespace SistemaAtendimento.View
{
    public partial class FrmCadastroEtapa : Form
    {
        private EtapaController _etapaController;
        public FrmCadastroEtapa()
        {
            _etapaController = new EtapaController(this);
            InitializeComponent();
        }
        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        internal void ExibirEtapas(List<Etapas> etapas)
        {
            dgvEtapas.DataSource = etapas;
        }

        private void FrmCadastroEtapa_Load(object sender, EventArgs e)
        {
            _etapaController.ListarEtapas();

            dgvEtapas.Columns["Id"].HeaderText = "Código";
            dgvEtapas.Columns["Nome"].HeaderText = "Nome da Etapa";
            dgvEtapas.Columns["Ordem"].HeaderText = "Ordem";
            dgvEtapas.Columns["Ativo"].HeaderText = "Ativo";

            // Preenche o grid com ajuste automático
            dgvEtapas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Ajuste individual:
            dgvEtapas.Columns["Id"].Width = 60;
            dgvEtapas.Columns["Nome"].Width = 200;
            dgvEtapas.Columns["Ordem"].Width = 100;
            dgvEtapas.Columns["Ativo"].Width = 60;
        }
    }
}
