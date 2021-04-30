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
    public partial class FormPagamento : Form
    {
        private ControladorPagamento ControladorPagamento { get; set; }
        private bool Editando = false;
        private DataTable Dados;
        

        public FormPagamento(ControladorPagamento controladorPagamento)
        {
            ControladorPagamento = controladorPagamento;

            InitializeComponent();
            InstanciaDataTable();
            LimparTela();
            AtualizarTela();
        }

        private void InstanciaDataTable()
        {
            Dados = new DataTable();
            Dados.Columns.Add("ID");
            Dados.Columns.Add("FormaPagamento");

        }
        private void LimparTela()
        {
            txt_IdPagamento.Text = "";
            txt_FormaPagamento.Text = ""; 
        }

        private void AtualizarTela()
        {
            Dados.Clear();
            foreach (Pagamento Item in ControladorPagamento.Objetos)
            {
                DataRow Row = Dados.NewRow();
                Row["id"] = Item.ID;
                Row["FormaPagamento"] = Item.FormaPagamento;
                Dados.Rows.Add(Row);
            }

            dgv_Dados.DataSource = Dados;
            dgv_Dados.Refresh();

        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            var Linha = dgv_Dados.SelectedRows[0];
            DataRow DataRow = (Linha.DataBoundItem as DataRowView).Row;

            Pagamento p = null;
            foreach (Pagamento pag in ControladorPagamento.Objetos)
            {
                if (pag.ID.Equals(DataRow["Id"]))
                    p = pag;
            }

            ControladorPagamento.Objetos.Remove(p);
            AtualizarTela();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            var p = new Pagamento();

            p.ID = txt_IdPagamento.Text;
            p.FormaPagamento = txt_FormaPagamento.Text;
           

            ControladorPagamento.Salvar(p, Editando);

            Editando = false;

            LimparTela();
            AtualizarTela();

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Editando = true;

            var Linha = dgv_Dados.SelectedRows[0];
            DataRow DataRow = (Linha.DataBoundItem as DataRowView).Row;


            txt_IdPagamento.Text = DataRow["Id"].ToString();
            txt_FormaPagamento.Text = DataRow["FormaPagamento"].ToString();
            

        }

        private void FormPagamento_Load(object sender, EventArgs e)
        {

        }
    }
}
