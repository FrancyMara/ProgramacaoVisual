using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.Interfaces;
using Modelo.Entidades;

namespace Controller.Funcoes
{
   public class ControladorVendedor : DAO.DB.Controller, IControllerVendedor
    {
        public ControladorVendedor(List<object> vendedores)
        {
            Objetos = vendedores;
        }

       public Vendedor GetVendedor(string nome)
        {
            foreach (var ven in Objetos)
            {
                var vendedor = (ven as Vendedor);

                if (vendedor.Nome.Equals(nome)) return vendedor;
            }

            return null;
        }

        public List <Vendedor> GetVendedor()
        {
            List<Vendedor> vendedor = new List<Vendedor>();

            foreach (var ven in Objetos)
            {
                vendedor.Add(ven as Vendedor);
            }

            return vendedor;
        }


        public bool Remover(Vendedor vendedor)
        {
            foreach (var ven in Objetos)
            {
                var temp = (ven as Vendedor);

                if(temp == vendedor)
                {
                    Objetos.Remove(vendedor);
                    return true;
                }
            }

            return false;
        }

       
        public bool Salvar(Vendedor vendedor, bool Editando)
        {
            if (vendedor == null)
                return false;

            if (Editando)
                for (int i = 0; i < Objetos.Count; i++)
                {
                    if (Objetos[i].Equals(vendedor))
                        Objetos[i] = vendedor;
                }
            else
                Objetos.Add(vendedor);

            return true;
        }
    }
}
