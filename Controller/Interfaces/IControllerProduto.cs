using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entidades;

namespace Controller.Interfaces
{
    public interface IControllerProduto
    
    
        {
            bool Salvar(Produto produto, bool editando);
            bool Remover(Produto produto);
            List<Produto> GetProduto();
            Produto GetProduto(string nome);
        }
    
}
