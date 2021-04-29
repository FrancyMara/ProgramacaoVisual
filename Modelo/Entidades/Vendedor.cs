using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Vendedor : Pessoa
    {
        public string ID { get; set; }

        public string CPF { get; set; }

        public  Vendedor() {}


    public override bool Equals(object obj)
    {
            if (obj == null || obj?.GetType() != typeof(Vendedor))
                return false;

            var V = (obj as Vendedor);

            return ID.Equals(V.ID);

    }
        public override string ToString()
        {
            return $"ID: {ID}, {Nome}, CPF: {CPF}";
        }


    }



    


}
