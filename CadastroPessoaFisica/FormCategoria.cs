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
    public partial class FormCategoria : Form
    {
        private ControladorCategoria ControladorCategoria { get; set; }
        private List<object> Categoria = new List<object>();
        private bool Editando = false;
        private DataTable Dados;
        public FormCategoria()
        {
           
        }
        public FormCategoria(ControladorCategoria controladorCategoria)
        {
            ControladorCategoria = controladorCategoria;

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
        }
        private void LimparTela()
        {
            txt_IdCategoria.Text = "";
            txt_NomeCategoria.Text = "";
        }

        private void AtualizarTela()
        {

            Dados.Clear();
            foreach (Categoria Item in ControladorCategoria.Objetos)
            {
                DataRow Row = Dados.NewRow();
                Row["id"] = Item.ID;
                Row["nome"] = Item.Nome;
                Dados.Rows.Add(Row);
            }

            dgv_Dados.DataSource = Dados;
            dgv_Dados.Refresh();
        }


        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            var f = new Categoria();

            f.ID = txt_IdCategoria.Text;
            f.Nome = txt_NomeCategoria.Text;

            ControladorCategoria.Salvar(f, Editando);

            Editando = false;

            LimparTela();
            AtualizarTela();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Editando = true;

            var Linha = dgv_Dados.SelectedRows[0];
            DataRow DataRow = (Linha.DataBoundItem as DataRowView).Row;


            txt_IdCategoria.Text = DataRow["Id"].ToString();
            txt_NomeCategoria.Text = DataRow["nome"].ToString();
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            var Linha = dgv_Dados.SelectedRows[0];
            DataRow DataRow = (Linha.DataBoundItem as DataRowView).Row;

            Categoria c = null;
            foreach (Categoria ctg in ControladorCategoria.Objetos)
            {
                if (ctg.ID.Equals(DataRow["Id"]))
                    c = ctg;
            }

            ControladorCategoria.Objetos.Remove(c);
            AtualizarTela();
        }
    }
}
