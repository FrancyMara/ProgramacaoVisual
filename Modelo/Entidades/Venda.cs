using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Venda
    {
        public long ID { get; set; }
        public PessoaFisica Cliente { get; set; }

        public List<ItemVenda> Itens { get; set; }
    }
}
