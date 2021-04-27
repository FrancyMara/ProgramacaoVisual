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
    public partial class FormFornecedor : Form
    {

        private ControladorFornecedor ControladorFornecedor { get; set; }

        public FormFornecedor(ControladorFornecedor controladorFornecedor)
        {
            ControladorFornecedor = controladorFornecedor;

            InitializeComponent();
        }
    }
}
