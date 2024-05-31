﻿
namespace eAgenda.Winapp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;
        public Contato Contato 
        {   
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                txtEmail.Text = value.Email;
                txtTelefone.Text = value.Telefone;
                txtCargo.Text = value.Cargo;
                txtEmpresa.Text = value.Empresa;
            }
            get
            { 
                return contato; 
            } 
        }
        public TelaContatoForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;
            string cargo = txtCargo.Text;
            string empresa = txtEmpresa.Text;

            contato = new Contato(nome, email, telefone, cargo, empresa);
        }

        private void TelaContatoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
