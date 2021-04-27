using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.Interfaces;
using Modelo.Entidades;

namespace Controller.Funcoes


{
    public class ControladorFornecedor : DAO.DB.Controller, IControllerFornecedor
    {

        public ControladorFornecedor(List<object> fornecedores)
        {
            Objetos = fornecedores;
        }

        public Fornecedor GetFornecedor(string nome)
        {
            foreach (var forn in Objetos)
            {
                var fornecedor = (forn as Fornecedor);

                if (fornecedor.Nome.Equals(nome)) return fornecedor;
            }

            return null;
        }


        public List<Fornecedor> GetFornecedor()
        {
            List<Fornecedor> fonecedor = new List<Fornecedor>();

            foreach (var forn in Objetos)
            {
                fonecedor.Add(forn as Fornecedor);
            }

            return fonecedor;

        }

      
        public bool Remover(Fornecedor fornecedor)
        {
            foreach (var forn in Objetos)
            {
                var temp = (forn as Fornecedor);

                if (temp == fornecedor)
                {
                    Objetos.Remove(fornecedor);
                    return true;
                }

            }

            return false;
        }

        public bool Salvar(Fornecedor fornecedor, bool Editando)
        {
            Objetos.Add(fornecedor);
            return true;
        }
    }
}
