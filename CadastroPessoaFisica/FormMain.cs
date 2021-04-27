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

namespace CadastroPessoaFisica
{
    public partial class FormMain : Form
    {
        // TODAS AS LISTAS DE OBJETOS
        private List<object> Pessoas = new List<object>();
        // TODOS OS CONTROLADORES
        private ControladorPessoaFisica controladorPessoaFisica;


        public FormMain()
        {
            this.IsMdiContainer = true;

            InicializarControladores();            
            InitializeComponent();

            // Create ToolStripPanel controls.
            ToolStripPanel tspTop = new ToolStripPanel();
            ToolStripPanel tspBottom = new ToolStripPanel();
            ToolStripPanel tspLeft = new ToolStripPanel();
            ToolStripPanel tspRight = new ToolStripPanel();

            // Dock the ToolStripPanel controls to the edges of the form.
            tspTop.Dock = DockStyle.Top;
            tspBottom.Dock = DockStyle.Bottom;
            tspLeft.Dock = DockStyle.Left;
            tspRight.Dock = DockStyle.Right;

            // Create ToolStrip controls to move among the 
            // ToolStripPanel controls.

            // Create the "Top" ToolStrip control and add
            // to the corresponding ToolStripPanel.
            ToolStrip tsTop = new ToolStrip();
            tsTop.Items.Add("Top");
            tspTop.Join(tsTop);

            // Create the "Bottom" ToolStrip control and add
            // to the corresponding ToolStripPanel.
            ToolStrip tsBottom = new ToolStrip();
            tsBottom.Items.Add("Bottom");
            tspBottom.Join(tsBottom);

            // Create the "Right" ToolStrip control and add
            // to the corresponding ToolStripPanel.
            ToolStrip tsRight = new ToolStrip();
            tsRight.Items.Add("Right");
            tspRight.Join(tsRight);

            // Create the "Left" ToolStrip control and add
            // to the corresponding ToolStripPanel.
            ToolStrip tsLeft = new ToolStrip();
            tsLeft.Items.Add("Left");
            tspLeft.Join(tsLeft);

            // Create a MenuStrip control with a new window.
            MenuStrip ms = new MenuStrip();

            // Menu Pai
            ToolStripMenuItem menuCadastros = new ToolStripMenuItem("CADASTRO");

            // Menus Filhos
            ToolStripMenuItem menuItemCliente = new ToolStripMenuItem("CLIENTE", null, new EventHandler(MenuClienteClicado));
            ToolStripMenuItem menuItemVendedor = new ToolStripMenuItem("VENDEDOR", null, new EventHandler(MenuVendedorClicado));

            // Adcição de filhos
            menuCadastros.DropDownItems.Add(menuItemCliente);
            menuCadastros.DropDownItems.Add(menuItemVendedor);

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

            //// Add the ToolStripPanels to the form in reverse order.
            //this.Controls.Add(tspRight);
            //this.Controls.Add(tspLeft);
            //this.Controls.Add(tspBottom);
            //this.Controls.Add(tspTop);

            // Add the MenuStrip last.
            // This is important for correct placement in the z-order.
            this.Controls.Add(ms);

        }

        private void InicializarControladores()
        {
            controladorPessoaFisica = new ControladorPessoaFisica(Pessoas);
        }

        void MenuClienteClicado(object sender, EventArgs e)
        {
            Form f = new FormPessoaFisica(controladorPessoaFisica);
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
    }
}
