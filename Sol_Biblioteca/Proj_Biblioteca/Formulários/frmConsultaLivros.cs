using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Biblioteca.Formulários
{
    public partial class frmConsultaLivros : Form
    {
        public frmConsultaLivros()
        {
            InitializeComponent();
        }

        private void frmConsultaLivros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1_Biblioteca.Livro'. Você pode movê-la ou removê-la conforme necessário.
            this.livroTableAdapter.Fill(this.dataSet1_Biblioteca.Livro);

        }

        // Botão Filtrar
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // Pegando valores dentro do menu dropdown => Coluna e Argumento
            string coluna = cbCol.Text, argumento = cbArg.Text;

            // Verificando o argumento utilizado
            switch (argumento)
            {
                // Caso argumento = "Começa com:", então:
                case "Começa com:":
                    // Pego o valor da variável e utilizo para fazer a busca dentro do SQL SERVER
                    livroBindingSource.Filter = $"CONVERT({coluna}, 'System.String') like '{txtPesquisa.Text}%'";
                    break;

                // Caso argumento = "Termina com:", então:
                case "Termina com:":
                    // Pego o valor da variável e utilizo para fazer a busca dentro do SQL SERVER
                    livroBindingSource.Filter = $"CONVERT({coluna}, 'System.String') like '%{txtPesquisa.Text}'";
                    break;

                // Caso argumento = "Que tenha:", então:
                case "Que tenha:":
                    // Pego o valor da variável e utilizo para fazer a busca dentro do SQL SERVER
                    livroBindingSource.Filter = $"CONVERT({coluna}, 'System.String') like '%{txtPesquisa.Text}%'";
                    break;
            }
        }
    }
}
