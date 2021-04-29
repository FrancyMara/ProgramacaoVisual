using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entidades;

namespace Controller.Interfaces
{
    interface IControllerCategoria
    {
        bool Salvar(Categoria categoria, bool Editando);
        bool Remover(Categoria categoria);
        List<Categoria> GetCategoria();
        Categoria GetCategoria(string nome);
    }
}
