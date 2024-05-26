using eAgenda.Winapp.Compartilhado;

namespace eAgenda.Winapp.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        public override string TipoCadastro { get { return "Contatos"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo contato"; } }

        public override string ToolTipEditar { get { return "Editar um contato existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um contato existente"; } }

        public override void Adicionar()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            telaContato.ShowDialog();
        }

        public override UserControl ObterListagem()
        {
            return new ListagemContatoControl();
        }
    }
}

