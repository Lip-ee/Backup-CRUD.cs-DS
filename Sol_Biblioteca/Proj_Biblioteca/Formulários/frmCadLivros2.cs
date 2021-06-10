using Proj_Biblioteca.Dados.DataSet_BibliotecaTableAdapters;
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
    public partial class frmCadLivros2 : Form
    {
        public frmCadLivros2()
        {
            InitializeComponent();
        }

        // Variável para checar se algo está sendo executado
        bool workingProgress;

        // BOTÕES

        // Botão "&New"
        private void btnNew_Click(object sender, EventArgs e)
        {
            // Quando o botão "&New" for pressionado:
            if(btnNew.Text == "&New")
            {
                // 1 - Configuração dos Campos
                workingProgress = true; // Tarefa em execução!

                btnCancel.Visible = true; // Botão Cancelar Visível

                HabilitarControles(); // Habilita todas as TextBox
                DesabilitarID(); // Desabilita a TextBox do ID

                txtTitulo.Focus(); // Foca na TextBox do Titulo

                btnEdit.Enabled = false; // Botão de Edição desabilitado
                btnDelete.Enabled = false; // Botão Delete desabilitado

                // 2 - Botão "&Save" aparece (de "&New" para "&Save")
                btnNew.Text = "&Save"; 

            }

            // Quando o botão "&Save" for pressionado:
            else
            {
                // 1 - Instanciar o obj do TableAdapter (criar obj)
                LivroTableAdapter objLivro = new LivroTableAdapter();

                // 2 - Salva (Insert) os Campos no BD:
                objLivro.Insert(txtTitulo.Text, txtAutores.Text, txtEditora.Text, dtpDataEdicao.Value, txtAssunto.Text);

                // 3 - Exibe uma mensagem de que não houve erros e exibe o último ID cadastrado
                string lastID = objLivro.UltimoID().ToString();
                MessageBox.Show($"Livro cadastrado com sucesso! \nO ID do ÚLTIMO Livro cadastrado é: {lastID}");

                // 4 - Campo do ID é preenchido pelo ultimo ID
                txtID.Text = lastID;

                // 5 - Configuração dos Campos
                LimparControles();
                DesabilitarControles();

                workingProgress = false;

                btnCancel.Visible = true; // Botão Cancelar Visível

                btnNew.Text = "&New"; // Botão "&New" aparece novamente (de "&Save" para "&New")
            }
        }

        // Botão "&Edit" [...]

        // Botão "&Cancel" [...]
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Configuração dos Campos
            DesabilitarControles();
            HabilitarID();

            LimparControles();

            btnEdit.Enabled = true; // Botão de Edição habilitado
            btnDelete.Enabled = true; // Botão Delete habilitado

            btnCancel.Visible = false; // Botão se torna Invisível
            btnNew.Text = "&New"; // Botão "&New" aparece novamente (de "&Save" para "&New")

            workingProgress = false; // Nada está sendo executado
        }

        // Botão "Exit"
        private void btnExit_Click(object sender, EventArgs e)
        {
            if(workingProgress == true)
            {
                if (MessageBox.Show("Parece que você está no meio de uma modificação ainda não salva no sistema." +
                    "Se o cadastro for fechado sem salvar, erros podem aparecer. \nDeseja mesmo fechar?", "AVISO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    // Fecha o Formulário
                    this.Close();
                };
                
            }
            else
            {
                // Fecha o Formulário
                this.Close();
            }
            
        }





        // MÉTODOS (FUNÇÕES)

        // Função "Habilitar Controles"
        private void HabilitarControles()
        {
            // Percorre os controles do formulário
            foreach (Control controle in this.Controls)
            {
                // Se esse controle for uma textbox ou um datetimepicker, então:
                if ((controle is TextBox) || (controle is DateTimePicker))
                {
                    // Habilite-o
                    controle.Enabled = true;
                }
            }
        }

        // Função "Desabilitar Controles"
        private void DesabilitarControles()
        {
            // Percorre os controles do formulário
            foreach (Control controle in this.Controls)
            {
                // Se esse controle for uma textbox ou um datetimepicker, então:
                if ((controle is TextBox) || (controle is DateTimePicker))
                {
                    // Desabilite-o
                    controle.Enabled = false;
                }
            }
        }



        // Função "Limpar Controles"
        private void LimparControles()
        {
            // Percorre os controles do formulário
            foreach (Control controle in this.Controls)
            {
                // Se esse controle for uma textbox
                if (controle is TextBox)
                {
                    // Limpe-o
                    (controle as TextBox).Clear();
                }

                // Se esse controle for um datetimepicker
                else if (controle is DateTimePicker)
                {
                    // Transforme-a em Data Atual
                    (controle as DateTimePicker).Value = DateTime.Now;
                }
            }
        }



        // Função "Habilitar ID"
        private void HabilitarID()
        {
            // Percorre os controles do formulário
            foreach (Control controle in this.Controls)
            {
                // Se esse controle for uma textbox ou um datetimepicker, então:
                if (controle == txtID)
                {
                    // Habilite-o
                    controle.Enabled = true;
                }
            }
        }

        // Função "Desabilitar ID"
        private void DesabilitarID()
        {
            // Percorre os controles do formulário
            foreach (Control controle in this.Controls)
            {
                // Se esse controle for uma textbox ou um datetimepicker, então:
                if (controle == txtID)
                {
                    // Habilite-o
                    controle.Enabled = false;
                }
            }
        }

        
    }
}
