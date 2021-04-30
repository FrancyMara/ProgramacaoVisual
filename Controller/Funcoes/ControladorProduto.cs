using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.Interfaces;
using Modelo.Entidades;

namespace Controller.Funcoes
{
    public class ControladorProduto : DAO.DB.Controller, IControllerProduto

    {
        public ControladorProduto(List<object> produto)
        {
            Objetos = produto;
        }

        public List<Produto> GetProduto()
        {
            List<Produto> produto = new List<Produto>();

            foreach (var forn in Objetos)
            {
                produto.Add(forn as Produto);
            }

            return produto;
        }

        public Produto GetProduto(string nome)
        {
            foreach (var prod in Objetos)
            {
                var produto = (prod as Produto);

                if (produto.Nome.Equals(nome)) return produto;
            }

            return null;
        }

        public bool Remover(Produto produto)
        {
            foreach (var prod in Objetos)
            {
                var temp = (prod as Produto);

                if (temp == produto)
                {
                    Objetos.Remove(produto);
                    return true;
                }

            }

            return false;
        }

        public bool Salvar(Produto produto, bool editando)
        {
            if (produto == null)
                return false;

            if (editando)
                for (int i = 0; i < Objetos.Count; i++)
                {
                    if (Objetos[i].Equals(produto))
                        Objetos[i] = produto;
                }
            else
                Objetos.Add(produto);

            return true;
        }
    }
   }

