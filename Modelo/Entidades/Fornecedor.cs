using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Fornecedor : Pessoa
    {
        public string Nome { get; set; }
        public string IE { get; set; }
        public string CNPJ { get; set; }


        public Fornecedor() { }

    }
}