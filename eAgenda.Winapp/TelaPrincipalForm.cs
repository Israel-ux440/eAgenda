using eAgenda.Winapp.ModuloContato;

namespace eAgenda.Winapp
{
    public partial class TelaPrincipalForm : Form
    {
        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            btnAdicionar.ToolTipText = "Cadastrar um novo contato";
            btnEditar.ToolTipText = "Editar um contato existente";
            btnExcluir.ToolTipText = "Exlcuir um  contato existente";

            ListagemContatoControl listagemContato = new ListagemContatoControl();
            listagemContato.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear(); 
            pnlRegistros.Controls.Add(listagemContato);
        }
    }
}
        

  
