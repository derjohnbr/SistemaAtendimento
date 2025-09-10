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
    public partial class FrmCadastroUsuario : Form
    {
        private UsuarioController _usuarioController;
        public FrmCadastroUsuario()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController(this);
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        internal void ExibirUsuarios(List<Usuarios> usuarios)
        {
            dgvUsuarios.DataSource = usuarios;
        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            _usuarioController.ListarUsuarios();

            dgvUsuarios.Columns["Id"].HeaderText = "Código";
            dgvUsuarios.Columns["Nome"].HeaderText = "Nome Completo";
            dgvUsuarios.Columns["Email"].HeaderText = "Email";
            // dgvUsuarios.Columns["Senha"].Visible = false; // Oculta a coluna Senha
            dgvUsuarios.Columns["Senha"].HeaderText = "Senha";
            dgvUsuarios.Columns["Perfil"].HeaderText = "Perfil";

            // Preenche o grid com ajuste automático
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Ajuste individual:
            dgvUsuarios.Columns["Id"].Width = 60;
            dgvUsuarios.Columns["Nome"].Width = 200;
            dgvUsuarios.Columns["Email"].Width = 200;
            dgvUsuarios.Columns["Senha"].Width = 100;
            dgvUsuarios.Columns["Perfil"].Width = 100;
        }


    }
}
