using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entidades;

namespace Controller.Interfaces
{
    public interface IControllerCliente
    {
        bool Salvar(Cliente cliente, bool Editando);
        bool Remover(Cliente cliente);
        List<Cliente> GetClientes();
        Cliente GetCliente(string nome);
    }
}
