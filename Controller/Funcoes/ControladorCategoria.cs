using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.Interfaces;
using Modelo.Entidades;

namespace Controller.Funcoes
{
    public class ControladorCategoria : DAO.DB.Controller, IControllerCategoria
    {
        public ControladorCategoria(List<object> categoria)
        {
            Objetos = categoria;
        }

        public List<Categoria> GetCategoria()
        {
            List<Categoria> categoria = new List<Categoria>();

            foreach (var forn in Objetos)
            {
                categoria.Add(forn as Categoria);
            }

            return categoria;
        }

        public Categoria GetCategoria(string nome)
        {
            foreach (var forn in Objetos)
            {
                var categoria = (forn as Categoria);

                if (categoria.Nome.Equals(nome)) return categoria;
            }

            return null;
        }

        public bool Remover(Categoria categoria)
        {
            foreach (var cat in Objetos)
            {
                var temp = (cat as Categoria);

                if (temp == categoria)
                {
                    Objetos.Remove(categoria);
                    return true;
                }

            }

            return false;
        }

        public bool Salvar(Categoria categoria, bool Editando)
        {
            if (categoria == null)
                return false;

            if (Editando)
                for (int i = 0; i < Objetos.Count; i++)
                {
                    if (Objetos[i].Equals(categoria))
                        Objetos[i] = categoria;
                }
            else
                Objetos.Add(categoria);

            return true;
        }
    }
}
