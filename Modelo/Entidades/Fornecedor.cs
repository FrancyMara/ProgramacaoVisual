using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Fornecedor : Pessoa
    {           
        public string CNPJ { get; set; } 
        public string ID { get; set; }

        public Fornecedor() { }

        public override bool Equals(object obj)
        {

            if (obj == null || obj?.GetType() != typeof(Fornecedor))
                return false;

            var F = (obj as Fornecedor);

            return ID.Equals(F.ID);
        }

        public override string ToString()
        {
            return $"ID: {ID},{Nome}, CNPJ: {CNPJ}";
        }

    }
}