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


        // CONTROLADORES        
        private ControladorFornecedor controladorFornecedor;
        private ControladorCliente controladorCliente;

        //TODO CRIAR
        //private ControladorProduto controladorProduto;
        //private ControladorCategoria controladorCategoria;
        //private ControladorPagamento controladorPagamento;
        //private ControladorVendedor controladorVendedor;


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

            // Menus Filhos
            ToolStripMenuItem menuItemCliente = new ToolStripMenuItem("CLIENTE", null, new EventHandler(MenuClienteClicado));
            ToolStripMenuItem menuItemVendedor = new ToolStripMenuItem("VENDEDOR", null, new EventHandler(MenuVendedorClicado));
            ToolStripMenuItem menuItemFornecedor = new ToolStripMenuItem("FORNECEDOR", null, new EventHandler(MenuFornecedorClicado));

            // Adcição de filhos
            menuCadastros.DropDownItems.Add(menuItemCliente);
            menuCadastros.DropDownItems.Add(menuItemVendedor);
            menuCadastros.DropDownItems.Add(menuItemFornecedor);

            ((ToolStripDropDownMenu)(menuCadastros.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(menuCadastros.DropDown)).ShowCheckMargin = true;

            // Assign the ToolStripMenuItem that displays 
            // the list of child forms.
            ms.MdiWindowListItem = menuCadastros;

            // Add the window ToolStripMenuItem to the MenuStrip.
            ms.Items.Add(menuCadastros);


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

            cliente.Id = 1;
            cliente.Nome = "José";
            cliente.Telefone = "45353535635";
            cliente.Email = "teste@teste.com";

            Clientes.Add(cliente);
        }

        private void InicializarControladores()
        {            
            controladorFornecedor = new ControladorFornecedor(Fornecedores);
            controladorCliente = new ControladorCliente(Clientes);
        }

        void MenuClienteClicado(object sender, EventArgs e)
        {
            Form f = new FormCliente(controladorCliente);
            f.MdiParent = this;
            f.Text = "Form - " + this.MdiChildren.Length.ToString();
            f.Show();
        }

        void MenuVendedorClicado(object sender, EventArgs e)
        {
            Form f = new Form();
            f.MdiParent = this;
            f.Text = "Form - " + this.MdiChildren.Length.ToString();
            f.Show();
        }

        private void MenuFornecedorClicado(object sender, EventArgs e)
        {
            Form f = new FormFornecedor(controladorFornecedor);
            f.MdiParent = this;
            f.Text = "Form - " + this.MdiChildren.Length.ToString();
            f.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
