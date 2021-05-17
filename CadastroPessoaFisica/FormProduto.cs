using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller.Funcoes;
using Modelo.Entidades;

namespace CadastroPessoaFisica
{
    public partial class FormProduto : Form
    {

        private ControladorProduto ControladorProduto { get; set; }
        private bool Editando = false;
        private DataTable Dados;
       

        public FormProduto(ControladorProduto controladorProduto)
        {
            ControladorProduto = controladorProduto;

            InitializeComponent();
            InstanciaDataTable();
            LimparTela();
            AtualizarTela();
        }

        private void InstanciaDataTable()
        {
            Dados = new DataTable();
            Dados.Columns.Add("ID");
            Dados.Columns.Add("Nome");
            Dados.Columns.Add("Preco");
            Dados.Columns.Add("QuantidadeEstoque");
            Dados.Columns.Add("Categoria");
            Dados.Columns.Add("Fornecedor");
        }

        private void LimparTela()
        {
            txt_ID.Text = "";
            txt_NomeProduto.Text = "";
            txt_ValorProduto.Text = "";
            txt_EstoqueProduto.Text = "";
            txt_CategoriaProduto.Text = "";
            txt_FornecedorProduto.Text = "";

        }

        private void AtualizarTela()
        {
            Dados.Clear();
            foreach (Produto Item in ControladorProduto.Objetos)
            {
                DataRow Row = Dados.NewRow();
                Row["id"] = Item.ID;
                Row["nome"] = Item.Nome;
                Row["valor"] = Item.Preco;
                Row["estoque"] = Item.QuantidadeEstoque;
                Row["categoria"] = Item.Categoria;
                Row["fornecedor"] = Item.Fornecedor;

                Dados.Rows.Add(Row);
            }

            dgv_Dados.DataSource = Dados;
            dgv_Dados.Refresh();
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            var Linha = dgv_Dados.SelectedRows[0];
            DataRow DataRow = (Linha.DataBoundItem as DataRowView).Row;

            Produto p = null;
            foreach (Produto prod in ControladorProduto.Objetos)
            {
                if (prod.ID.Equals(DataRow["Id"]))
                    p = prod;
            }

            ControladorProduto.Objetos.Remove(p);
            AtualizarTela();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            var prod = new Produto();

            prod.ID = txt_ID.Text;
            prod.Nome = txt_NomeProduto.Text;
            prod.Preco = txt_ValorProduto.Text;
            prod.QuantidadeEstoque = txt_EstoqueProduto.Text;
            prod.Categoria = txt_CategoriaProduto.Text;
           prod.Fornecedor = txt_FornecedorProduto.Text;

            int ValorInteiro = Convert.ToInt32(txt_ValorProduto.Text);
            decimal ValorDec = Convert.ToDecimal();


            


            ControladorProduto.Salvar(prod, Editando);

            Editando = false;

            LimparTela();
            AtualizarTela();

        }


        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Editando = true;

            var Linha = dgv_Dados.SelectedRows[0];
            DataRow DataRow = (Linha.DataBoundItem as DataRowView).Row;


            txt_ID.Text = DataRow["Id"].ToString();
            txt_NomeProduto.Text = DataRow["Nome"].ToString();
            txt_ValorProduto.Text = DataRow["Preco"].ToString();
            txt_EstoqueProduto.Text = DataRow["Estoque"].ToString();
            txt_CategoriaProduto.Text = DataRow["Categoria"].ToString();
            txt_FornecedorProduto.Text = DataRow["Fornecedor"].ToString();


        }

        private void FormProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
