using Controller.Funcoes;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPessoaFisica
{
    public partial class FormProduto : Form
    {

        private ControladorProduto ControladorProduto { get; set; }
        private ControladorCategoria ControladorCategoria { get; set; }
        private ControladorFornecedor ControladorFornecedor { get; set; }

        private bool Editando = false;
        private DataTable Dados;

        public FormProduto(ControladorProduto controladorproduto, 
            ControladorCategoria controladorCategoria,
            ControladorFornecedor controladorFornecedor)
        {
            ControladorProduto = controladorproduto;
            ControladorCategoria = controladorCategoria;
            ControladorFornecedor = controladorFornecedor;

            InitializeComponent();
            InstaciaDataTable();
            LimparTela();
            AtualizarTela();

            CarregarListas();

            
        }

        private void CarregarListas()
        {
            var bindingCategorias = new BindingSource();
            bindingCategorias.DataSource = ControladorCategoria.Objetos;

            var bindingFornecedores = new BindingSource();
            bindingFornecedores.DataSource = ControladorFornecedor.Objetos;

            combo_Categoria.DataSource = bindingCategorias.DataSource;
            combo_Categoria.DisplayMember = "Nome";

            combo_Fornecedor.DataSource = bindingFornecedores.DataSource;
            combo_Fornecedor.DisplayMember = "Nome";
        
        }

        private void InstaciaDataTable()
        {
            Dados = new DataTable();
            Dados.Columns.Add("ID");
            Dados.Columns.Add("Nome");
            Dados.Columns.Add("Preco");
            Dados.Columns.Add("Estoque");
            Dados.Columns.Add("Categoria");
            Dados.Columns.Add("Fornecedor");
        }

        private void LimparTela()
        {
            txt_IdProduto.Text = "";
            txt_nomeProduto.Text = "";
            txt_precoProduto.Text = "";
            txt_estoqueProduto.Text = "";
        }

        private void AtualizarTela()
        {
            Dados.Clear();
            foreach (Produto Item in ControladorProduto.Objetos)
            {
                DataRow Row = Dados.NewRow();
                Row["id"] = Item.Id;
                Row["Nome"] = Item.Nome;
                Row["Preco"] = Item.Preco;
                Row["Estoque"] = Item.QuantidadeEstoque;
                Row["Categoria"] = Item.Categoria.Nome;
                Row["Fornecedor"] = Item.Fornecedor.Nome;

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
                if (prod.Id.Equals(DataRow["Id"]))
                    p = prod;
            }

            ControladorProduto.Objetos.Remove(p);
            AtualizarTela();
        }


        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            var p = new Produto();

            p.Id = int.Parse(txt_IdProduto.Text);
            p.Nome = txt_nomeProduto.Text;

            decimal resultado;

            if (decimal.TryParse(txt_precoProduto.Text, out resultado))
                p.Preco = resultado;
            else
            {
                MessageBox.Show("Preco inválido");
                return;
            }
                

            p.QuantidadeEstoque = decimal.Parse(txt_estoqueProduto.Text);

            p.Categoria = combo_Categoria.SelectedItem as Categoria;
            p.Fornecedor = combo_Fornecedor.SelectedItem as Fornecedor;


            ControladorProduto.Salvar(p, Editando);

            Editando = false;

            LimparTela();
            AtualizarTela();

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (dgv_Dados.SelectedRows.Count > 0)
            {
                Editando = true;

                var Linha = dgv_Dados.SelectedRows[0];
                var DataRow = (Linha.DataBoundItem as DataRowView).Row;


                txt_IdProduto.Text = DataRow["Id"].ToString();
                txt_nomeProduto.Text = DataRow["Nome"].ToString();
                txt_precoProduto.Text = DataRow["Preco"].ToString();
                txt_estoqueProduto.Text = DataRow["Estoque"].ToString();
            }
            else
            {
                MessageBox.Show("Selecione um produto");
            }

        }

        private void FormProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
