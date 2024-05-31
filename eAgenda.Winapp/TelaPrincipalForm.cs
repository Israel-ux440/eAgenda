using eAgenda.Winapp.Compartilhado;
using eAgenda.Winapp.ModuloContato;

namespace eAgenda.Winapp
{
    public partial class TelaPrincipalForm : Form
    {

        ControladorBase controlador;

        RepositorioContato repositorioContato;
        public TelaPrincipalForm()
        {
            InitializeComponent();
            lblTipoCadastro.Text = string.Empty;

            repositorioContato = new RepositorioContato();
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repositorioContato);

            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

            ConfigurarToolTips(controlador);
            ConfigurarListagem(controlador);
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            btnAdicionar.ToolTipText = "Cadastrar um novo contato";
            btnEditar.ToolTipText = "Editar um contato existente";
            btnExcluir.ToolTipText = "Exlcuir um  contato existente";

        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }
        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;
        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemContato = controlador.ObterListagem();
            listagemContato.Dock = DockStyle.Fill;

            lblTipoCadastro.Controls.Clear();
            lblTipoCadastro.Controls.Add(listagemContato);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
        

  
