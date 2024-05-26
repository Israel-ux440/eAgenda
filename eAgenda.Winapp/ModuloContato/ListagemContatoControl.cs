using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.Winapp.ModuloContato
{
    public partial class ListagemContatoControl : UserControl
    {
        public ListagemContatoControl()
        {
            InitializeComponent();


            listContatos.Items.Add(
                new Contato(
                "Israel", 
                "49 99978-9076", 
                "israelfantoni04@gmail.com", 
                "Academia do Programador", 
                "Aluno")
                );


        }
    }
}
