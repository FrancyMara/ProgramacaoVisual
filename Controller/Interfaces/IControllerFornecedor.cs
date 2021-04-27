using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entidades;

namespace Controller.Interfaces
{
    public interface IControllerFornecedor
    
        {
        bool Salvar(Fornecedor fornecedor, bool Editando);
        bool Remover(Fornecedor fornecedor);
        List<Fornecedor> GetFornecedor();
        Fornecedor GetFornecedor(string nome);
    }
}

