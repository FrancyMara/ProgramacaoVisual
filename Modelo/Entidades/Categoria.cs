using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Categoria
    {
        public string ID { get; set; }
        public string Nome { get; set; }

        public Categoria() { }

        public override bool Equals(object obj)
        {

            if (obj == null || obj?.GetType() != typeof(Categoria))
                return false;

            var categoria = (obj as Categoria);

            return ID.Equals(categoria.ID);
        }

        public override string ToString()
        {
            return $"ID: {ID},Categoria: {Nome}";
        }
    }
}
