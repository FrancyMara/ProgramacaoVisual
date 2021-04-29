using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entidades;

namespace Controller.Interfaces
{
    interface IControllerVendedor
    {
        bool Salvar(Vendedor vendedor , bool Editando);
        bool Remover(Vendedor vendedor);
        List<Vendedor> GetVendedor();
        Vendedor GetVendedor(string nome);

    }
}
