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
    public partial class FormVendedor : Form
    {
        private ControladorVendedor ControladorVendedor { get; set; }        
        public bool Editando = false;
        private DataTable Dados;

        public FormVendedor(ControladorVendedor controladorVendedor)
        {
            ControladorVendedor = controladorVendedor;

            InitializeComponent();
            InstanciaDataTable();
            LimparTela();
            AtualizarTela();
        }

        private void AtualizarTela()
        {
            Dados.Clear();
            foreach (Vendedor Item in ControladorVendedor.Objetos)
            {
                DataRow Row = Dados.NewRow();
                Row["id"] = Item.ID;
                Row["nome"] = Item.Nome;
                Row["cpf"] = Item.CPF;
                Dados.Rows.Add(Row);
            }

            dgv_Dados.DataSource = Dados;
            dgv_Dados.Refresh();
        }
    

        private void InstanciaDataTable()
        {
            Dados = new DataTable();
            Dados.Columns.Add("ID");
            Dados.Columns.Add("Nome");
            Dados.Columns.Add("CPF");
        }

        private void LimparTela()
        {
            txt_IdVendedor.Text = string.Empty;
            txt_NomeVendedor.Text = string.Empty;
            txt_CpfVendedor.Text = string.Empty;
        }

        private void btn_SalvarVendedor(object sender, EventArgs e)
        {
            var v = new Vendedor();

            v.ID = txt_IdVendedor.Text;
            v.Nome = txt_NomeVendedor.Text;
            v.CPF = txt_CpfVendedor.Text;

            ControladorVendedor.Salvar(v, Editando);

            Editando = false;

            LimparTela();
            AtualizarTela();
        }

        private void btn_EditarVendedor(object sender, EventArgs e)
        {
            Editando = true;

            

            if(dgv_Dados.SelectedRows.Count > 0)
            {
                var Linha = dgv_Dados.SelectedRows[0];

                DataRow DataRow = (Linha.DataBoundItem as DataRowView).Row;


                txt_IdVendedor.Text = DataRow["Id"].ToString();
                txt_NomeVendedor.Text = DataRow["nome"].ToString();
                txt_CpfVendedor.Text = DataRow["cpf"].ToString();
            }            
        }

        private void btn_RemoverVendedor(object sender, EventArgs e)
        {
            var Linha = dgv_Dados.SelectedRows[0];
            DataRow DataRow = (Linha.DataBoundItem as DataRowView).Row;

            Vendedor v = null;
            foreach (Vendedor ven in ControladorVendedor.Objetos)
            {
                if (ven.ID.Equals(DataRow["Id"]))
                    v = ven;
            }

            ControladorVendedor.Objetos.Remove(v);
            AtualizarTela();
        }
    }
}
