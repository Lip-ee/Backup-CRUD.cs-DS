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
    public partial class frmCadLivros : Form
    {
        public frmCadLivros()
        {
            InitializeComponent();
        }

        private void livroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1_Biblioteca);

        }

        private void frmCadLivros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1_Biblioteca.Livro'. Você pode movê-la ou removê-la conforme necessário.
            this.livroTableAdapter.Fill(this.dataSet1_Biblioteca.Livro);

        }

        // Botão Excluir
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            // Configuração da caixa de alerta => Confirmar exclusão de registro
            if(MessageBox.Show("Deseja realmente excluir?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                // Remove o item selecionado
                livroBindingSource.RemoveCurrent();
                // Atualiza o DataGridView
                this.tableAdapterManager.UpdateAll(this.dataSet1_Biblioteca);
            }
        }
    }
}
