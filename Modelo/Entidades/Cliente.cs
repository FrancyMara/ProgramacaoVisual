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

        public Cliente() { }
    }
}
