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

        public FormCliente(ControladorCliente controladorCliente)
        {
            ControladorCliente = controladorCliente;
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void CarregarCadastroLeaveId(object sender, EventArgs e)
        {
            var idClienteInformado = int.Parse(txt_IdCliente.Text);
            var clienteCadastrado = ControladorCliente.Objetos.FirstOrDefault(cliente => (cliente as Cliente).Id == idClienteInformado) as Cliente;

            if (clienteCadastrado == null) return;

            txt_NomeCliente.Text = clienteCadastrado.Nome;
            txt_EmailCliente.Text = clienteCadastrado.Email;
            txt_TelefoneCliente.Text = clienteCadastrado.Telefone;
        }
    }
}
