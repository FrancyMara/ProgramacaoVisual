using System;

namespace Modelo.Entidades
{
    public abstract class Pessoa
    {
        public long IDPessoa { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        /* Endereço */
        public Endereco Local { get; set; }

        public DateTime DataCriacao { get; set; }

        public Pessoa() { }
    }
}