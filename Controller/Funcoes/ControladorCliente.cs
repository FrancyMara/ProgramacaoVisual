using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.Interfaces;
using Modelo.Entidades;

namespace Controller.Funcoes
{
    public class ControladorCliente : DAO.DB.Controller, IControllerCliente
    {

        public ControladorCliente(List<object> clientes)
        {
            Objetos = clientes;
        }

        public Cliente GetCliente(string nome)
        {
            foreach (var cli in Objetos)
            {
                var cliente = (cli as Cliente);

                if (cliente.Nome.Equals(nome)) return cliente;
            }

            return null;
        }

        public List<Cliente> GetClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            foreach (var cli in Objetos)
            {
                clientes.Add(cli as Cliente);
            }

            return clientes;
        }

        public bool Remover(Cliente cliente)
        {
            foreach (var cli in Objetos)
            {
                var temp = (cli as Cliente);

                if (temp == cliente)
                {
                    Objetos.Remove(cliente);
                    return true;
                }
                    
            }

            return false;
        }

        public bool Salvar(Cliente cliente, bool Editando)
        {
  
                if (cliente == null)
                    return false;

                if (Editando)
                    for (int i = 0; i < Objetos.Count; i++)
                    {
                        if (Objetos[i].Equals(cliente))
                            Objetos[i] = cliente;
                    }
                else
                    Objetos.Add(cliente);

                return true;
            
        }
    }
}
