using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Interfaces
{
  public interface IControllerVenda
    {
        bool Salvar(Venda venda, bool Editando);
        bool Remover(Venda venda);
        List<Venda> GetVenda();
        Venda GetVenda(int id );

    }
}
