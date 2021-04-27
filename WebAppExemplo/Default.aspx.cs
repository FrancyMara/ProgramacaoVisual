using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppExemplo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Venda v = new Venda();
            v.ID = 1;

            v.Cliente = new PessoaFisica();
            v.Cliente.IDPessoa = 1;
            v.Cliente.CPF = "1234";
            v.Cliente.Nome = "José de Andrade";

            v.Itens = new List<ItemVenda>();
            v.Itens.Add(new ItemVenda(1, 10, new Produto(99, "Abacaxi", Convert.ToDecimal(7.00))));
            v.Itens.Add(new ItemVenda(2, 15, new Produto(65, "Maça", Convert.ToDecimal(2.50))));
            v.Itens.Add(new ItemVenda(3, 5, new Produto(42, "Manga", Convert.ToDecimal(6.80))));
            v.Itens.Add(new ItemVenda(4, 8, new Produto(65, "Maça", Convert.ToDecimal(2.50))));

            List<string> ProdutosDaMinhaVenda = new List<string>();
            long QuantidadeItens = v.Itens.Count;
            decimal QuantidadeProdutos = 0;
            decimal ValorTotalPedido = 0;
            foreach(ItemVenda Item in v.Itens)
            {
                QuantidadeProdutos = QuantidadeProdutos + Item.Quantidade;
                ValorTotalPedido = ValorTotalPedido + (Item.Quantidade * Item.Prod.Preco);
                if (!ProdutosDaMinhaVenda.Contains(Item.Prod.Nome))
                    ProdutosDaMinhaVenda.Add(Item.Prod.Nome);
            }

            string QuebraDeLinha = "<br />";

            DivTeste.InnerHtml = $@"Venda de Código: {v.ID}{QuebraDeLinha}
CPF/Cliente: {v.Cliente.CPF + " - " + v.Cliente.Nome}{QuebraDeLinha}
Quantidade de Itens: {QuantidadeItens}{QuebraDeLinha}
Quantidade de Produtos: {QuantidadeProdutos}{QuebraDeLinha}
Produtos da Venda: {string.Join(", ", ProdutosDaMinhaVenda)}{QuebraDeLinha}
Valor Total do Pedido: {ValorTotalPedido.ToString("c2")}";
        }
    }
}