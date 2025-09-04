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
    public partial class FrmCadastroSituacaoAtendimento : Form
    {
        private SituacaoAtendimentoController _situacaoAtendimentoController;

        public FrmCadastroSituacaoAtendimento()
        {
            _situacaoAtendimentoController = new SituacaoAtendimentoController(this);
            InitializeComponent();
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        internal void ExibirSituacaoAtendimento(List<SituacaoAtendimentos> situacaoAtendimentos)
        {
            dgvSituacoesAtendimento.DataSource = situacaoAtendimentos;
        }

        private void FrmCadastroSituacaoAtendimento_Load(object sender, EventArgs e)
        {
            _situacaoAtendimentoController.ListarSituacaoAtendimento();
        }
    }
}
