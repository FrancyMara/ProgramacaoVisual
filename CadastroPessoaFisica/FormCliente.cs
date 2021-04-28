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
    public partial class FormCliente : Form
    {
        private ControladorCliente ControladorCliente { get; set; }
        private List<object> Clientes = new List<object>();
        private bool Editando = false;
        private DataTable Dados;
        public FormCliente(ControladorCliente controladorCliente)
        {
            ControladorCliente = controladorCliente;
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
            Dados.Columns.Add("Telefone");
            Dados.Columns.Add("Email");
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {


        }

        private void CarregarCadastroLeaveId(object sender, EventArgs e)
        {
           // var idClienteInformado = int.Parse(txt_IdCliente.Text);
           // var clienteCadastrado = ControladorCliente.Objetos.FirstOrDefault(cliente => (cliente as Cliente).Id == idClienteInformado) as Cliente;

          //  if (clienteCadastrado == null) return;

           // txt_NomeCliente.Text = clienteCadastrado.Nome;
          //  txt_EmailCliente.Text = clienteCadastrado.Email;
          //  txt_TelefoneCliente.Text = clienteCadastrado.Telefone;
        }
        private void LimparTela()
        {
            txt_IdCliente.Text = "";
            txt_NomeCliente.Text = "";
            txt_TelefoneCliente.Text = "";
            txt_EmailCliente.Text = "";
        }

        private void AtualizarTela()
        {

           Dados.Clear();
            foreach (Cliente Item in ControladorCliente.Objetos)
            {
                DataRow Row = Dados.NewRow();
                Row["id"] = Item.ID;
                Row["nome"] = Item.Nome;
                Row["telefone"] = Item.Telefone;
                Row["email"] = Item.Email;
                Dados.Rows.Add(Row);
            }

            dgv_Dados.DataSource = Dados;
            dgv_Dados.Refresh();
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            var c = new Cliente();

            c.ID = txt_IdCliente.Text;
            c.Nome = txt_NomeCliente.Text;
            c.Telefone = txt_TelefoneCliente.Text;
            c.Email = txt_EmailCliente.Text;

            ControladorCliente.Salvar(c, Editando);

            Editando = false;

            LimparTela();
            AtualizarTela();
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            var Linha = dgv_Dados.SelectedRows[0];
            DataRow DataRow = (Linha.DataBoundItem as DataRowView).Row;

            Cliente c = null;
            foreach (Cliente cl in ControladorCliente.Objetos)
            {
                if (cl.ID.Equals(DataRow["Id"]) )
                    c = cl;
            }

            ControladorCliente.Objetos.Remove(c);
            AtualizarTela();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Editando = true;

            var Linha = dgv_Dados.SelectedRows[0];
            DataRow DataRow = (Linha.DataBoundItem as DataRowView).Row;


            txt_IdCliente.Text = DataRow["Id"].ToString();
            txt_NomeCliente.Text = DataRow["nome"].ToString();
            txt_TelefoneCliente.Text = DataRow["telefone"].ToString();
            txt_EmailCliente.Text = DataRow["email"].ToString();
        }
    }
}
