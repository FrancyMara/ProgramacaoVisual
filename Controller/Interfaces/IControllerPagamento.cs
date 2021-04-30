using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entidades;

namespace Controller.Interfaces
{
    public interface  IControllerPagamento
    {
        bool Salvar(Pagamento pagamento, bool Editando);
        bool Remover(Pagamento pagamento);
        List<Pagamento> GetPagamento();
        Pagamento GetPagamento(string FormaPagamento);
    }
}
