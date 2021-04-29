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
    public partial class FormFornecedor : Form
    {

        private ControladorFornecedor ControladorFornecedor { get; set; }
        private List<object> Fornecedor = new List<object>();
        private bool Editando = false;
        private DataTable Dados;

        public FormFornecedor(ControladorFornecedor controladorFornecedor)
        {
            ControladorFornecedor = controladorFornecedor;

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
            Dados.Columns.Add("CNPJ");
        }
        private void LimparTela()
        {
            txt_IdFornecedor.Text = "";
            txt_NomeFornecedor.Text = "";
            txt_CnpjFornecedor.Text = "";
        }

        private void AtualizarTela()
        {

            Dados.Clear();
            foreach (Fornecedor Item in ControladorFornecedor.Objetos)
            {
                DataRow Row = Dados.NewRow();
                Row["id"] = Item.ID;
                Row["nome"] = Item.Nome;
                Row["cnpj"] = Item.CNPJ;
                Dados.Rows.Add(Row);
            }

            dgv_Dados.DataSource = Dados;
            dgv_Dados.Refresh();
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            var Linha = dgv_Dados.SelectedRows[0];
            DataRow DataRow = (Linha.DataBoundItem as DataRowView).Row;

            Fornecedor f = null;
            foreach (Fornecedor frn in ControladorFornecedor.Objetos)
            {
                if (frn.ID.Equals(DataRow["Id"]))
                    f = frn;
            }

            ControladorFornecedor.Objetos.Remove(f);
            AtualizarTela();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            var f = new Fornecedor();

            f.ID = txt_IdFornecedor.Text;
            f.Nome = txt_NomeFornecedor.Text;
            f.CNPJ = txt_CnpjFornecedor.Text;

            ControladorFornecedor.Salvar(f, Editando);

            Editando = false;

            LimparTela();
            AtualizarTela();

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Editando = true;

            var Linha = dgv_Dados.SelectedRows[0];
            DataRow DataRow = (Linha.DataBoundItem as DataRowView).Row;


            txt_IdFornecedor.Text = DataRow["Id"].ToString();
            txt_NomeFornecedor.Text = DataRow["nome"].ToString();
            txt_CnpjFornecedor.Text = DataRow["cnpj"].ToString();

        }
    }
}
