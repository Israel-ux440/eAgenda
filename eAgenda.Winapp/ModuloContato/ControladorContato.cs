using eAgenda.Winapp.Compartilhado;

namespace eAgenda.Winapp.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        private RepositorioContato repositorioContato;
        private ListagemContatoControl ListagemContato;
        public ControladorContato(RepositorioContato repositorio)
        {
            repositorioContato = repositorio;
        }

        public override string TipoCadastro { get { return "Contatos"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo contato"; } }

        public override string ToolTipEditar { get { return "Editar um contato existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um contato existente"; } }

        public override void Adicionar()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

           DialogResult resultado =  telaContato.ShowDialog(); 

            if (resultado == DialogResult.OK)
            {
                Contato novoContato = telaContato.Contato;

                repositorioContato.Cadastrar(novoContato);

                MessageBox.Show("Informações Gravadas!");

                CarregarContatos();
            }
        }


        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            ListagemContato.AtualizarRegistros(contatos);
        }
        public override UserControl ObterListagem()
        {
            if (ListagemContato == null)
                ListagemContato = new ListagemContatoControl();

            CarregarContatos();

            return ListagemContato;
        }
    }
}

