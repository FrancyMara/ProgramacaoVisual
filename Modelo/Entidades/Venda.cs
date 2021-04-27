using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Venda: ClasseBase
    {

        public decimal ValorTotal { get; set; }
        public DateTime Data { get; set; }
        
        public Cliente Cliente { get; set; }

        public List<ItemVenda> Itens { get; set; }
    }
}
