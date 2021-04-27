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
    public partial class FormPessoaFisica : Form
    {        
        private ControladorPessoaFisica controladorPessoaFisica;
        private bool Editando = false;

        private DataTable Dados;
        

        public FormPessoaFisica(ControladorPessoaFisica controlador)
        {
            InitializeComponent();

            // Iniciei o meu Controlador de Pessoa Física
            controladorPessoaFisica = controlador;

            InstanciaDataTable();
            LimparTela();
            AtualizarTela();
        }

        private void InstanciaDataTable()
        {
            Dados = new DataTable();
            Dados.Columns.Add("nome");
            Dados.Columns.Add("rg");
            Dados.Columns.Add("cpf");
            Dados.Columns.Add("datanascimento");
        }

        private void AtualizarTela()
        {
            //for (int i = 0; i < controlador.Objetos.Count; i++)
            //{
            //    PessoaFisica p = controlador.Objetos[i] as PessoaFisica;
            //}

            //foreach (PessoaFisica p in controlador.Objetos)
            //{
            //    lb_Itens.Items.Add(p);
            //}

            lb_Itens.Items.Clear();
            lb_Itens.Items.AddRange(controladorPessoaFisica.Objetos.ToArray());

            Dados.Clear();
            foreach (PessoaFisica Item in controladorPessoaFisica.Objetos)
            {
                DataRow Row = Dados.NewRow();
                Row["nome"] = Item.Nome;
                Row["rg"] = Item.RG;
                Row["cpf"] = Item.CPF;
                Row["datanascimento"] = Item.DataNascimento;
                Dados.Rows.Add(Row);
            }

            dgv_Dados.DataSource = Dados;
            dgv_Dados.Refresh();
        }

        private void LimparTela()
        {
            txt_Nome.Text = "";
            txt_RG.Text = "";
            txt_CPF.Text = "";
            txt_Nascimento.Value = DateTime.Now;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            //var p = (lb_Itens.SelectedItem as PessoaFisica);
            //if (!Editando)
            var p = new PessoaFisica();
            if (Editando)
            {
                var Linha = dgv_Dados.SelectedRows[0];
                DataRow DataRow = (Linha.DataBoundItem as DataRowView).Row;
                foreach (PessoaFisica item in controladorPessoaFisica.Objetos)
                    if (item.RG == DataRow["rg"].ToString() &&
                        item.CPF == DataRow["cpf"].ToString())
                        p = item;
            }

            p.Nome = txt_Nome.Text;
            p.RG = txt_RG.Text;
            p.CPF = txt_CPF.Text;
            p.DataNascimento = txt_Nascimento.Value;
            p.DataCriacao = DateTime.Now;

            controladorPessoaFisica.Salvar(p, Editando);

            Editando = false;

            LimparTela();
            AtualizarTela();
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            //var PessoaFisica = (lb_Itens.SelectedItem as PessoaFisica);
            //var Confirmacao = MessageBox.Show(this, "Deseja Remover o registro?",
            //                                        "ATENÇÃO!",
            //                                        MessageBoxButtons.YesNo) == DialogResult.Yes;
            //
            //if (PessoaFisica != null && Confirmacao)
            //{
            //    controladorPessoaFisica.Remover(PessoaFisica);
            //    AtualizarTela();
            //}

            var Linha = dgv_Dados.SelectedRows[0];
            DataRow DataRow = (Linha.DataBoundItem as DataRowView).Row;

            PessoaFisica p = null;
            foreach(PessoaFisica pf in controladorPessoaFisica.Objetos)
            {
                if (pf.RG.Equals(DataRow["rg"]) && pf.CPF.Equals(DataRow["cpf"]))
                    p = pf;
            }

            controladorPessoaFisica.Objetos.Remove(p);
            AtualizarTela();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            //var PessoaFisica = (lb_Itens.SelectedItem as PessoaFisica);
            //
            //txt_Nome.Text = PessoaFisica.Nome;
            //txt_RG.Text = PessoaFisica.RG;
            //txt_CPF.Text = PessoaFisica.CPF;
            //txt_Nascimento.Value = PessoaFisica.DataNascimento;
            //
            Editando = true;

            var Linha = dgv_Dados.SelectedRows[0];
            DataRow DataRow = (Linha.DataBoundItem as DataRowView).Row;

            //Dados.DefaultView.RowFilter = $"[rg] = '{DataRow["rg"]}' AND [cpf] = '{DataRow["cpf"]}'";
            //Dados.DefaultView[0]["nome"] = "";

            txt_Nome.Text = DataRow["nome"].ToString();
            txt_RG.Text = DataRow["rg"].ToString();
            txt_CPF.Text = DataRow["cpf"].ToString();
            txt_Nascimento.Value = Convert.ToDateTime(DataRow["datanascimento"]);
        }

        private void FormPessoaFisica_Load(object sender, EventArgs e)
        {

        }
    }
}
