using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    public class SituacaoAtendimentoController
    {
        private FrmCadastroSituacaoAtendimento _frmCadastroSituacaoAtendimento;
        private SituacaoAtendimentoRepository _situacaoAtendimentoRepository;
        public SituacaoAtendimentoController(FrmCadastroSituacaoAtendimento view) //Método Construtor
        {
            _frmCadastroSituacaoAtendimento = view;
            _situacaoAtendimentoRepository = new SituacaoAtendimentoRepository();
        }

        public void ListarSituacaoAtendimento()
        {
            try
            {
                var listaSituacaoAtendimentos = _situacaoAtendimentoRepository.Listar();
                _frmCadastroSituacaoAtendimento.ExibirSituacaoAtendimento(listaSituacaoAtendimentos);
            }
            catch (Exception ex)
            {
                _frmCadastroSituacaoAtendimento.ExibirMensagem($"Erro ao carregar os clientes: {ex.Message}");
            }
        }
    }
}
