using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class ItemVenda
    {
        public long ID { get; set; }
        public decimal Quantidade { get; set; }

        public Venda Venda { get; set; }
        public Produto Prod { get; set; }

        public ItemVenda() { }
        public ItemVenda(long ID, decimal Quantidade, Produto Prod)
        {
            this.ID = ID;
            this.Quantidade = Quantidade;
            this.Prod = Prod;
        }
    }
}