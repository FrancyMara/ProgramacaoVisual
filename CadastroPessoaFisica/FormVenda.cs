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
    public partial class FormVenda : Form
    {

        private ControladorProduto ControladorProduto { get; set; }
        private ControladorVenda ControladorVenda { get; set; }
        private ControladorCliente ControladorCliente { get; set; }

        private Venda NovaVenda;

        private DataTable Dados;


        public FormVenda(ControladorProduto controladorProdutos, ControladorVenda controladorVenda, ControladorCliente controladorCliente)
        {

            ControladorProduto = controladorProdutos;
            ControladorVenda = controladorVenda;
            ControladorCliente = controladorCliente;

            NovaVenda = new Venda();

            InitializeComponent();
            InstanciaDataTable();
            AtualizarTela();
            CarregarListas();
        }


        private void CarregarListas()
        {
            var bindingClientes = new BindingSource();
            bindingClientes.DataSource = ControladorCliente.Objetos;

            combo_Cliente.DataSource = bindingClientes.DataSource;
            combo_Cliente.DisplayMember = "Nome";

        }


        private void InstanciaDataTable()
        {
            Dados = new DataTable();
            Dados.Columns.Add("ID");
            Dados.Columns.Add("Nome");

        }

        private void AtualizarTela()
        {
            Dados.Clear();
            foreach (ItemVenda Item in NovaVenda.Itens)
            {
                DataRow Row = Dados.NewRow();
                Row["Id"] = Item.ID;
                Row["Nome"] = Item.Prod.Nome;
                Dados.Rows.Add(Row);
            }

            dgv_ItensVenda.DataSource = Dados;
            dgv_ItensVenda.Refresh();

            // Somar totais
            lbl_TotalVenda.Text = NovaVenda.Itens.Sum(it => (it.Prod.Preco* it.Quantidade)).ToString();
        }

        private void btn_AdicionarProdutoVenda(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_CodigoBarras.Text)) return;

            var codigoBarras = int.Parse(txt_CodigoBarras.Text);

            var produtoAdicionar = ControladorProduto.Objetos
                .FirstOrDefault(o => (o as Produto).Id == codigoBarras) as Produto;


            int somaProdutoVendidos = 0;

            foreach (Venda v in ControladorVenda.Objetos)
            {
                somaProdutoVendidos += v.Itens.Count;
            } 

            if(produtoAdicionar != null)
            {
                somaProdutoVendidos += 1;

                var novoItem = new ItemVenda()
                {
                    ID = somaProdutoVendidos,
                    Prod = produtoAdicionar,
                    Quantidade = 1,
                    Venda = NovaVenda
                };

                NovaVenda.Itens.Add(novoItem);

                // Limpa o campo código de barras
                txt_CodigoBarras.Text = string.Empty;

                AtualizarTela();
            }

        }

        private void btn_SalvarVenda_Click(object sender, EventArgs e)
        {
            if (!NovaVenda.Itens.Any())
            {
                MessageBox.Show("Adicione itens na venda seu cabaço");
                return;
            }
                

            ControladorVenda.Objetos.Add(NovaVenda);
            MessageBox.Show("FALOU VALEU");
            this.Close();
        }

    }
}
