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
    public partial class FormMain : Form
    {
        // OBJETOS        
        private List<object> Fornecedores = new List<object>();
        private List<object> Clientes = new List<object>();
        private List<object> Produtos = new List<object>();
        private List<object> Categorias = new List<object>();
        private List<object> Pagamentos = new List<object>();
        private List<object> Vendedores = new List<object>();
        private List<object> Vendas = new List<object>();


        // CONTROLADORES        
        private ControladorFornecedor controladorFornecedor;
        private ControladorCliente controladorCliente;
        private ControladorCategoria controladorCategoria;
        private ControladorVendedor controladorVendedor;
        private ControladorPagamento controladorPagamento;
        private ControladorProduto controladorProduto;
        private ControladorVenda controladorVenda;

       
        public FormMain()
        {
            this.IsMdiContainer = true;

            InicializarControladores();

            InicializarListas();

            InitializeComponent();

            // Create a MenuStrip control with a new window.
            MenuStrip ms = new MenuStrip();

            // Menu Pai
            ToolStripMenuItem menuCadastros = new ToolStripMenuItem("CADASTRO");
            ToolStripMenuItem menuVenda = new ToolStripMenuItem("VENDA");

            // Menus Filhos
            ToolStripMenuItem menuItemCliente = new ToolStripMenuItem("CLIENTE", null, new EventHandler(MenuClienteClicado));
            ToolStripMenuItem menuItemVendedor = new ToolStripMenuItem("VENDEDOR", null, new EventHandler(MenuVendedorClicado));
            ToolStripMenuItem menuItemFornecedor = new ToolStripMenuItem("FORNECEDOR", null, new EventHandler(MenuFornecedorClicado));
            ToolStripMenuItem menuItemCategoria = new ToolStripMenuItem("CATEGORIA PRODUTO", null, new EventHandler(MenuCategoriaClicado));
            ToolStripMenuItem menuItemPagamento = new ToolStripMenuItem("PAGAMENTO", null, new EventHandler(MenuPagamentoClicado));
            ToolStripMenuItem menuItemProduto = new ToolStripMenuItem("PRODUTO", null, new EventHandler(MenuProdutoClicado));

            ToolStripMenuItem menuItemVenda = new ToolStripMenuItem("VENDA", null, new EventHandler(MenuVendaClicado));

            // Adcição de filhos
            menuCadastros.DropDownItems.Add(menuItemCliente);
            menuCadastros.DropDownItems.Add(menuItemVendedor);
            menuCadastros.DropDownItems.Add(menuItemFornecedor);
            menuCadastros.DropDownItems.Add(menuItemCategoria); 
            menuCadastros.DropDownItems.Add(menuItemPagamento);
            menuCadastros.DropDownItems.Add(menuItemProduto);

            ((ToolStripDropDownMenu)(menuCadastros.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(menuCadastros.DropDown)).ShowCheckMargin = true;

            menuVenda.DropDownItems.Add(menuItemVenda);

            ((ToolStripDropDownMenu)(menuVenda.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(menuVenda.DropDown)).ShowCheckMargin = true;

            // Assign the ToolStripMenuItem that displays 
            // the list of child forms.
            ms.MdiWindowListItem = menuCadastros;

            // Add the window ToolStripMenuItem to the MenuStrip.
            ms.Items.Add(menuCadastros);
            ms.Items.Add(menuVenda);


            // Dock the MenuStrip to the top of the form.
            ms.Dock = DockStyle.Top;
            // The Form.MainMenuStrip property determines the merge target.
            this.MainMenuStrip = ms;
            // Add the MenuStrip last.
            // This is important for correct placement in the z-order.
            this.Controls.Add(ms);

        }

        

        private void InicializarListas()
        {
            var cliente = new Cliente();

            cliente.ID = "1";
            cliente.Nome = "José";
            cliente.Telefone = "45353535635";
            cliente.Email = "teste@teste.com";

            Clientes.Add(cliente);

            var fornecedor = new Fornecedor();

            fornecedor.ID = "1";
            fornecedor.Nome = "Maria";
            fornecedor.CNPJ = "123456789321";

            Fornecedores.Add(fornecedor);

            var categoria = new Categoria();
            categoria.ID = "1";
            categoria.Nome = "Açougue";

            Categorias.Add(categoria);

            var produto = new Produto()
            {
                Id = 1,
                Nome = "Chinelo de dedo",
                Preco = 25,
                Categoria = Categorias.FirstOrDefault() as Categoria,
                Fornecedor = Fornecedores.FirstOrDefault() as Fornecedor,
                QuantidadeEstoque = 20
            };

            Produtos.Add(produto);
        }

        private void InicializarControladores()
        {            
            controladorFornecedor = new ControladorFornecedor(Fornecedores);
            controladorCliente = new ControladorCliente(Clientes);
            controladorCategoria = new ControladorCategoria(Categorias);
            controladorVendedor = new ControladorVendedor(Vendedores);
            controladorPagamento = new ControladorPagamento(Pagamentos);
            controladorProduto = new ControladorProduto(Produtos);
            controladorVenda = new ControladorVenda(Vendas);
        }

        void MenuClienteClicado(object sender, EventArgs e)
        {
            Form f = new FormCliente(controladorCliente);
            f.MdiParent = this;
            f.Text = "CLIENTE";
            f.Show();
        }

        void MenuVendedorClicado(object sender, EventArgs e)
        {
            Form f = new FormVendedor(controladorVendedor);
            f.MdiParent = this;
            f.Text = "VENDEDOR";
            f.Show();
        }

        private void MenuFornecedorClicado(object sender, EventArgs e)
        {
            Form f = new FormFornecedor(controladorFornecedor);
            f.MdiParent = this;
            f.Text = "FORNECEDOR";
            f.Show();
        }

        private void MenuCategoriaClicado(object sender, EventArgs e)
        {
            Form f = new FormCategoria(controladorCategoria);
            f.MdiParent = this;
            f.Text = "CATEGORIA";
            f.Show();
        }

        private void MenuPagamentoClicado(object sender, EventArgs e)

        {
            Form f = new FormPagamento(controladorPagamento);
        f.MdiParent = this;
            f.Text = "PAGAMENTO";
            f.Show();
        }


        private void MenuProdutoClicado(object sender, EventArgs e)

        {
            Form f = new FormProduto(controladorProduto, controladorCategoria, controladorFornecedor);
            f.MdiParent = this;
            f.Text = "PRODUTO";
            f.Show();
        }

        private void MenuVendaClicado(object sender, EventArgs e)
        {
            Form f = new FormVenda(controladorProduto, controladorVenda, controladorCliente);
            f.MdiParent = this;
            f.Text = "VENDA";
            f.Show();
        }
    }
}
