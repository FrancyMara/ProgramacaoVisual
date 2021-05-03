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

        private Venda NovaVenda;

        public FormVenda(ControladorProduto controladorProdutos, ControladorVenda controladorVenda)
        {

            ControladorProduto = controladorProdutos;
            ControladorVenda = controladorVenda;

            NovaVenda = new Venda();

            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_AdicionarProdutoVenda(object sender, EventArgs e)
        {
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
            }
        }
    }
}
