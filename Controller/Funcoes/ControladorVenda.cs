using Controller.Interfaces;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Funcoes
{
    public class ControladorVenda : DAO.DB.Controller, IControllerVenda

    {
        
        public ControladorVenda(List<object> venda)
        {
            Objetos = venda;
        }
        
        
        public List<Venda> GetVenda()
        {
            List<Venda> venda = new List<Venda>();

            foreach (var forn in Objetos)
            {
                venda.Add(forn as Venda);
            }

            return venda;
        }

        public Venda GetVenda(int id)
        {
            foreach (var ven in Objetos)
            {
                var venda = (ven as Venda);

                if (venda.Id.Equals(id)) return venda;
            }

            return null;
        }

        public bool Remover(Venda venda)
        {
            throw new NotImplementedException();
        }

        public bool Salvar(Venda venda, bool Editando)
        {
            throw new NotImplementedException();
        }
    }
}
