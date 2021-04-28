using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Cliente: Pessoa
    {        
        public string Telefone { get; set; }
        public string Email { get; set; }

        public string ID { get; set; }

        public Cliente() { }
        public override bool Equals(object obj)
        {

            if (obj == null || obj?.GetType() != typeof(Cliente))
                return false;

            var Cl = (obj as Cliente);

            return ID.Equals(Cl.ID) ;
        }

        public override string ToString()
        {
            return $"ID: {ID},{Nome}, Telefone: {Telefone}, Email: {Email}";
        }
    }
}
