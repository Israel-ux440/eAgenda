using eAgenda.Winapp.Compartilhado;
using eAgenda.Winapp.ModuloContato;

namespace eAgenda.Winapp
{
    public partial class TelaPrincipalForm : Form
    {

        ControladorBase controlador;
        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato();

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

            TelaContatoForm telaContato = new TelaContatoForm();

            telaContato.ShowDialog();
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

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemContato);
        }
    }
}
        

  
